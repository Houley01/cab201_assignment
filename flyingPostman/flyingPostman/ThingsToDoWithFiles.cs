using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace flyingPostman
{
    class ThingsToDoWithFiles
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

        public static string[] ReadFile(string fileName)
        {
            string informationInFile;
            // Clean user input
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "\n", "\r" };
            FileStream readfile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(readfile);

            informationInFile = reader.ReadToEnd();
            string[] informationInFileSplit = informationInFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            reader.Close();
            readfile.Close();
            return informationInFileSplit;
        } // End of ReadFile

        public static void WriteToFile(string fileName, int elapsedTime, int hours, int minutes, double tourLength, int tourStops, string[] tourPlan)
        {
            FileStream outfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outfile);
            // WRITE CODE HERE FOR OUTPUT
            /*  !!!!EXAMPLE OUTPUT!!!!
             Optimising tour length: Level 1... 
             Elapsed time: 123 seconds. 
             Tour time: 4 hours 0 minutes
             Tour length: 972.5855
             po 	 -> 	 yhn 	 23:00 	 23:28
             yhn 	 -> 	 wsx 	 23:28 	 00:10
             wsx 	 -> 	 edc 	 00:10 	 00:44
             edc 	 -> 	 rfv 	 00:44 	 01:30
             *** refuel 10 minutes ***
             rfv 	 -> 	 tgb 	 01:40 	 02:14
             tgb 	 -> 	 po 	 02:14 	 03:00
             */

            writer.WriteLine("Optimising tour length: Level 1.");
            writer.WriteLine("Elapsed time: {0} seconds.", elapsedTime);
            writer.WriteLine("Tour time: {0} Hours, {1} Minutes", hours, minutes);
            writer.WriteLine("Tour length: {0}", tourLength);
            for (int index = 0; index < tourStops; index++)
            {
                writer.WriteLine(tourPlan[index]);
            }
            writer.Close();
            outfile.Close();
        } // End of WriteToFile

    }
}
