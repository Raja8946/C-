using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    sealed class A
    {
        public void show()
        {
            Console.WriteLine("----A-----");
        }
    }

    class B : A
    {

    }
     
    public class Sealedclass
    {
        static void Main(string[] args)
        {
             B b= new B();
             b.show();//show error while class A is sealed
        }
    }
}
