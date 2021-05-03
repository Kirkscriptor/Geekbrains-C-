using System;
using System.Text;

namespace Lesson_3
{
    class Lesson_3_Task_2
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

           
            // --- Начало задания 2
            Console.WriteLine("Сколько контактов вы хотите добавить?");
            string contactsinn = Console.ReadLine();
            int arrayLength = Integertest(contactsinn);

            string[,] contacts = new string[arrayLength, 2];
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"Введите название контакта #{i + 1}");
                        contacts[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Введите номер телефона (11 цифр без знака \"+\") контакта #{i + 1}");
                        contacts[i, j] = Console.ReadLine();
                        contacts[i, j] = Phonetest(contacts[i, j]);
                    }

                }

            }

            Console.WriteLine("Нажмите любую клавишу, чтобы просмотреть список контактов");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"Имя пользователя: {contacts[i, j]}");
                    }
                    else
                    {
                        long temp = Int64.Parse(contacts[i, j]);
                        Console.WriteLine("Телефонный номер: " + temp.ToString("+# (###) ###-##-##"));
                    }

                }

                Console.Write("--------------------\n\n");
            }

            // --- Конец задания 2

            Console.ReadKey();

        }




        static string Phonetest(string intinput)
        {
            long result;
            _ = long.TryParse(intinput, out result);
            long digitCount = (uint)Math.Log10(result) + 1;


            while (digitCount != 11)
            {
                Console.WriteLine("Вы ввели некорректный номер. Номер должен состоять из 11 чисел. Повторите ввод.");
                intinput = Console.ReadLine();
                _ = long.TryParse(intinput, out result);
                digitCount = (long)Math.Log10(result) + 1;

            }


            result = Int64.Parse(intinput);


            return result.ToString();

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