using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.    Обязательная задача*. \n" +
                "Программно создайте текстовый файл и запишите в него 10 случайных чисел. \n" +
                "Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.");

            string patchFolder = "Temp_txt";
            string nameFile = "numbers.txt";
            string path_f = Path.Combine(patchFolder, nameFile);

            Random random = new Random();
            if (!Directory.Exists(patchFolder))
            {
                Directory.CreateDirectory(patchFolder);
            }

            using (StreamWriter sw = new StreamWriter(path_f, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(path_f)) 
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Sum={0}",sum);
            Console.ReadKey();

        }
    }
}
