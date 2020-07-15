using System;
using System.Collections;
namespace Hashtab
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           Hashtable ht = new Hashtable();
            ht.Add("ID",2344);
            ht.Add("NAME","RAJ");
            ht.Add("SALARY",300000);
            ht.Add("DESIGNATION","MANAGER");
            Console.WriteLine(ht["ID"]);
            Console.WriteLine(ht["NAME"]);
        
        }
    }
}
