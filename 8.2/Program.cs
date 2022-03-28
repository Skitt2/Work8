using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.");
            string path = "log4.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 50);
                    sw.WriteLine("{0} ", array[i]);
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.WriteLine();
            int d1;
            int d=0;
            using (StreamReader sr = new StreamReader(path))
            {
               for (int i = 0; i < 10; i++)
                {
                    d1 = Convert.ToInt32(sr.ReadLine());
                    d = d + d1;
                }
            }
            Console.WriteLine("Сумма чисел в файле равна = {0}", d);
            Console.ReadKey();
        }
    }
}
