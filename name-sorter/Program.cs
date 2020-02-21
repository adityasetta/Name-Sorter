using name_sorter.Helpers;
using name_sorter.Utils;
using System;
using System.IO;

namespace Name_Sorter
{
    /// <summary>
    /// CLI Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // exit if the input is invalid
            if (!Validator.ValidateInput(args))
            {
                return;
            }

            string inputPath = args[0];
            string[] nameList = File.ReadAllLines(inputPath);

            ISorting sortingProcess = new Sorting(nameList);
            sortingProcess.Sort();

            // Write to cli
            foreach(string name in sortingProcess.SortedNames)
            {
                Console.WriteLine(name);
            }

            // write file to current directory
            File.WriteAllLines(Constants.OUTPUT_FILENAME, sortingProcess.SortedNames);
        }
    }
}
