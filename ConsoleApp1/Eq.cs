using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Eq
    {
        
        public Eq()
        {
            Console.WriteLine("Podaj a:");
            add_el();
            Console.WriteLine("Podaj b:");
            add_el();
            Console.WriteLine("Podaj c:");
            add_el();
        }
        public void formatuj_rnie()
        {
            if (tab[0] == 0 && tab[1] == 0 && tab[2] == 0)
            {
                Console.WriteLine("{0}*x*x*x*x + {1}*x*x + {2} = 0", tab[0], tab[1], tab[2]);
                Console.WriteLine("Rownanie tozsamosciowe");
                Environment.Exit(0);
            }
            if (tab[0] == 0 && tab[1] == 0 && tab[2] != 0)
            {
                Console.Write("Rownanie sprzeczne!\n");
                Environment.Exit(0);
            }
            if ((tab[0] == 0 && tab[1] != 0 && tab[2] == 0) || (tab[0] != 0 && tab[1] == 0 && tab[2] == 0))
            {
                Console.Write("Pierwiastek jest rowny 0\n");
                Environment.Exit(0);
            }
            if (tab[0] != 0)
            {
                Console.Write("{0}*x*x*x*x", tab[0]);
                if (tab[1] != 0 || tab[2] != 0)
                {
                    Console.Write("+");
                }
            }
            else
            {
                is_square = true;
            }
            if (tab[1] < 0)
            {
                Console.Write("({0})*x*x", tab[1]);
            }
            if (tab[1] > 0)
            {
                Console.Write("{0}*x*x", tab[1]);
            }
            if (tab[1] != 0 && tab[2] != 0)
            {
                Console.Write("+");
            }
            if (tab[2] < 0)
            {
                Console.Write("({0})", tab[2]);
            }
            if (tab[2] > 0)
            {
                Console.Write(tab[2]);
            }
            Console.Write("=0\n");
            return;
        }
        public void use_method()
        {
            Method method;
            if (is_square == false)
            {
                comp_delta();
            }
            method = Choose_method();
            method.pass_args(tab, delta);
            method.show_result();
            method.add_results();
            Console.Write("\n");
            method.show_opps();
        }


        private double delta=0;
        List<int> tab = new List<int>();
        bool is_square = false;
       private void comp_delta()
        {
            delta = tab[1] * tab[1] - 4 * tab[0] * tab[2];
            Console.Write("Delta wynosi: {0}\n", delta);
            return;
        }
        private void add_el()
        {
            string buff;
            int temp;
            buff = Console.ReadLine();
            temp = Convert.ToInt32(buff);
            tab.Add(temp);
        }
        private Method Choose_method()
        {
            Method method;
            if (is_square == true)
            {
                method = new Square();
                return method;
            }
            if (delta == 0)
            {
                method = new IsZero();
                return method;
            }
            if (delta > 0)
            {
                method = new MoreThanZero();
                return method;
            }
            if (delta < 0)
            {
                method = new Complex_n();
                return method;
            }
            return null;
        }
    }
}
