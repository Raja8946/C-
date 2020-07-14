using System;
namespace sort
{
    class sort{
        static void Main(string[]  args)
        {
            int i,j,temp;
            Console.WriteLine("Enter array size");
            int size = int .Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(i=0;i<size;i++)
            {
                Console.WriteLine("Enter the data at location :{0}",(i+1));
                int data = int.Parse(Console.ReadLine());
                arr[i]=data;
            }

            Console.WriteLine("---Printing array---");
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            
            for(i=0;i<size;i++)
            {
                for(j=i+1;j<size;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp= arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }

            Console.WriteLine("--Acending Order---");
            
            foreach(int ite in arr)
            {
                Console.WriteLine(ite);
            }

for(i=0;i<size;i++)
{
    for(j=i+1;j<size;j++)
    {
        if(arr[i]<arr[j])
        {
            temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
    }
}
Console.WriteLine(" ---- Descending Order----");
foreach(int it in arr)
{
    Console.WriteLine(it);
}
        }
    }
}