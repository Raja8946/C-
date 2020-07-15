using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Example
    {
        public static void showarray <T>(T[] arr)     //<T> is a placeholder
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
       // public static bool check<A>(A a)
       public static void check<A>(A a)
        {
             Console.WriteLine(typeof(A));
            
            //bool c= a.Equals(b);
           // return c;
        



        } 
    }
    public class Generic_method
    {
        static void Main(string[]  args)
        {
        //     int[] number={5,6,7,8};
        //     string[] name={"Raj","Sonam","Golu"};
        //     char[] nam={'r','a','j'};
        //     Example.showarray(number);
        //     Example.showarray(name);
        //     Example.showarray(nam);
        //  Console.WriteLine(Example.check("Raj","JAR"));
        Example.check(20);
        }
    }
}
