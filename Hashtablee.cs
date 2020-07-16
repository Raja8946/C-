using System;
using System.Collections;


namespace Default
{
    public class Hashtablee
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {"Id",2456},
                {"Name","Sonam"},        // Declaration of hashtable
                {"Salary",40000}
            };
            ht.Add("ID",2344);    // Declaration of hashtable
            ht.Add("NAME","RAJ");
            ht.Add("SALARY",300000);
            ht.Add("DESIGNATION","MANAGER");
           Console.WriteLine(ht["ID"]);
           Console.WriteLine(ht["Id"]);

            // foreach (object key in ht.Keys)
            // {
            //     Console.WriteLine(key+" :"+ ht[key]);
            // }
           // ht.Remove("SALARY");
        //    ht.Clear();
        //     Console.WriteLine("--------------");
        //      foreach (object key in ht.Keys)
        //     {
        //         Console.WriteLine(key+" :"+ ht[key]);
        //     }

        Console.WriteLine(ht.Contains("ID"));
        Console.WriteLine(ht.ContainsKey("ID"));
        Console.WriteLine(ht.ContainsValue("KITE"));
        Console.WriteLine(ht.Count);
        Console.WriteLine("NAMe".GetHashCode());
        }
    }
}
