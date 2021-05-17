using System;

namespace Lesson_4
{
    class Task2
    {

        static void Main(string[] args)
        {
           
            // Начало задания 2
            Console.WriteLine("Введите несколько чисел, разделенных пробелом");
            string inputNumbertoString = Console.ReadLine();
            string[] separate = inputNumbertoString.Split(" ");
            int summNumbers = 0;

            for (int i = 0; i < separate.Length; i++)
            {
                _= Int32.TryParse(separate[i], out int temp);
                summNumbers += temp;
            }
            Console.WriteLine(summNumbers);
            // Конец задания 2

        }




        static int Integertest(string intinput)
        {
            int result;
            int length = intinput.Length;
            _ = int.TryParse(intinput, out result);
            int digitCount = (int)Math.Log10(result) + 1;

            while (digitCount != length)
            {
                Console.WriteLine("Необходимо было ввести число. Повторите ввод.");
                intinput = Console.ReadLine();
                _ = int.TryParse(intinput, out result);
                digitCount = (int)Math.Log10(result) + 1;
                length = intinput.Length;

            }
            result = Int32.Parse(intinput);
            return result;

        }


    }
}
