using System;

namespace userdecarray
{
 class userdecarray
 {
     static void Main(string[] args)
     {
         Console.Write("---User Define Array----");
         Console.WriteLine();
         Console.WriteLine("Enter the array size");
       int size = int.Parse(Console.ReadLine());
         int[] array = new int[size];
         for(int i=0;i<size;i++)
         {
             Console.WriteLine("Enter the data at location at " + (i+1));
             array[i] = int.Parse(Console.ReadLine());
             
         }
         Console.WriteLine("---User Array After Insertion Of Element is-------");
         foreach (int item in array)
         {
             Console.WriteLine(item);
         }
     }
 }   
}