using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace inherit1
{
    

  class Permanentemployee : Employee
    {
       // public int Permanentempsal;
       // public int Permanentemphrs;
    }

   class Visitingemployee : Employee
    {
     //   public int Visitingempsal;
       // public int Visitingemplhrs;
    }
    class Employee
    {
        public string empname;
        public int empid;
        //public int empage;
        //public int empcontact;
    

    class Inherit1
    {
        static void Main(string[] args)
        {
            Permanentemployee p1 = new Permanentemployee();
            p1.empname=Console.ReadLine();
            p1.empid=int.Parse(Console.ReadLine());
            Console.WriteLine("Emp id is:{0} ",p1.empid);
             Console.WriteLine("employee name is:{0}",p1.empname);
             Derived3 d3 =new Derived3();
             
        }

    }
    
    }

    
}    
