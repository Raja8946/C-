using System;
using cl2;

using System.Collections.Generic;


namespace Dictionary1

{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> mydict = new Dictionary<string, string>();
            mydict.Add("Active","Passive");
            mydict.Add("Add","Daa");
           // Console.WriteLine(mydict["Active"]);
           string value;
           mydict.TryGetValue("Active", out value);
           Console.WriteLine(value);
           foreach (var item in mydict)
           {
               Console.WriteLine("key is :" + item.Key  + " Value is:" +item.Value);
           }

         // Console.WriteLine("Hello World!");
        //    Class1 employee1=new Class1()
        //    {
        //        Id=42,
        //        Name="Raj",
        //        age=20,
        //        Salary=5000,
        //    };

        //    Class1 employee2=new Class1()
        //    {
        //        Id=44,
        //        Name="Sonam",
        //        age=21,
        //        Salary=30000,
        //    };
        //    Class1 employee3 = new Class1()
        //    {
        //        Id=45,
        //        Name="Raja",
        //        age=30,
        //        Salary=40000,

        //    };

        // Dictionary<int,Class1> mydict1 = new Dictionary<int, Class1>();
        // mydict1.Add(employee1.Id,employee1);
        // mydict1.Add(employee2.Id,employee2);
        // mydict1.Add(employee3.Id,employee3);
        // Console.WriteLine(mydict1.Count);
        
        }
    }
}
