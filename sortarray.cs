using  System;

namespace sortarray 
{
   class sortarray
   {
       static void Main(string[] args)
       {
        
          Console.WriteLine("Enter array size ");
        int size = int.Parse(Console.ReadLine());
           int[] array = new int[size];
           int i;
           Console.WriteLine("------Enter elements into array-----");
           for(i=0;i<size;i++)
           {
               Console.WriteLine("Enter element at location " +(i+1) );
               array[i]=int.Parse(Console.ReadLine());
           }
           Console.WriteLine("---Array Before Insertion");
           foreach (int item in array)
           {
               Console.WriteLine(item);
           }
           Array.Sort(array);
           Console.WriteLine("----Array after sorted----");
           foreach(int iitem in array)
           {
               Console.WriteLine(iitem);
           }
       }
   } 
}

    
