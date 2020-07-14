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
    // class i2 : i1
    // {
    //     public void show()
    //     {
    //         Console.WriteLine("This is a interface call");
    //     }
    // }

interface i2
{
    void show1();
}
interface i3 :i1,i2
{
    void show2();          // This is how we declare multiple interface
}
    public class Interface :i3
    {
       public void show()
       {
           Console.WriteLine("This is first interface");

       }
       public void show1()
       {
           Console.WriteLine("This is second interface");

       }

       public void show2()
       {
           Console.WriteLine("This is third interface");
       }
        static void Main(string[]  args)
        {
            // i2 obj= new i2();   // Single Interface
            // obj.show();

         // Interface i = new Interface();
          i3 i=new Interface(); // Creating refrence of i3 while creating object of Interface class
          i.show();   
          i.show1();              // Interface Inheritance chain or Multi Inheritance in Interface
          i.show2();
        }
    }
}
