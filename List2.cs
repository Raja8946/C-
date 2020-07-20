using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class List2
    {
        static void Main(string[] args)
        {
            List<int> Mylist = new List<int>();
            Mylist.Add(20);
             Mylist.Add(40);
              Mylist.Add(30);
               Mylist.Add(60);
                Mylist.Add(40);
               // Console.WriteLine(Mylist.Capacity);
             //  Mylist.Sort();
           //    Mylist.RemoveAt(3);
              // Mylist.Remove(40);
            //  Mylist.RemoveRange();
            // List<int> Mystring=new List<int>();
            // Mystring.Add(1300);
            // Mylist.AddRange(Mystring);

            Mylist.Insert(3,456);
               foreach (int item in Mylist)
               {
                   Console.WriteLine(item);
               }

        }
    }
}
