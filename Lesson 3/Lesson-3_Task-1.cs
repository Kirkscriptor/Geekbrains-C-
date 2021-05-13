using System;
using System.Text;

namespace Lesson_3
{
    class Lesson_3_Task_1
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

            // --- Начало задания 1
            // Генерация случайной длины измерений массива 
            Random rnd = new Random();
            int arr1 = rnd.Next(20) + 1;
            int arr2 = rnd.Next(20) + 1;

            // Вывод для удобства проверки. 
            Console.WriteLine($"Arr1 {arr1}");
            Console.WriteLine($"Arr2 {arr2}");

            // Создаение двумерного массива на базе случайных длин изерений
            int[,] arrayTask1 = new int[arr1, arr2];

            Console.WriteLine("Вывод массива для проверки:");

            // Построчный вывод массива для проверки
            for (int i = 0; i < arr1; i++)
            {
                for (int j = 0; j < arr2; j++)
                {
                    arrayTask1[i, j] = rnd.Next(100);
                    Console.Write($"{arrayTask1[i, j]}, ");
                }
                Console.WriteLine("\n");

            }

            // Вывод значений массива по диагонали
            Console.WriteLine("\n\nВывод массива по диагонали");

            if (arr1 > arr2)
            {
                for (int n = 0; n < arr2; n++)
                {
                    Console.WriteLine(arrayTask1[n, n]);
                }
            }
            else
            {
                for (int n = 0; n < arr1; n++)
                {
                    Console.WriteLine(arrayTask1[n, n]);
                }
            }
            // --- Конец задания 1




            Console.ReadKey();

        }


    }
}