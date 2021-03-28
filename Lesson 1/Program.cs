using System;

namespace Lesson_1_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo en = new System.Globalization.CultureInfo("en-EN");
            System.Threading.Thread.CurrentThread.CurrentCulture = en;
            Console.WriteLine("Greetings, Stranger! What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}!. Today is {DateTime.Now.ToString("D")}");
            Console.ReadKey();
        }
    }
}
