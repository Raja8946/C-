using  System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace access
{
   public class class1
   {
       public  void show1()
       {
           Console.WriteLine("----");
       }

    //    public void show1()
    //    {
    //        class1 c1 = new class1();
    //        c1.show();
    //    }
   
   } 
    class accessmodi1 : class1
    {
        static void Main(string[] args)
        {
           accessmodi1 c1 = new accessmodi1();
            c1.show1();
        }

    }
    
}

    
