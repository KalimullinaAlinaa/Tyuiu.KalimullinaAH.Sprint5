using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint5.Task4.V8.Lib;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExists()
        {
            string path = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint5\Tyuiu.KalimullinaAH.Sprint5.Task4.V8\bin\Debug\DataSprint5\InPutDataFileTask4V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
