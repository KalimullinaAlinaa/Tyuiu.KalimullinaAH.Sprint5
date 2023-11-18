using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KalimullinaAH.Sprint5.Task2.V1.Lib;
namespace Tyuiu.KalimullinaAH.Sprint5.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint5\Tyuiu.KalimullinaAH.Sprint5.Task2.V1\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
