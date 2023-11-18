using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalimullinaAH.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExits = fileInfo.Exists;

            if (fileExits)
            {
                File.Delete(path);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    
                }
            }

            string str = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(1) - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }

            return path;
        }
    }
}
