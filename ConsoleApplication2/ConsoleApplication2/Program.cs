using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void DisplayFile(List<string> list) {
            System.Console.WriteLine("sort - names "); 
            foreach (string name in list)
            {
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine("Finished: created names-sorted.txt");
        }

        static void Main(string[] args)
        {
            GlobalXAssesment.FileSorting objFileSorting = new GlobalXAssesment.FileSorting();
            string fileName = @"../../../TestData.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            string[] names = objFileSorting.ReadFile(filePath);//Reading names from File into an array

            List<string> sortedNames = objFileSorting.SortText(new List<string>(names));//Sorting Array of names
            objFileSorting.WriteFile(sortedNames);//Writing Sorted names to a new File from array of names
            DisplayFile(sortedNames);

            Console.WriteLine("Press any key to exit.");
           // var userInput = System.Console.Read();
        }
    }
}
