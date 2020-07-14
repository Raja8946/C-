using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Tutor
{
    public class Child : Parent
    {

        public Child()
        {
            Console.WriteLine("--chi");
        }
        static void Main(string[] args)
        {
            Object obj = new object();
            Parent p = new Parent();
            Child c = new Child();
        }
    }
}
