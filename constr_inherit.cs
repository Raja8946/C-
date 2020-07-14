using System;

namespace  cons
{
   class Baseclass
   {
       public Baseclass(string message)
       {
           Console.WriteLine(message);
       }
   }

   class Derivedclass : Baseclass
   {
       public Derivedclass() : base("Welcome to c sharp")
       {
           Console.WriteLine("This is derived class constructor");
    
       }
       public void show()
       {
           Console.WriteLine("--------");
       }
   }
   
       
   

    class constr_inherit
    {
        static void Main(string[]  args)
        {
            Derivedclass d1 = new Derivedclass();
            d1.show();

        }
    }
}