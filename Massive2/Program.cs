using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            //int[] array = { -7, 10, 5, 16, -4, 18 };
            //for (int i = array.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine($"array[{i}]= {array[i]}");
            //}
            //Console.ReadKey();

            //2 Заполнить одномерный массив случайным образом, посчитать количество отрицательных элементов
            //Console.Write("n= ");
            //byte n = Convert.ToByte(Console.ReadLine());
            //int[] mass = new int[n];
            //Random rnd = new Random();
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(-10, 10);
            //    Console.WriteLine($"array[{i}]= {mass[i]}");
            //}

            //byte count = 0;
            //foreach (int elem in mass)
            //{
            //    if (elem < 0) count++;
            //}
            ////for (int i = 0; i < mass.Length; i++)
            ////{
            ////    if (mass[i] < 0)
            ////    count++;
            ////}
            //Console.WriteLine($"Кол-во элементов = {count}");

            //3 В одномерном массиве значение всех элементов увеличить в два раза
            int[] array = { -5, 5, -6, 6, -7, 7 };
            for (int i = 0;i<array.Length;i++)
            {
                array[i] *= 2; //array[i] = array[i]*2;
                Console.Write($"{array[i]}\t");
            }
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            Console.ReadKey();










        }
    }
}
