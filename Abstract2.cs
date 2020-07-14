using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    abstract class Person
    {
        public string fname;
        public string lname;
         
        public string _phoneno;
        public string phoneno {
             set
             {
                if(value.Length<=10)
                {
                    Console.WriteLine("Enter a valid number");
                }
                else
                {
                     this._phoneno=value;
                }
             }
              get
              {
                  return this._phoneno;
              } 
              }
        public int age;

        public abstract void Getdetails(); // Abstract method do not have body type like interface
        
    }
  class Student : Person
    {
        public int rollno;
        public int fees;
        public override void Getdetails()
        {
            
            string name = this.fname+" "+this.lname;
            Console.WriteLine("Student name is {0}",name);
             Console.WriteLine("Student age is {0}",this.age);
              Console.WriteLine("Student mob no  is {0}",this.phoneno);
               Console.WriteLine("Student rollno is {0}",this.rollno);
                Console.WriteLine("Student fees is {0}",this.fees);

        }
    }

    class Teacher : Person
    {
        public int Netpayment;
        public string Qualification;
        public override void Getdetails()
        {
            string name=this.fname+" "+this.lname;
            Console.WriteLine("Teacher name is :{0}",name);
            Console.WriteLine("Teacher age is {0}",this.age);
              Console.WriteLine("Teacher mob no  is {0}",this.phoneno);
               Console.WriteLine("Teacher Qualification is {0}",this.Qualification);
                Console.WriteLine("Teacher net payment is {0}",this.Netpayment);


        } 
    }
    public class Abstract2
    {
       static void Main(string[]  args)
       {

         //  Person p1= new Person();  //Cannot create an instance for abstract class
           Student s1 = new Student();
           s1.fname="Raj";
           s1.lname="Sonam";
           s1.phoneno="097980581882";
           s1.age=20;
           s1.rollno=234;
           s1.fees=3000;
           
           s1.Getdetails();
           //Console.WriteLine(s1.phoneno);
           Console.WriteLine("-------------------");
           Teacher t1=new Teacher();
           t1.fname="Rohit";
           t1.lname="Raj";
           t1.phoneno="09798058182";
           t1.Netpayment=50000;
           t1.Qualification="B.tech";
           t1.age=40;
           t1.Getdetails();
       } 
    }

}
