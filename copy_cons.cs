using  System;

namespace copy
{
    class copy_cons 
    {
        string name;
        int age;

        public copy_cons(string name, int age)
        {
            this.name=name;
            this.age=age;
        }
          public copy_cons(copy_cons a)
          {
              this.name=a.name;
              this.age=a.age;
          }
        static void Main(string[]  args)
        {
            copy_cons p1=new copy_cons("Raj",12);
            Console.WriteLine("Your name is:{0}",p1.name);
            Console.WriteLine("Your age is:{0}",p1.age);
            copy_cons p2= new copy_cons(p1);
            Console.WriteLine("Your name is:{0}",p2.name);
            Console.WriteLine("Your age is:{0}",p2.age);
            

        }
    }
}
