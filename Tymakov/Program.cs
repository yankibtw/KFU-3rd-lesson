using System;


namespace Tymakov
{
    internal class Program
    {
        static bool ForSendData(ushort inputYear)
        {
            return ((inputYear % 4 == 0 && inputYear % 100 != 0) || inputYear % 400 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1 - 4.2 + Домашняя 4.1\nВведите год, а затем номер дня в году, чтобы узнать какому числу он соответсвует.");
            try
            {
                if (ushort.TryParse(Console.ReadLine(), out ushort inputYear) && (inputYear > 0))
                {
                    if (!ushort.TryParse(Console.ReadLine(), out ushort yearDay) || yearDay < 1 || (yearDay > 365 && !ForSendData(inputYear)) || (yearDay > 366 && ForSendData(inputYear)))
                    {
                        if (yearDay > 365 && !ForSendData(inputYear))
                        {
                            throw new ArgumentException("Некорректный ввод. Пожалуйста, введите целое число от 1 до 365.");
                        }
                        else
                        {
                            throw new ArgumentException("Некорректный ввод. Пожалуйста, введите целое число от 1 до 366.");
                        }
                    }
                    else
                    {
                        DateTime date = new DateTime(inputYear, 1, 1).AddDays(yearDay - 1);
                        Console.WriteLine($"Полученная дата: {date.Day} {date.ToString("MMMM")}.");
                    }
                }
                else
                {
                    throw new ArgumentException("Некорректный ввод. Пожалуйста, введите корректный год!");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
