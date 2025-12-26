using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNum, secondNum, thirdNum, sum, proiz;

            Console.WriteLine("Введите первое число: ");
            bool firstNumValid = float.TryParse(Console.ReadLine(), out firstNum);

            Console.WriteLine("Введите второе число: ");
            bool secondNumValid = float.TryParse(Console.ReadLine(), out secondNum);

            Console.WriteLine("Введите третье число: ");
            bool thirdNumValid = float.TryParse(Console.ReadLine(), out thirdNum);

            if (firstNumValid && secondNumValid && thirdNumValid)
            {
                sum = firstNum + secondNum + thirdNum;
                proiz = firstNum * secondNum * thirdNum;
                Console.WriteLine("Сумма этих чисел: " + sum + " Произведение этих чисел: " + proiz);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
            }
        }
    }
}
