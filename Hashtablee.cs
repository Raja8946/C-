using System;
using System.Collections;


namespace Default
{
    public class Hashtablee
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ID",2344);
            ht.Add("NAME","RAJ");
            ht.Add("SALARY",300000);
            ht.Add("DESIGNATION","MANAGER");
         //   Console.WriteLine(ht["ID"]);

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
