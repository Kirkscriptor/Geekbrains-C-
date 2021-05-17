using System;

namespace Lesson_4
{
    class Task1
    {


        static void Main(string[] args)
        {
            //Начало задания 1
            Console.WriteLine("Сколько имен вы хотите ввести");
            string namesCountInn = Console.ReadLine();
            int namesCount = Integertest(namesCountInn);
            string[] namesArray = new string[namesCount];

            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Введите имя №{ i + 1 }");
                string firstName = Console.ReadLine();
                Console.WriteLine($"Введите фамилию №{ i + 1 }");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Введите отчество №{ i + 1 }");
                string patronymic = Console.ReadLine();
                namesArray[i] = GetFullName(firstName, lastName, patronymic);
            }

            Console.WriteLine();

            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"ФИО №{ i + 1 }: { namesArray[i] }");
            }
            //Конец задания 1


        }




        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string temp = lastName + " " + firstName + " " +  patronymic;
            return (temp);
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
