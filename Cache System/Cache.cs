using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cache_System
{

    //Algorithm
    //Create A cache
    //set key & value
    //set timeout function
    //add to cache
    //get from cache
    //create delay fucntion

    class Cache
    {
        public Dictionary<int, string> cachestore;
        public string value;
        public int key;

        public Cache()
        {
            cachestore = new Dictionary<int, string>();
            value = "";
            key = 0;
        }

        static void Main(string[] args)
        {
            Cache c = new Cache
            {
                key = 10,
                value = "Stephen"
            };
            c.AddThread(c.key,c.value);
            c.Print();
            c.GetThread(c.key);


            Console.Read();
        }

        public bool Exists(int key)
        {
            return cachestore.ContainsKey(key);
        }
        public void Print()
        {
            int length = cachestore.Count();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("\n {0}", cachestore.ElementAt(i));
            }
        }
        public void AddThread(int key, string value)
        {
            try
            {
                Thread t = new Thread(() => Add(key, value));
                t.Start();
                if (!t.Join(TimeSpan.FromSeconds(30)))
                {
                    t.Abort();
                    throw new Exception("Function Timeout");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("System was unable to add record {0},{1} due to {3}",key,value,ex.ToString());
                Thread.Sleep(1000);
            }
            
        }
        public void Add(int key, string value)
        {
            if (!Exists(key))
            {
                cachestore.Add(key, value);
                Console.WriteLine("{0} has been added!", value);
            }
            else
                Console.WriteLine("{0} already exists in cache");
        }
        public void GetThread(int key)
        {
            Thread g = new Thread(() => Get(key));
            g.Start();
            if (!g.Join(TimeSpan.FromSeconds(30)))
            {
                g.Abort();
                throw new Exception("Function Timeout");
            }
        }
        public void Get(int key)
        {   
            if (cachestore.ContainsKey(key) == true)
            {
                cachestore.TryGetValue(key, out value);
                Console.WriteLine("{0}", value);
            }
            else
                Console.WriteLine("Value not found");
        }  
    }
}
