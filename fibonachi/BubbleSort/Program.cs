using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BubbleSort
{
    class Program
    {        
         //Метод, сортирующий массив целых чисел (по возрастанию)
         public static void Bubble_Sort(int[] anArray)
         {
             //Выводим элементы массива (массив в исходном виде), исключительно диагностический вывод информации
             PrintArray(anArray);
 
             //Основной цикл (количество повторений равно количеству элементов массива)
             for (int i = 0; i < anArray.Length; i++)
             {
                 //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
                 for (int j = 0; j < anArray.Length - 1 - i; j++)
                 {
                     //Если элемент массива с индексом j больше следующего за ним элемента
                     if (anArray[j] > anArray[j + 1])
                     {
                         //Меняем местами элемент массива с индексом j и следующий за ним
                         Swap(ref anArray[j], ref anArray[j + 1]);
                     }
                 }
 
                 //Выводим элементы массива после очередной итерации, исключительно диагностический вывод информации
                 PrintArray(anArray);
            }
        }
 
        //Вспомогательный метод, "меняет местами" два элемента
        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            //Временная (вспомогательная) переменная, хранит значение первого элемента
            int tmpParam = aFirstArg;
 
            //Первый аргумент получил значение второго
            aFirstArg = aSecondArg;
  
            //Второй аргумент, получил сохраненное ранее значение первого
            aSecondArg = tmpParam;
        }
 
        //Вспомогательный метод, выводящий на консоль элементы массива
        public static void PrintArray(int[] anArray)
        {
            //Перебор всех элементов массива
            for (int i = 0; i < anArray.Length; i++)
            {
                //Вывод значения текущего элемента и пробел после него
                Console.Write(anArray[i] + " ");
            }
 
            //Перевод строки
            Console.WriteLine("\n");
        }
 
        //Главный метод программы 
        static void Main(string[] args) 
        {
            //Некий массив целых чисел, который нужно отсортировать 
            Random r = new Random();
            int[] sort;
            int a;
            Console.WriteLine("Сколько чисел вы хотите вывести?");
            a = Convert.ToInt32(Console.ReadLine());
            sort = new int[a];
            for (int i = 0; i < a; i++)
            {
                sort[i] = r.Next(0, 10);
                Console.Write("");

            }

            //int[] sort = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0}; 

            //Сортируем его 
            Bubble_Sort(sort);

            //Чтобы окно быстро не закрылось 
            Console.WriteLine();
            Console.ReadKey(); 
        }
    }
}