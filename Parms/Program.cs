using System;

namespace Parms
{
    class Program
    {
        public static int Add(params int[] num)
        {
            int sum=0;
            foreach (int i in num)
            {
                sum=sum+i;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Add(10,20,30,40,50));
        }
    }
}
