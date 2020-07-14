using System;
namespace encap
{
    class Student
    {
       private string name;
         private int age;

         public void setname(string name)
         {
             if(string.IsNullOrEmpty(name)==true)
             {
                 Console.WriteLine("Please enter a name");

             }
             else{
                 this.name=name;
             }
         }
         public void setage(int age)
         {
             if(age>0)
             {
                 this.age=age;
             }
             else
             {
                 Console.WriteLine("Age cannot be negative or zero");
             }

         }

         public void getname()
         {
              if(string.IsNullOrEmpty(name)==true)
             {
                // Console.WriteLine("Please enter a name");

             }
             else{
                 Console.WriteLine("Your name is :{0}",this.name);
             }
         }

         public void getage()
         {
              if(age>0)
             {
                 Console.WriteLine("Your age is :{0}",this.age);
             }
             else
             {
              //   Console.WriteLine("Age cannot be negative or zero");
             }

         }
    }

    class Encapsu
    {
        static void Main(string[] args)
        {
           Student s1=new Student();
           s1.setname("");
           s1.getname();
           

            

        }
    }
}