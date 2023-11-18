using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KalimullinaAH.Sprint5.Task3.V11.Lib;
namespace Tyuiu.KalimullinaAH.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExsistFile()
        {
            string path = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint5\Tyuiu.KalimullinaAH.Sprint5.Task3.V11\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
