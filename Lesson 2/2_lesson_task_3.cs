using System;
using System.Text;

namespace Lesson_2
{
    class task3
    {
      
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

            
            // -------Начало задания 3.
            Console.Write("\n\n Введите любое число. Проверим, четное оно, или нет." + "\n");
            string numberCheckString = Console.ReadLine();
            int numberCheck = Integertest(numberCheckString);

            if (numberCheck % 2 == 0)
            {
                Console.Write("Это четное число\n\n");
            }
            else
            {
                Console.Write("Это нечетное число\n\n");
            }
            Console.WriteLine("\n--------------------------------\n\n\n");
            // -------Завершение задания 3.



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
