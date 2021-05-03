using System;
using System.Text;

namespace Lesson_2
{
    class task6
    {
      
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);


            // -------Начало задания 6.

            int[] Office = { 0b110011, 0b111010, 0b111111, 0b100000 };

            Console.WriteLine("Пожалуйста, укажите, в какой день недели вы хотите прийти в отделение банка. Укажите порядковый номер дня\n 1 - Понедельник \n 2 - Вторник \n 3 - Среда \n 4 - Четверг \n 5 - Пятница \n 6 - Суббота \n 7 - Воскресенье");
            string GetDay = Console.ReadLine();
            int maskCheck = Integertest(GetDay);

            while (maskCheck < 1 || maskCheck > 7)
            {
                Console.WriteLine("В неделе всего 7 дней. Введите число от 1 до 7");
                GetDay = Console.ReadLine();
                maskCheck = Integertest(GetDay);
            }

            maskCheck = 0b_100000 >> (maskCheck - 1);

            Console.WriteLine("");
            int i = 0;

            while (i < Office.Length)
            {

                if (maskCheck == (maskCheck & Office[i]))
                {
                    Console.WriteLine($"офис # {i + 1}");
                }

                i++;
            }

            Console.WriteLine("\n--------------------------------\n\n\n");

            // -------Завершение задания 6.




            Console.ReadKey();
        }



        // Почему TryParse отрабатывает, как true, если в начале введенной строки есть несколько чисел?
        // Метод, проверяющий возможность преобразовать введенные пользователем данные в переменную типа int
        static int Integertest(string intinput)
        {
            int result;
            
            //Первичное if-else поверх do-while введен, чтобы избежать ложного срабатывания предупреждения о некорректном формате введенных пользователем данных
            if (int.TryParse(intinput, out result) == false)
            {
                do
                {
                    Console.WriteLine("Вы ввели нечисловое значение. Попробуйте еще");
                    intinput = Console.ReadLine();

                } while (int.TryParse(intinput, out result) == false);

            } else
            {
                result = Int32.Parse(intinput);
            }

            return result;

        }


    }

}
