using System;

namespace Lesson_4
{
    class Task3
    {

        enum seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }


        static void Main(string[] args)
        {
           
            // Начало задания 3
            Console.WriteLine("Введите номер месяца");
            string inputMontNum = Console.ReadLine();
            int currentMonthNum = monthCheck(inputMontNum);

            if (currentMonthNum == 12 || currentMonthNum <= 2)
            {
                Console.WriteLine((seasons)0);
            }
            else if (currentMonthNum <= 5)
            {
                Console.WriteLine((seasons)1);
            }
            else if (currentMonthNum <= 8)
            {
                Console.WriteLine((seasons)2);
            }
            else
            {
                Console.WriteLine((seasons)3);
            }
            // Конец задания 3

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



        static int monthCheck(string monthNum)
        {
            int tempMonthNum = Integertest(monthNum);
            do
            {
                if (tempMonthNum < 1)
                {
                    Console.WriteLine("Номер месяца не может быть меньше 0. Повторите ввод.");
                    string temp = Console.ReadLine();
                    tempMonthNum = Integertest(temp);
                } else if (tempMonthNum > 12)
                {
                    Console.WriteLine("Номер месяца не может быть больше 12. Повторите ввод.");
                    string temp = Console.ReadLine();
                    tempMonthNum = Integertest(temp);
                }   else
                {
                    break;
                }
            } while (tempMonthNum < 1 || tempMonthNum > 12);

            return (tempMonthNum);
        }

    }
}
