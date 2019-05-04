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
        static void Main(string[] args)
        {
            file.CheckNumberOfArguments(args);
            if(file.CheckFilesExist(args) == true)
            {
                Console.WriteLine("All files exist");
            }
            if (file.CheckFilesExist(args) == false)
            {
                Console.WriteLine("one or more files do not exist");
            }
            Console.ReadKey();
        } // End of Main
    }
}
