using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KalimullinaAH.Sprint5.Task7.V6.Lib;
namespace Tyuiu.KalimullinaAH.Sprint5.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнилa: Калимуллина А.Х | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнилa: Калимуллина Алина Халимовна | ИИПб-23-1                      *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V21.txt файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и    *");
            Console.WriteLine("* скопировать в неё файл) в котором набор символьных данных. Заменить     *");
            Console.WriteLine("* все латинские буквы на #                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V6.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}

     
        