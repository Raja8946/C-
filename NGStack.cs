using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class NGStack
    {
        static void Main(string[] args)
        {
        Stack mystack=new Stack();
        mystack.Push(20);
        mystack.Push("Raj");
        mystack.Push(13000118043);
        mystack.Push("Student");
        
        Console.WriteLine(mystack.Count);
        // foreach (object item in mystack)
        // {
        //     Console.Write(item + " ");
      //  Console.WriteLine();

    //    Console.WriteLine(mystack.Peek());

        // while(mystack.Count>0)
        // {
        //     Console.WriteLine(mystack.Pop());
        // }
       // Console.WriteLine(mystack.Count);
        Console.WriteLine(mystack.Contains("Raj"));
    }

    }
}
