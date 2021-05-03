using System;
using System.Text;

namespace Lesson_2
{
    class task125
    {
      
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

            // -------Начало задания 1.

            // Массив содержит набор запросов к пользователю в текстовом эквиваленте. Также количество его значений служит счетчиком операций.
            string[] datatype = { "максимальную", "минимальную", "еще какую-то", "и еще другую" };
            byte length = (byte)datatype.Length;

            //Массив для записи полученных от пользователя значений, приобразованных в числа
            int[] newtemp = new int[length];

            // Цикл для последовательного запроса данных, исходя из запросов, находящихся в массиве
            for (byte k = 0; k < datatype.Length; k++)
            {
                Console.Write("Введите " + datatype[k] + " температуру за сутки:");
                string inputtemp = Console.ReadLine();
                newtemp[k] = Integertest(inputtemp);
            }

            float tempSumm = 0;

            for (byte e = 0; e < newtemp.Length; e++)
            {
                tempSumm += newtemp[e];
            }

            tempSumm /= newtemp.Length;

            Console.Write("Среднесуточная температура составила " + Math.Round(tempSumm, 2) + " С" + "\n");
            Console.WriteLine("\n--------------------------------\n\n\n");
            // -------Завершение задания 1.




            // -------Начало задания 2.

            string[] Months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            Console.Write("Введите ткущий номер месяца" + "\n");
            string monthInput = Console.ReadLine();
            int monthNumber = Integertest(monthInput);

            if (monthNumber < 1)
            {
                Console.Write("Извиние, но в году не может быть отрицательного или нулевого количества месяцев." + "\n");
                monthNumber = Checkmonth(monthNumber);

            }
            else if (monthNumber > 12)
            {
                Console.Write("Извиние, но в году не может быть больше 12 месяцев." + "\n");
                monthNumber = Checkmonth(monthNumber);
            }


            Console.Write("Сейчас за окном " + Months[monthNumber - 1] + "." + "\n");
            Console.WriteLine("\n--------------------------------\n\n\n");
            // -------Завершение задания 2.



            // -------Начало задания 5.
            if (tempSumm > 0 && (monthNumber <= 2 || monthNumber == 12))
            {
                Console.Write("Дождливая выдалась зима...\n\n");
            }
            else if (tempSumm > 15 && (monthNumber <= 2 || monthNumber == 12))
            {
                Console.Write("Подозрительно тепло для средней полосы\n\n");
            }
            else if (tempSumm < -30 && (monthNumber <= 2 || monthNumber == 12))
            {
                Console.Write("Настолько холодно? Сочувствуем\n\n");
            }
            Console.WriteLine("\n--------------------------------\n\n\n");
            // -------Завершение задания 5.




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


          



        // Метод, проверяющий адекватность введенного номера месяца
        static int Checkmonth (int monthNumber)
        {
            do
            {
                Console.WriteLine("Извините, но введенное число не подходит. Введите число от 1 до 12.");
                string monthInput = Console.ReadLine();
                monthNumber = Integertest(monthInput);

            } while (monthNumber < 1 || monthNumber > 12);

            return monthNumber;
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
