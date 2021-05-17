using System;
using System.IO;

namespace Lesson5Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Начало задания 1
            Console.WriteLine("Введите данные");
            string filename = "text.txt";
            
            string textinput = Console.ReadLine();
            File.AppendAllLines(filename, new[] { textinput });
            // Конец задания 1
        }
    }
}
