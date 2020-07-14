using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default 
{

    interface i1
    {
        void show();
    }
    interface i2
    {
        void show();
    }

    class Myclass : i1,i2
    {
        // void i1.show()
        // {
        //     Console.WriteLine(" Calling Out first interface");
        // }

        // We can use to implicit call to give a body for one interface

        public void show()
        {
            Console.WriteLine("Calling 1 interface");
        }
        void i2.show()
        {
            Console.WriteLine("Calling out 2 interface");
        }
    }
    public class Explicit_Interface
    {
        static void Main(string[] args)
        {
            //   Myclass obj = new Myclass();          
            //   ((i1)obj).show();
            //   ((i2)obj).show();

            // Both the can be used to explicit call of interface  
           // i1 obj=new Myclass();
            //i2 obj1=new Myclass();
            //obj.show();
            //obj1.show();

            // Another method

            Myclass obj=new Myclass();
            obj.show();
            ((i2)obj).show();
        }
    }
}
