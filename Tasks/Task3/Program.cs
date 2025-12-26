using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub, dol, eur, uan,
                cursDol = 90,
                cursEur = 100,
                cursUan = 30;

            bool resConvert;
            Console.WriteLine("Введите сколько рублей хотите обменять: ");
            resConvert = float.TryParse(Console.ReadLine(), out rub);
            if (resConvert)
            {
                dol = rub / cursDol;
                eur = rub / cursEur;
                uan = rub / cursUan;
                Console.WriteLine("Обменяв " + rub + " рублей вы получите: " + dol + " долларов или " + eur + " евро или " + " юаней");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
        }
    }
}
