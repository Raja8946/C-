// Delegates ,Multiple Delegates

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public delegate void Calculation(int a,int b);
    public delegate void Show();
    public delegate void Calculation2(int a);

    public class Delegates
    {
        public static void Square(int a)
        {
            int result = a*a;
            Console.WriteLine("Square of {0} is {1}",a,result);
        }
         public static void Cube(int a)
        {
            int result = a*a*a;
            Console.WriteLine("Cube of {0} is {1}",a,result);
        }

        public static void show()
        {
            Console.WriteLine("This is show method");
        }
        public static void Add(int a ,int b)
        {
          int result = a+b;
          Console.WriteLine("addition of {0} and {1} is {2} ",a,b,result);
        }
        public static void Subtract(int a ,int b)
        {
          int result = a-b;
          Console.WriteLine("Subtraction result is :{0}",result);
        }
         public static void Multiply(int a ,int b)
        {
          int result = a*b;
          Console.WriteLine("Multiplication result is :{0}",result);
        }
        public static void Divide(int a ,int b)
        {
          int result = a/b;
          Console.WriteLine("Divison result is :{0}",result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Delegates.Add);
          
             
           // obj(20,30);
            obj+=Subtract;
          //  obj(30,20);        // Multi Cast Delegates
            obj+=Multiply;
            //obj.Invoke(10,5);
            obj-=Divide;
            
            obj(50,10);

            // Show obj1 = new Show(show);  // Single cast Delegates
            // obj1();
            // Calculation2 obj2=new Calculation2(Square);
            // obj2(5);
            // obj2=Cube;
            // obj2(4);
        }
    }
}
