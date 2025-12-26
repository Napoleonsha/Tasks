using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber, result;

            Console.WriteLine("Введите первое число");
            bool firstNumValid = float.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Введите второе число");
            bool secondNumValid = float.TryParse(Console.ReadLine(), out secondNumber);

            if (firstNumValid && secondNumValid)
            {
                result = (firstNumber + secondNumber) / 2;
                Console.WriteLine("Среднее арифметическое ваших чисел: " + result);
            }
            else
            {
                Console.WriteLine("Введена неправильная информация");
            }
        }
    }
}
