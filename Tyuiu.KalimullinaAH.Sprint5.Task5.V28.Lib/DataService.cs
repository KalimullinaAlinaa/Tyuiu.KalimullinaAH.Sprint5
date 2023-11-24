using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            double factorial = 1;
            double s = double.MaxValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = Convert.ToDouble(line);
                    if (number > 0 && number % 5 == 0 && number < s)
                    {
                        s = number;
                        for (int i = 1; i <= s; i++)
                        {
                            factorial *= i;
                        }
                    }
                }
            }

            return Math.Round(factorial, 3);
        }
    }

}
