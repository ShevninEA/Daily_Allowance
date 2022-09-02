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

            Console.ReadLine();
        }
    }
}
