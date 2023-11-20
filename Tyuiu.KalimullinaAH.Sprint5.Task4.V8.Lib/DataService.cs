using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round((Math.Pow(Convert.ToDouble(strX), 2)) / (Math.Sin(Convert.ToDouble(strX)))+3,3);
                return res;
        }
    }
}
