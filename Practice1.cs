using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Employee
    {
        public string name;
     //   public int age;

        public void show()
        {
            Console.WriteLine("Employee name is :Raj Sonam");
            Console.WriteLine("Employee age is : 20");
        }


    }

    class Permanentemployee : Employee
    {
        
        public new void show()
        {
             Console.WriteLine(name+" "+"PTR");
        }
    }
    public class Practice1
    {
        static void Main(string[]  args)
        {
            Permanentemployee p=new Permanentemployee();
            p.name="Raj  Sonam";
            p.show();
        }
    }
}
