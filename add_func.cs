using System;

namespace add_func
{
    class add_func
    {
        public static void Add(int a, int b)
        {
            int result = a+b;
            Console.WriteLine("Addition result is : {0}",result);
        }
        static void Main(string[] args)
        {
         //  add_func.Add(10,20);
           Console.WriteLine("Enter first number");
           int x = int.Parse(Console.ReadLine());
          Console .WriteLine("Enter second number");
           int  y = int.Parse(Console.ReadLine());
           add_func.Add(x,y);
        }
    }
}



    
