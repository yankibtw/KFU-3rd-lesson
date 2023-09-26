using System;

namespace KFU_3rd_lesson
{
    internal class Program
    {
        enum GameCards
        {
            Шестерка = 6,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        }
        enum Days
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void NumbersLine()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Задание 1\nВведите 10 чисел:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                    i--; // Повтор ввода для текущего элемента
                }
            }

            int index = 0;
            bool flag = true;
            for (int i = 0; i < 10 - 1; i++)
            {
                if (numbers[i + 1] < numbers[i])
                {
                    index = i + 2;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("\nПоследовательность элементов упорядочена по возрастанию.\n");
            }
            else
            {
                Console.WriteLine($"\nЧисло последовательности, который прерывает упорядоченность последовательности: {index}\n");
            }

        }
        static void CardGame()
        {
            Console.WriteLine("Задание 2\nВведите номер игральной карты от 6 до 14");
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out byte inputNumber) || (inputNumber < 6 || inputNumber > 14))
                {
                    throw new ArgumentException("Номер карты должен быть от 6 до 14!!!\n");
                }
                else
                {
                    Console.WriteLine((GameCards)inputNumber);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void AlcoTags()
        {
            Console.WriteLine("Задание 3\nКем вы являетесь?");
            switch (Console.ReadLine().ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }
        }
        static void DayOfWeek()
        {
            Console.WriteLine("Задание 4.\nВведите номер дня недели чтобы узнать его название(1-7).");
            try
            {
                if (!sbyte.TryParse(Console.ReadLine(), out sbyte inputDay) || inputDay < 1 || inputDay > 7)
                {
                    throw new ArgumentException("Введен некорректный номер дня недели. Введите число от 1 до 7!!!\n");
                }
                else
                {
                    Console.WriteLine($"День недели соответствующий номеру {inputDay} это {(Days)inputDay}\n");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ImBarbieGirl()
        {
            Console.WriteLine("Задание 5");
            string[] dollsNames = { "Hello Kitty", "Grace", "Polly", "Barbie doll", "Hello Kitty", "Timmy", "LEGO", "Barbie doll", "Ken doll" };
            ushort qty = 0;
            foreach (string el in dollsNames)
            {
                if (el == "Barbie doll" || el == "Hello Kitty")
                {
                    qty++;
                }
            }
            Console.WriteLine($"В сумке лежит {qty} кукол.");
        }
        static void Main(string[] args)
        {      
            NumbersLine();
            CardGame();
            AlcoTags();
            DayOfWeek();
            ImBarbieGirl();
        }
    }
}
