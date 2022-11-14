using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.    Обязательная задача*.\n" +
                " Выберите любую папку на своем компьютере, имеющую вложенные директории.\n" +
                " Выведите на консоль ее содержимое и содержимое всех подкаталогов.");
            string path = @"D:\LessonTemp";
            //string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string directory in directories)
            {
                Console.WriteLine(files);
                files = Directory.GetFiles(path);
                foreach (string file in files)
                    Console.WriteLine(directory);
            }
            Console.ReadKey();
        }
    }
}
