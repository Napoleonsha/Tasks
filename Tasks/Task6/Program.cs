using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber,
                endNumber,
                even = 0,
                odd = 0,
                evenSum = 0,
                oddSum = 0;
            Console.WriteLine("Введите начало диапазона: ");
            bool resConvertStart = int.TryParse(Console.ReadLine(), out startNumber);
            Console.WriteLine("Введите конец число диапазона: ");
            bool resConvertEnd = int.TryParse(Console.ReadLine(), out endNumber);
            if (((resConvertStart || resConvertEnd) == false) || startNumber > endNumber)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            else
            {
               while (startNumber < endNumber)
                {
                    startNumber++;
                    if (startNumber % 2 == 0) 
                    {
                        even++;
                        evenSum += startNumber;
                    } 
                    else
                    {
                        odd++;
                        oddSum += startNumber;
                    }
                }
                Console.WriteLine("В заданном диапазоне {0} четных чисел и {1} нечетных чисел, сумма четных чисел {2}, сумма нечетных чисел {3}", even,odd,evenSum, oddSum);
            }
        }
    }
}
