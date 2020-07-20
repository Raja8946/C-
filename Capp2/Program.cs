using System;
using cl2;
using System.Collections.Generic;

namespace Capp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           Class1 employee1=new Class1()
           {
               Name="Raj",
               age=20,
           };

           Class1 employee2=new Class1()
           {
               Name="Sonam",
               age=21,
           };
           List<Class1> Mylist=new List<Class1>();
           Mylist.Add(employee1);
           Mylist.Add(employee2);
        //    foreach(Class1 emp in Mylist)
        //    {
        //        Console.WriteLine("Employee name is:{0} and Employee age is :{1}",emp.Name,emp.age);
        //    }
                  //  Mylist.RemoveAll(emp => emp.age>20);
                   Console.WriteLine(Mylist.Exists(emp => emp.Name.StartsWith("A")));
           
                    foreach(Class1 emp in Mylist)
           {
               Console.WriteLine("Employee name is:{0} and Employee age is :{1}",emp.Name,emp.age);
           }
          
          // Console.WriteLine(employee.age);
           
        }
    }
}
