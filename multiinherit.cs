using  System;

namespace  multi
{
   class Person
   {
       public void show()
       {
           Console.WriteLine("This is method from person");
       }
   }

   interface Employee
   {
       void show();
   }

   interface Employee2
   {
       void show();
   }
   class Teacher : Person, Employee,Employee2
   {
        void Employee.show()
       {
           Console.WriteLine("this for employee method");
       }

       void Employee2.show()
       {
           Console.WriteLine("This is for employee 2 method");
       }
   }

    class multiinherit
    {
        static void Main(string[]  args)
        {
              Employee e1 = new Teacher();
              e1.show();
              Employee2 e2 = new Teacher();
              e2.show();
        }
    }

}    
