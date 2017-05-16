using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой член ряда Фибоначчи Вы хотите увидеть?");
            int num = Convert.ToInt32(Console.ReadLine()); //вывод целого числа // toint32 - перевод к челочисленному
            if (num > 48) // ограничение до 48
            {
                Console.WriteLine("Извините, программа способна высчитывать только до 48 члена ряда Фибоначчи.");

            }
            else if (num < 1) // не меньше 1
            {
                Console.WriteLine("В ряде Фибоначчи нет такого элемента.");
            }
            else
            {
                int one = 1;   //Всегда равны еденице
                int two = 1;   //Всегда равны еденице
                int sum = 0;    //Заноситься результат сложения первого и второго

                int j = 2; // Переменная которая считает элементы ряда
                while (j <= num) //Переменная j достигает того же числа что и ввел пользователь 
                {
                    sum = one + two;
                    one = two;
                    two = sum;

                    j++; // ++ добавить еденицу
                }
                Console.WriteLine("Под номером " + num + " в ряде Фибоначчи стоит число " + one);
            }
            Console.ReadLine();
        }
    }
}
/*
 Чи́сла Фибона́ччи — элементы последовательности в которой первые два числа равны либо 1 и 1, либо 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел.
*/
