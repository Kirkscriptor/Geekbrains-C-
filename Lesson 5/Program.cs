using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Начало задания 2
            string startup = "startup.txt";
            File.AppendAllLines(startup, new[] { DateTime.Now.ToLongTimeString() });
            // Конец задания 2


            // Начало задания 1
            Console.WriteLine("Введите данные");
            string filename = "text.txt";
            
            string textinput = Console.ReadLine();
            File.AppendAllLines(filename, new[] { textinput });
            // Конец задания 1


            // Начало задания 3
            Console.WriteLine("Введите несколько чисел от 0 до 255, разделенных пробелом");
            string inputNumbertoString = Console.ReadLine();
            string[] separate = inputNumbertoString.Split(" ");
            int ArrLength = separate.Length;
            byte[] byteArr = new byte[ArrLength];

            for (int i = 0; i < separate.Length; i++)
            {
                _ = Byte.TryParse(separate[i], out byte temp);
                byteArr[i] = temp;
                Console.WriteLine(byteArr[i]);
            }

            File.WriteAllBytes("bytes.bin", byteArr);
            // Конец задания 3


        }
    }
}
