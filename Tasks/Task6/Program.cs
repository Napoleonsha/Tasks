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
            int number, 
                count = 0,
                even = 0,
                odd = 0;
            Console.WriteLine("Введите диапазон: ");
            bool resConvert = int.TryParse(Console.ReadLine(), out number);
            if (!resConvert)
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            else
            {
               while (count < number)
                {
                    count++;
                    if (count % 2 == 0) 
                    {
                        even++;
                    } 
                    else
                    {
                        odd++;
                    }
                }
                Console.WriteLine("В заданном диапазоне {0} четных чисел и {1} нечетных чисел", even,odd);
            }
        }
    }
}
