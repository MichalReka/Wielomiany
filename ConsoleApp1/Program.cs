using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Eq equation = new Eq();
            equation.formatuj_rnie();
            equation.use_method();
            Console.WriteLine("Wprowadz dowolny klawisz aby zakonczyc...");
            Console.ReadKey();
        }
    }
}
