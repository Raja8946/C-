

using System;

namespace prog
{
    class pri_cons
    {
        public static int a;
        private pri_cons()
        {

        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static int Increment()
        {
            return ++a;
        }
        
          static void Main(string[] args)
          {
              pri_cons.getTime();
              pri_cons.a=5;
              Console.WriteLine(pri_cons.Increment());
          }
        
        
            
        
    }
    
}