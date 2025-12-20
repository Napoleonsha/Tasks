using System;

namespace Lessons
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber, result;

            Console.WriteLine("Введите первое число");
            bool firstNumValid = float.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Введите второе число");
            bool secondNumValid = float.TryParse(Console.ReadLine(), out secondNumber b);

            if (firstNumValid && secondNumValid) {
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
