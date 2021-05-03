using System;
using System.Text;

namespace Lesson_3
{
    class Lesson_3_Task_3
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

            // --- Начало задания 3

            Console.WriteLine("Введите строку, которую нужно инвертировать");
            string basedata = Console.ReadLine();
            char[] baseArray = basedata.ToCharArray();
            Array.Reverse(baseArray);
            basedata = new string(baseArray);
            Console.WriteLine(basedata);

            // --- Конец задания 3

            Console.ReadKey();

        }


    }
}