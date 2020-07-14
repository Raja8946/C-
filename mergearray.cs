using System;

namespace merge
{
    class mergearray
    {
        static void Main(string[]  args)
        {
            int i;
            Console.WriteLine("Enter first array size");
            int size1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array2 size");
            int size2=int.Parse(Console.ReadLine());
            int[] array=new int[size1];
            int[] array2=new int[size2];
            int[] arr3=new int[size1+size2];
            for(i=0;i<size1;i++)
            {
                int data1=int.Parse(Console.ReadLine());
                array[i]=data1;

            }

            for(i=0;i<size2;i++)
            {
                int data2=int.Parse(Console.ReadLine());
                array2[i]=data2;
            }
        
        for(i=0;i<size1;i++)
        {
         arr3[i]=array[i];   
        }
        for(i=0;i<size2;i++)
        {
            for(int j=size1;j<size1+size2;j++)
            {
                arr3[j]=array2[i];
            }
        }

        foreach(int item in arr3)
        {
            Console.WriteLine(item);
        }
        }

    }
}