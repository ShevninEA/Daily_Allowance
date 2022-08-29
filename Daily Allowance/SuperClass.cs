using System;

namespace Daily_Allowance
{
    class SuperClass : ClassDate
    {
        /// <summary>
        /// Ввод дат отъезда и приезда
        /// </summary>
        public void Fill() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите дату отъезда в формате 01.01.2000");

            Console.ResetColor();

            DateStart = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите дату приезда в формате 01.01.2000");

            Console.ResetColor();

            DateEnd = Console.ReadLine();
        }

        /// <summary>
        /// Подсчет количесва дней
        /// </summary>
        public double CountDays()
        {
            try
            {
                DateTime start = DateTime.Parse(DateStart);

                DateTime end = DateTime.Parse(DateEnd);

                double result = (end - start).TotalDays;

                return result;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                int centerX = (Console.WindowWidth / 2) - ("Вы ввели несуществующую дату".Length / 2);
                int centerY = (Console.WindowHeight / 2) - 1;
                Console.SetCursorPosition(centerX, centerY);
                Console.Write("Вы ввели несуществующую дату");

                Console.ReadLine();

                throw;
            }
        }

        /// <summary>
        /// Вывод на экран
        /// </summary>
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int centerX = (Console.WindowWidth / 2) - ($"Сумма ваших суточных составляет {(CountDays() + 1) * summ} рублей".Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write($"Сумма ваших суточных составляет {(CountDays() + 1) * summ} рублей");

        }
    }
}
