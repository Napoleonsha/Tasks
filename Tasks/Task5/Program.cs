using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();    
                float firstNum, secondNum;

                Console.WriteLine("Введите первое число: ");
                bool firstNumValid = float.TryParse(Console.ReadLine(), out firstNum);

                if (!firstNumValid)
                {
                    Console.WriteLine("Число введено неверно");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите второе число: ");
                bool secondNumValid = float.TryParse(Console.ReadLine(), out secondNum);
                if (!secondNumValid)
                {
                    Console.WriteLine("Число введено неверно");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию для этих чисел");

                ConsoleKey consolekey = Console.ReadKey().Key;
                Console.WriteLine();

                switch (consolekey)
                {
                    case ConsoleKey.Divide:
                        if (secondNum == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine("Результат: " + firstNum / secondNum);
                        }
                        break;
                    case ConsoleKey.Add:
                        Console.WriteLine("Результат: " + (firstNum + secondNum));
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("Результат: " + (firstNum - secondNum));
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine("Результат: " + (firstNum * secondNum));
                        break;
                    default:
                        Console.WriteLine("Операция введена неверно");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
