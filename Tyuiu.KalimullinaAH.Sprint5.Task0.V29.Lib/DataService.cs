using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalimullinaAH.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = 6.1 * Math.Pow (x,3) + 0.23 * Math.Pow (x, 2) + 1.04 * Math.Pow (x, 3);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;


        }
    }
}
