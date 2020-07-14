using System;
namespace methodover
{
    class Method_overloading
    {
        public void Add()
        {
            int a=10;
            int b=20;
            int c=a+b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c =a+b;
            Console.WriteLine(c);
        }
        public void Add(string a,string b)
        {
            string c= a+" "+b;
            Console.WriteLine(c);
        }
        public void Add(float a,float b)
        {
            float c=a+b;
            Console.WriteLine(c);
        }
        static void Main(string[]  args)
        {
           Method_overloading m = new Method_overloading();
           m.Add();
           m.Add(20,30);
           m.Add("Raj","Sonam");
           m.Add(2.15f,.85f);    
        }
    }
}