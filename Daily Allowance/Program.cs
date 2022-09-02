using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Allowance
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new();

            superClass.Fill();

            superClass.CountDays();

            superClass.Print();

            Console.ReadKey();

            Console.WriteLine("Керя пидор");

            Console.ReadKey();
        }
    }
}
