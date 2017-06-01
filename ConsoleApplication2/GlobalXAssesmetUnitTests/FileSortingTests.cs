using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace GlobalXAssesmetUnitTests
{
    [TestClass]
    public class FileSortingTests
    {
        GlobalXAssesment.FileSorting objFileSorting = new GlobalXAssesment.FileSorting();
        [TestMethod]
        public void ReadFileTest()
        {
            string fileName = @"../../../TestData.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            string[] names = objFileSorting.ReadFile(filePath);//Reading names from File into an array
            string[] expectedNames = { "BAKER,THEODORE", "SMITH,ANDREW", "KENT,MADISON", "SMITH,FREDRICK" };
            CollectionAssert.AreEqual(expectedNames, names);
        }

        [TestMethod]
        public void SortTextTest()
        {
            string fileName = @"../../../TestData.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            string[] names = objFileSorting.ReadFile(filePath);//Reading names from File into an array
            List<string> sortedNames = objFileSorting.SortText(new List<string>(names));
            string[] arrayExpectedSortedNames = { "BAKER,THEODORE", "KENT,MADISON","SMITH,ANDREW", "SMITH,FREDRICK" };
            List<string> listExpectedSortedNames = new List<string>(arrayExpectedSortedNames);

            CollectionAssert.AreEqual(listExpectedSortedNames, sortedNames);

        }
    }
}
