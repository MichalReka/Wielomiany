using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class MoreThanZero : Method
    {

        override public void pass_args(List<int> tab, double delta)
        {
            compute(tab, delta);
            return;
        }
        override public void add_results()
        {
            Console.Write("Czesc rzeczywista po dodaniu: ");
            Console.WriteLine(x1.Real + x2.Real + x3.Real + x4.Real);
            Console.Write("Czesc urojona po dodaniu: ");
            Console.WriteLine(x1.Imaginary + x2.Imaginary + x3.Imaginary + x4.Imaginary);
            return;
        }
        override public void show_result()
        {
            if (x1.Imaginary != 0)
            {
                Console.Write("Pierwiastek pierwszy: {0}*i\n", x1.Imaginary);
                Console.Write("Pierwiastek drugi: {0}*i\n", x2.Imaginary);
            }
            else
            {
                Console.Write("Pierwiastek pierwszy: {0}\n", x1.Real);
                Console.Write("Pierwiastek drugi: {0}\n", x2.Real);
            }
            if (x3.Imaginary != 0)
            {
                Console.Write("Pierwiastek trzeci: {0}*i\n", x3.Imaginary);
                Console.Write("Pierwiastek czwarty: {0}*i\n", x4.Imaginary);
            }
            else
            {
                Console.Write("Pierwiastek trzeci: {0}\n", x3.Real);
                Console.Write("Pierwiastek czwarty: {0}\n", x4.Real);
            }
        }
        override public void show_opps()
        {
            x1 = x1 * +(-1);
            x2 = x2 * (-1);
            x3 = x3 * +(-1);
            x4 = x4 * (-1);
            if (x1.Imaginary != 0)
            {
                Console.Write("Przeciwny pierwiastek pierwszy: {0}*i\n", x1.Imaginary);
                Console.Write("Przeciwny pierwiastek drugi: {0}*i\n", x2.Imaginary);
            }
            else
            {
                Console.Write("Przeciwny pierwiastek pierwszy: {0}\n", x1.Real);
                Console.Write("Przeciwny pierwiastek drugi: {0}\n", x2.Real);
            }
            if (x3.Imaginary != 0)
            {
                Console.Write("Przeciwny pierwiastek trzeci: {0}*i\n", x3.Imaginary);
                Console.Write("Przeciwny pierwiastek czwarty: {0}*i\n", x4.Imaginary);
            }
            else
            {
                Console.Write("Przeciwny pierwiastek trzeci: {0}\n", x3.Real);
                Console.Write("Przeciwny pierwiastek czwarty: {0}\n",  x4.Real);
            }
        }
        override protected void compute(List<int> tab, double delta)
        {
            double pdelta = Math.Sqrt(delta);
            x1 = (-tab[1] * 1.0 - pdelta) / (2.0 * tab[0]);
            x3 = (-tab[1] * 1.0 + pdelta) / (2.0 * tab[0]);
            x1 = Complex.Sqrt(x1);
            x2 = -x1;
            x3 = Complex.Sqrt(x3);
            x4 = -x3;
        }
        private Complex x1, x2, x3, x4;
    };
}
