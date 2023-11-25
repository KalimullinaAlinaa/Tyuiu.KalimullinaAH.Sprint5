using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint5.Task7.V6.Lib;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint5.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint5\Tyuiu.KalimullinaAH.Sprint5.Task7.V6\bin\Debug\OutPutDataFileTask7V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
        [TestMethod]
        public void CheckedExistsFileInPut()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
        
}
