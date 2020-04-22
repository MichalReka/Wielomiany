using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Method
    {
        public Method()
        {

        }
        ~Method()
        {

        }
        public abstract void pass_args(List<int> tab, double delta);
        public abstract void add_results();
        public abstract void show_result();
        public abstract void show_opps();
        protected abstract void compute(List<int> tab, double delta);

    };
}
