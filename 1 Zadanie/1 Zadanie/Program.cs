using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/

namespace _1_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] array = GenerateRandomCharArray(5, 5);
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine();

            PrintArray(array);
            Console.WriteLine();

            var result = ConvertArrayToString(array);

            Console.WriteLine($"Полученная строка: {result}");
            Console.WriteLine();
            
        }

        //Функция рандомного заполнения массива
        static char[,] GenerateRandomCharArray(int row, int col)
        {
            char[,] randomArray = new char[row, col];
            Random rnd = new Random();
            for(int i=0;i<randomArray.GetLength(0); i++)
            {
                for(int j = 0; j < randomArray.GetLength(1); j++)
                {
                    randomArray[i, j] = (char)rnd.Next('a', 'z' + 1);
                }
            }
            return randomArray;
        }

        //Функция вывода массива
        static void PrintArray(char[,] array)
        {
            for(int i=0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        //Функция преобразования массива в строку
        static string ConvertArrayToString(char[,] array)
        {
            string result = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                }
            }
            return result;
        }
    }
}
