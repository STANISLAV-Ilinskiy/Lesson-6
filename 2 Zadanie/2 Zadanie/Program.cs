using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте строку, содержащую латинские буквы в обоих регистрах. 
 * Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/

namespace _2_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = GenerateRandomString(10);
            Console.WriteLine("Рандомная строка: " + randomString);
            Console.WriteLine();
            string lowerCaseString = ConvertToLowerCase(randomString);
            Console.WriteLine("Строка в нижнем регистре: " + lowerCaseString);
            Console.WriteLine();
        }

        //Функция рандомной генерации строки с латинскими символами в обоих регистрах
        static string GenerateRandomString(int lenght)
        {
            Random rnd = new Random();
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            string result = "";
            for(int i = 0; i < lenght; i++)
            {
                result += chars[rnd.Next(chars.Length)];
            }
            return result;
        }

        //Функция преобразования символов верхнего регистра в нижний регистр
        static string ConvertToLowerCase(string str)
        {
            return str.ToLower();
        }

    }
}
