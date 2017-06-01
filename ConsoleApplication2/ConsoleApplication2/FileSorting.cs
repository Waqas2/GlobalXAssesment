using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalXAssesment
{
    public class FileSorting
    {
        public string[] ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(@filePath);
            return lines;
        }

        public List<string> SortText(List<string> list)
        {
            list.Sort();
            return (list);
        }
        
        public void WriteFile(List<string> list)
        {
            string path = @"../../../name.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                    foreach (string name in list)
                    {
                        sw.WriteLine(name);
                    }
            }
        }
    }
}
