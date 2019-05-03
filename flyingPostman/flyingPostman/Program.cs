using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace flyingPostman
{
    class Program
    {
        static void CheckNumberOfArguments(string[] inputCommands)
        {
            // To check the length of  
            // Command line arguments   
            if (inputCommands.Length == 5)
            {
                Console.WriteLine("Enough Arguments Were Passed");

                // To print the command line  
                // arguments using foreach loop 
                foreach (Object obj in inputCommands)
                {
                    Console.WriteLine(obj);
                }
            }
            else if (inputCommands.Length > 5 || inputCommands.Length < 6)
            {
                Console.WriteLine("5 or less, or greater then 7");
            }

            else
            {
                Console.WriteLine("No command line arguments found.");
            }
            Console.ReadKey();
        } // End of CheckNumberOfArguments

        static void CheckFilesExist(string[] inputCommands)
        {
            foreach(Object obj in inputCommands)
            {
                Console.Write("File Location: {0} ", obj);
                Console.WriteLine(File.Exists(obj.ToString()) ? "File exists. " : "File does not exist. ");
            }
        } // End of CheckFilesExist

        static void Main(string[] args)
        {
            CheckNumberOfArguments(args);
            CheckFilesExist(args);
        } // End of Main
    }
}
