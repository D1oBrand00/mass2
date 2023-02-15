using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //В о.м. найти максимальный элемент и его индекс
            int[] array = new int[] { -3, 5, 28, 19, -2, -4, 0, 9 };
            int max = array[0];
            int indexMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }

            }
            //Console.WriteLine($"max = {max}\t indexmax = {indexmax}");
            //Console.ReadKey();

            //В о.м. найти минимальный элемент и его индекс
            //int[] arrayy = new int[] { -3, 5, 18, 19, -2, -4, 0, 9 };
            int min = array[0];
            int indexMin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }

            }
            //Console.WriteLine($"min = {min}\t indexmin = {indexmin}");
            //Console.ReadKey();

            int p = array[indexMax];
            array[indexMax] = array[indexMin];
            array[indexMin] = p;

            foreach (int elem in array)
            {
            Console.Write($"{elem}\t");
             }

            WriteLine();
             Write($"{Math.Abs(indexMax - indexMin) - 1}");

            for (int i = 0; i < array.Length; i++)
            {
                Write($"{array[i] + Math.Abs(i}");
            }

            

            Console.ReadKey();























        }



















        }
    }    


