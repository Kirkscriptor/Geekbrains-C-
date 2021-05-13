using System;
using System.Text;

namespace Lesson_3
{
    class Program
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





            // --- Начало задания 3

            Console.WriteLine("Введите строку, которую нужно инвертировать");
            string basedata = Console.ReadLine();
            char[] baseArray = basedata.ToCharArray();
            Array.Reverse(baseArray);
            basedata = new string(baseArray);
            Console.WriteLine(basedata);

            // --- Конец задания 3






            // --- Начало задания 4

            char[,] battleGround = new char[,] {
                { 'O', 'X', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'X' },
                { 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O', 'X' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                { 'O', 'X', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'X' },
                { 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O' },
                { 'O', 'O', 'O', 'X', 'O', 'X', 'O', 'O', 'X', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O' }
            };

            for (int i = 0; i < 10; i++)
            {
                for (int n = 0; n < 10; n++)
                {
                    Console.Write($"| {battleGround[i, n]} ");
                }
                Console.Write("|\n ----------------------------------------\n");
            }

            // --- Конец задания 4


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