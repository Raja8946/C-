using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class NGQueue
    {
        static void Main(string[] args)
        {
            Queue myqueue = new Queue();
            myqueue.Enqueue(20);
            myqueue.Enqueue("Raj");
            myqueue.Enqueue("Sonam");
            myqueue.Enqueue(13000118043);
            Console.WriteLine(myqueue.Peek());
            Console.WriteLine(myqueue.Count);
            myqueue.Dequeue();
            // foreach (object item in myqueue )

            // {
            //       Console.WriteLine(item);    
            // }

            // Similar method and propery of stack can be use in queue.
        }
    }
}
