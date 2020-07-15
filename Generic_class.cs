using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Example<T>
    {
        public T box;

        public T Box 
        { 
            set
            {
                this.box=value;
            }
         
         
         get 
         {
             return this.box;
         }
        }
        // public Example(T box)
        // {
        //     this.box=box;
        // }
        // public T getvalue()
        // {
        //     return this.box;
        // }
    }
    public class Generic_class
    {
        static void Main(string[] args)
        {
            // Example <int> example=new Example<int>(20);
            // Example<string> example1=new Example<string>("Raj sonam");
            // Console.WriteLine(example1.getvalue());
            // Console.WriteLine(example.getvalue());

            Example<int> example=new Example<int>();
            example.box=20;
            Console.WriteLine(example.box);
             Example<string> example1=new Example<string>();
            example1.box="Raj";
            Console.WriteLine(example1.box);

        }
    }
}
