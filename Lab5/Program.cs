using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const int n = 7;
            int[] array = new int[n];

            for (int i=0; i<n;i++)

            {
                
                Console.Write("Введите элемент массива {0}:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            float S = 0;
            Console.WriteLine("Вывод массива:");
            for (int i=0; i<n;i++)

            {
                S += array[i];
                Console.Write("{0}  ", array[i]);

            }

            Console.Write("Среднее арифметическое чисел массива = {0:f2}  ", S/n);
            Console.ReadKey();
        }
    }
}
