using System;

namespace Daily_Allowance
{
    class SuperClass : ClassDate
    {
        /// <summary>
        /// Ввод данных о ежедневной сумме
        /// </summary>
        public static void ValuesSumm()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nВведите сумму дневной нормы");

            Console.ResetColor();

            int result = int.Parse(Console.ReadLine());

            summ = result;
        }

        /// <summary>
        /// Ввод дат отъезда и приезда
        /// </summary>
        public void Info() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nВведите дату отъезда в формате 01.01.2000");

            Console.ResetColor();

            DateStart = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nВведите дату приезда в формате 01.01.2000");

            Console.ResetColor();

            DateEnd = Console.ReadLine();

            Console.ResetColor();
        }

        /// <summary>
        /// Подсчет количесва дней
        /// </summary>
        public double CountDays()
        {
            DateTime start = DateTime.Parse(DateStart);

            DateTime end = DateTime.Parse(DateEnd);

            double result = (end - start).TotalDays;

            return result;
        }

        /// <summary>
        /// Вывод на экран в случае верной работы программы
        /// </summary>
        public void PrintRight()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            CenterX = (Console.WindowWidth / 2) - ($"Сумма ваших суточных составляет {(CountDays() + 1) * summ} рублей".Length / 2);

            CenterY = (Console.WindowHeight / 2) - 1;

            Console.SetCursorPosition(CenterX, CenterY);

            Console.Write($"Сумма ваших суточных составляет {(CountDays() + 1) * summ} рублей");

            Console.ResetColor();
        }

        /// <summary>
        /// Вывод на экран в случае ошибки работы программы
        /// </summary>
        public void PrintExp()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            CenterX = (Console.WindowWidth / 2) - ("Вы ввели некорректные данные".Length / 2);

            CenterY = (Console.WindowHeight / 2) - 1;

            Console.SetCursorPosition(CenterX, CenterY);

            Console.Write("Вы ввели некорректные данные");

            Console.ReadLine();
        }
    }
}
