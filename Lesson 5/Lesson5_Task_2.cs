using System;
using System.IO;

namespace Lesson5Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Начало задания 2
            string startup = "startup.txt";
            File.AppendAllLines(startup, new[] { DateTime.Now.ToLongTimeString() });
            // Конец задания 2


        }
    }
}
