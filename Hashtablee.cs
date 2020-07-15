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
            Console.WriteLine(ht["ID"]);
        }
    }
}
