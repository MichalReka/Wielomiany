using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class IsZero : Method
    {

        override public void pass_args(List<int> tab, double delta)
        {
            tab.RemoveAt(0);
            compute(tab, delta);
            return;
        }
        override public void add_results()
        {
            Console.Write("Czesc rzeczywista po dodaniu: ");
            Console.WriteLine(x1.Real + x2.Real);
            Console.Write("Czesc urojona po dodaniu: ");
            Console.WriteLine(x1.Imaginary + x2.Imaginary);
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
        }
        override public void show_opps()
        {
            x1 = x1 * +(-1);
            x2 = x2 * (-1);
            if (x1.Imaginary != 0)
            {
                Console.Write("Przeciwny pierwiastek pierwszy: {0}*i\n",  x1.Imaginary);
                Console.Write("Przeciwny pierwiastek drugi: {0}*i\n",  x2.Imaginary);
            }
            else
            {
                Console.Write("Przeciwny pierwiastek pierwszy: {0}\n",  x1.Real);
                Console.Write("Przeciwny pierwiastek drugi: {0}\n",  x2.Real);
            }
        }
        override protected void compute(List<int> tab, double delta)
        {
            x1 = (-tab[1] * 1.0) / (2.0 * tab[0]);
            x1 = Complex.Sqrt(x1);
            x2 = -x1;
            return;
        }
        private Complex x1, x2;
    };
}
