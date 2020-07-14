using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Class1
    {
         public int Empid;
        public string Empname;
        public double Grosssalary;
        public double taxdeduction=0.1;
        public double Netsalary;
        
        public Class1(int Eid,string Ename,double Gross)
        {
            this.Empid=Eid;
            this.Empname=Ename;
            this.Grosssalary=Gross;
            
        }
        void Calculation()
        {
            if(Grosssalary>=40000)
            {
                Netsalary= Grosssalary-(Grosssalary*taxdeduction);
                Console.WriteLine(" Netsalary of the employee is :{0}",Netsalary);
            }
            else
            {
                Console.WriteLine("Netsalay of the employee is :{0}",Grosssalary);
            }

        }
        public void Empdetails()
        {
            Console.WriteLine("Employye Id is :{0}",this.Empid);
            Console.WriteLine("Employee name is :{0}",this.Empname);
            this.Calculation();
        }
    }
    public class Abstract1
    {
     static void Main(string[]  args) 
     {
            Class1 obj = new Class1(20,"Raj",40000);
            obj.Empdetails();
     } 
    }
}
