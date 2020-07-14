using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is parent method ");
        }
    }

    class child : parent
    {
        public override void print()
        {
            Console.WriteLine("This is child class method");
        }
    }
    public class Method_overriding
    {
        static void Main(string[] args)
        {
             parent p = new child();
             p.print();
        }
    }
}
