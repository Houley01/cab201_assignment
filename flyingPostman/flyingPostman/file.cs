using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace flyingPostman
{
    class file
    {
        public static void CheckNumberOfArguments(string[] inputCommands)
        {
            // To check the length of arguments given in the command line
            if (inputCommands.Length == 3)
            {
                Console.WriteLine("3 Arguments have been passed");

                // To print the command line  
                // arguments using foreach loop 
                foreach (Object obj in inputCommands)
                {
                    Console.WriteLine(obj);
                }
            }

            else if (inputCommands.Length == 5)
            {
                // Prints out arguments using foreach loop 
                Console.WriteLine("5 Arguments have been passed");
                foreach (Object obj in inputCommands)
                {
                    Console.WriteLine(obj);
                }
            }

            else if (inputCommands.Length == 1 || inputCommands.Length == 2 || inputCommands.Length == 3
                    || inputCommands.Length == 4 || inputCommands.Length >= 6)
            {
                // Tells the user that not enough or to many arguments have been entered.
                Console.WriteLine("Need 3 or 5 Arguments given.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else if (inputCommands.Length <= 0)
            {
                // Tells the user that no arguments were given.
                Console.WriteLine("No command line arguments found.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        } // End of CheckNumberOfArguments

        public static bool CheckFilesExist(string[] inputCommands)
        {
            bool doAllFilesExists = false;
            if (inputCommands.Length == 5)
            {
                // Console.Write("File Location: {0} ", inputCommands[0]);
                // Console.WriteLine(File.Exists(inputCommands[0].ToString()) ? "File exists. " : "File does not exist. ");
                // Console.Write("File Location: {0} ", inputCommands[1]);
                // Console.WriteLine(File.Exists(inputCommands[1].ToString()) ? "File exists. " : "File does not exist. ");
                // Console.Write("File Location: {0} ", inputCommands[4]);
                // Console.WriteLine(File.Exists(inputCommands[4].ToString()) ? "File exists. " : "File does not exist. ");

                if (File.Exists(inputCommands[0].ToString())) 
                {
                    doAllFilesExists = true;
                }
               else
               {
                    doAllFilesExists = false;
               }

                if (File.Exists(inputCommands[1].ToString()))
                {
                    doAllFilesExists = true;
                }
                else
                {
                    doAllFilesExists = false;
                }

                if (File.Exists(inputCommands[4].ToString()))
                {
                    doAllFilesExists = true;
                }
                else
                {
                    doAllFilesExists = false;
                }
            }

            if (inputCommands.Length == 3)
            {
                // Console.Write("File Location: {0} ", inputCommands[0]);
                // Console.WriteLine(File.Exists(inputCommands[0].ToString()) ? "File exists. " : "File does not exist. ");
                // Console.Write("File Location: {0} ", inputCommands[1]);
                // Console.WriteLine(File.Exists(inputCommands[1].ToString()) ? "File exists. " : "File does not exist. ");
                if (File.Exists(inputCommands[0].ToString()))
                {
                    doAllFilesExists = true;
                }
                else
                {
                    doAllFilesExists = false;
                }

                if (File.Exists(inputCommands[1].ToString()))
                {
                    doAllFilesExists = true;
                }
                else
                {
                    doAllFilesExists = false;
                }
            }
            return doAllFilesExists;
        } // End of CheckFilesExist
    }
}
