using System;
using System.Text;

namespace Lesson_2
{
    class task4
    {
      
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            System.Console.InputEncoding = Encoding.GetEncoding(1251);

           
            // -------Начало задания 4.

            Console.WriteLine("Укажите название магазина");
            string ShopName = Console.ReadLine();

            Console.WriteLine("Как звали вашего кассира?");
            string Cashier = Console.ReadLine();

            Console.WriteLine("Сколько видов товаров вы купили?");

            string GoodsImport = Console.ReadLine();
            int GoodsCount = Integertest(GoodsImport);
            string[] GoodsProperties = { "Название товара", "Цена за штуку", "Количество", "Единицы измерения", "Всего" };
            string[,] AllGoods = new string[GoodsCount, GoodsProperties.Length];

            for (int q = 0; q < GoodsCount; q++)
            {

                for (int n = 0; n < GoodsProperties.Length - 1; n++)
                {

                    if (n == 1 || n == 2)
                    {
                        Console.Write(q + 1 + " товар. Введите " + GoodsProperties[n] + "\n");
                        AllGoods[q, n] = Console.ReadLine();


                        if (int.TryParse(AllGoods[q, n], out int result) == false)
                        {
                            int sn = Integertest(AllGoods[q, n]);
                            AllGoods[q, n] = sn.ToString();
                        }

                    }

                    else
                    {
                        Console.Write(q + 1 + " товар. Введите " + GoodsProperties[n] + "\n");
                        AllGoods[q, n] = Console.ReadLine();
                    }

                }
                Console.Write("--------------------------------\n");
                int TempPiecePrice = int.Parse(AllGoods[q, 1]);
                int TempCount = int.Parse(AllGoods[q, 2]);
                int TempValue = TempPiecePrice * TempCount;

                AllGoods[q, GoodsProperties.Length - 1] = TempValue.ToString();

            }

            int TotalPrice = 0;

            for (int r = 0; r <= GoodsCount - 1; r++)
            {
                int tempint = int.Parse(AllGoods[r, GoodsProperties.Length - 1]);
                TotalPrice += tempint;

            }


            Console.Write("\n\n--------------------------------\n--------------------------------\n");
            Console.WriteLine("Кассовый чек");
            Console.Write("--------------------------------\n\n");

            foreach (string Element in GoodsProperties)
            {
                Console.Write(Element + "   |   ");
            }


            Console.Write("\n");

            for (int r = 0; r < GoodsCount; r++)
            {

                for (int c = 0; c < GoodsProperties.Length; c++)
                {
                    Console.Write(AllGoods[r, c] + " | ");
                }

                Console.Write("\n");

            }
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("Магазин: " + ShopName);
            Console.WriteLine("Кассир: " + Cashier);
            Console.WriteLine("ИТОГО: " + TotalPrice);

            Console.WriteLine("\n--------------------------------\n\n\n");

            // -------Завершение задания 4.

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
