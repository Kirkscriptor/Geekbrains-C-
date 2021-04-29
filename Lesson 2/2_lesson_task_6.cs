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


            // -------Начало задания 7.


            Console.Write("Введите cлово, которое нужно инвертировать\n");
            string ToInvert = Console.ReadLine();
            char[] charbreak = ToInvert.ToCharArray();

            for (int Counter = charbreak.Length - 1; Counter >= 0; Counter--)
            {

                Console.Write(charbreak[Counter]);
            }


            // -------Завершение задания 7.




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
