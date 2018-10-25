using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Integrity_Check
{
    //Algorithm
    //Get the CSV File
    //Submit File
    //Validate file
    //Open file 
    //Get Line Count
    //Read the file line by line
    //Split each line using the comma
    //pick first record
    //pick second record
    //pick third record
    //pick fourth record
    //Validate each Record to see if they meet the criteria
    //Display Result
    class CSV
    {
        string[] parts = new string[4];
        List<string> States = new List<string>(){"Imo","Lagos","Kaduna","Abuja"};
        int valid = 0, linecount = 0;
        static void Main(string[] args)
        {

            string filepath = "C:\\Users\\Stephen\\Documents\\Visual Studio 2017\\Projects\\DATA STRUCTURES & ALGORITHMS\\CSV Integrity Check\\CSVFiles\\TestFile.csv";
            CSV cs = new CSV();
            Console.WriteLine("System is checking \n '{0}' \n" ,filepath);
            while (cs.ValidateFileExtension(filepath))
            {
                Console.WriteLine("Validating file extension \n");
                Console.WriteLine("File Extension is Valid \n");
                cs.ValidateFileContents(filepath);
                break;
            }
            Console.WriteLine("\n{0} lines Valid, {1} lines Invalid \n", cs.valid, (cs.linecount - cs.valid) - 1);
            Console.Read();
        }

        public bool ValidateFileExtension(string filepath)
        {
            string ext = Path.GetExtension(filepath);
            switch (ext)
            {
                case ".csv":
                    return true;
                default:
                    return false;
            }

        }

        public void ValidateFileContents(string filepath)
        {
            using (StreamReader stream = new StreamReader(filepath))
            {
                string line;
                linecount = File.ReadLines(filepath).Count();
                int count = Convert.ToInt32(linecount);
                for (int i = 0; i <= count; i++)
                {                 
                    if ((line = stream.ReadLine()) != null)
                    {                    
                        parts = line.Split(',');
                        while (i > 0)
                        {
                            if (IntegrityCheck(0))
                                Console.WriteLine("Line {0} is Valid", i);
                            else
                                Console.WriteLine("Line {0} is Invalid", i);

                            break;
                        }
                    }
                }
            }
        }

        public bool IntegrityCheck(int validcount)
        {
            if (ValidateName(parts[0]))
                validcount++;

            if (ValidateAge(int.Parse(parts[1])))
                validcount++;

            if (ValidateGender(parts[2]))
                validcount++;

            if (ValidateStates(parts[3]))
                validcount++;

            switch (validcount)
            {
                case 0:
                    return false;
                case 1:
                    return false;
                case 2:
                    return false;
                case 3:
                    return false;
                case 4:
                    valid++;
                    return true;
            }
            return false;   
        }

        public bool ValidateName(string name)
        {
            if (name != null || name != "")
                return true;
            else
                return false;
        }

        public bool ValidateAge(int age)
        {           
            if (age > 0)
                return true;
            else
                return false;
        }

        public bool ValidateGender(string gender)
        {
            if (gender == "M" || gender == "F")
                return true;
            else
                return false;
        }

        public bool ValidateStates(string state)
        {
            if (States.Contains(state))
                return true;
            else
                return false;
        }

    }
}
