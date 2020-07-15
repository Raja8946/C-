using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Collection
    {
        static void Main(string[] args)
        {
          ArrayList Myarr = new ArrayList(2); // ArrayList is non Generic collection
          Myarr.Add(10);                      // Add() used to add elemnt
          Console.WriteLine(Myarr.Capacity);   // Capacity is used to get collection stores capacity
          Myarr.Add(20);
          Myarr.Add(30);
          Myarr.Add(40);
          Console.WriteLine(Myarr.Capacity);
          Myarr.Add(50);
          Console.WriteLine(Myarr.Capacity);
          foreach(object obj in Myarr)
          {
              Console.Write(obj+" ");
          }
          Console.WriteLine();
        Myarr.Insert(3,"Raj");                // Used to insert in b/w array and can add any of the datatype
         foreach(object obj in Myarr)
          {
              Console.Write(obj+" ");
          }
          Console.WriteLine();
          //Myarr.Remove(20);     // Use to delete an element
          Myarr.RemoveAt(3);      // use to delete an index
           foreach(object obj in Myarr)
          {
              Console.Write(obj+" ");
          }
          Console.WriteLine();


            // int[] array = new int[3];
            // array[0]=20;
            // array[1]=30;
            // array[2]=40;
            // Array.Resize(ref array,4);   // Use to resize array(Dynamic size)
            // array[3]=50;
        }
    }
}
