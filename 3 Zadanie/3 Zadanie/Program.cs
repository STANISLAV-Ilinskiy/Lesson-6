using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте произвольную строку. Выясните, является ли она палиндромом.*/

namespace _3_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("Строка является палиндромом!");
            }
            else
            {
                Console.WriteLine("Строка  не является палиндромом!");
            }
        }
        //Функция проверки на палиндром
        static bool IsPalindrome(string value)
        {
            int min = 0, max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = value[min];
                char b = value[max];

                // Без учета регистра
                if (char.ToLower(a)!= char.ToLower(b))
                {
                    return false;
                }

                // С учетом регистра
               /*
                * if (a != b)
                {
                    return false;
                }
               */

                min++;
                max--;
            }

        }
    }
}
