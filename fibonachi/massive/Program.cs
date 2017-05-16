using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; //объявили одномерный массив из 10 чисел. 
            int min; //минимальное
            int max; //максимальное
                      for (int i = 0; i != 10; i++) //массив заполняется в ручную
                      {
                          Console.WriteLine("Введите {0} элемент массива", i);
                          array[i] = Convert.ToInt32(Console.ReadLine()); // toint32 - перевод к челочисленному
                      }
            max = array[0]; //и максимальное и минимальное значение в начале равно первому элементу массива.
            min = array[0];
            for (int i = 1; i != 10; i++)
            {
                if (array[i] > max)//если текущий элемент больше максимального, то он становится максимальным.
                {
                    max = array[i];
                }
                if (array[i] < min)//если текущий элемент меньше минимального, то он становится минимальным.
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Максимальное число в массиве: {0}", max);
            Console.WriteLine("Минимальное число в массиве: {0}", min);
            Console.ReadKey();
           
        }
    }
}

