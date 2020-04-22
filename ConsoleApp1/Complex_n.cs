using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApp1
{
    class Complex_n : Method
    {

        override public void pass_args(List<int> tab, double delta)
        {
            compute(tab, delta);
            return;
        }
        override public void add_results()
        {
            Console.Write("Czesc rzeczywista po dodaniu: ");
            Console.WriteLine(x[0].Real + x[1].Real + x[2].Real + x[3].Real);
            Console.Write("Czesc urojona po dodaniu: ");
            Console.WriteLine(x[0].Imaginary + x[1].Imaginary + x[2].Imaginary + x[3].Imaginary);
            return;
        }
        override public void show_result()
        {
            Console.Write("Pierwiastek pierwszy: {0} + ({1}i)\n", x[0].Real, x[0].Imaginary);
            Console.Write("Pierwiastek drugi: {0} + {1}i\n", x[1].Real, x[1].Imaginary);
            Console.Write("Pierwiastek trzeci: {0} + {1}fi\n", x[2].Real, x[2].Imaginary);
            Console.Write("Pierwiastek czwarty: {0} + ({1}i)\n", x[3].Real, x[3].Imaginary);
            return;
        }
        override public void show_opps()
        {
            for (int i = 0; i < x.Count; i++)
            {
                x[i]=Complex.Multiply(x[i], -1);
            }
            Console.Write("\nPrzeciwny pierwiastek pierwszy: {0} + {1}i)\n", x[0].Real, x[0].Imaginary);
            Console.Write("Przeciwny pierwiastek drugi: {0} + ({1}i)\n", x[1].Real, x[1].Imaginary);
            Console.Write("Przeciwny pierwiastek trzeci: {0} + ({1}i)\n", x[2].Real, x[2].Imaginary);
            Console.Write("Przeciwny pierwiastek czwarty: {0} + {1}i)\n", x[3].Real, x[3].Imaginary);
        }
        override protected void compute(List<int> tab, double delta)
        {
            Complex pdelta;
            Complex temp;
            pdelta = delta;
            pdelta = Complex.Sqrt(pdelta);
            temp = (-tab[1] * 1.0 - pdelta) / (2.0 * tab[0]);
            temp = Complex.Sqrt(temp);
            x.Add(temp);
            temp = -temp;
            x.Add(temp);
            temp = (-tab[1] * 1.0 + pdelta) / (2.0 * tab[0]);
            temp = Complex.Sqrt(temp);
            x.Add(temp);
            temp = -temp;
            x.Add(temp);
        }
        private List<Complex> x = new List<Complex>();
    };
}
