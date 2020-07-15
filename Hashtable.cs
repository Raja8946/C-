using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Hashtable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ID",2344);
            ht.Add("NAME","RAJ");
            ht.Add("SALARY",300000);
            ht.Add("DESIGNATION","MANAGER");
            Console.WriteLine(ht[id]);
        }
    }
}
