using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число: ");
            bool resConvert = int.TryParse(Console.ReadLine(), out number);
            if (resConvert)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Ваше число четное");
                }
                else
                {
                    Console.WriteLine("Ваше число нечетное");
                }
            }
            else
            {
                Console.WriteLine("Число введено неверно");
            }
        }
    }
}
