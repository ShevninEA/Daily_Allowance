using System;

namespace Daily_Allowance
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new();

            Found:

            try
            {
                SuperClass.ValuesSumm();

                superClass.Info();

                superClass.CountDays();

                superClass.PrintRight();


            }
            catch (Exception)
            {
                superClass.PrintExp();

                Console.Clear();

                goto Found;
            }

            Console.WriteLine("\nЕще раз? (Да-Y / Нет-N)");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();

                goto Found;
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
