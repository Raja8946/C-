using System;
namespace methodhide
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("-----Parent----");
        }
        class Child : Parent
        {
            public new void show()
            {
              //  use for hiding method to view base.show();
               // Console.WriteLine("----Child----");
            }
        }
    
    class Methodhiding
    {
        static void Main(string[] args)
        {
          Child c = new Child();
         //((Parent)c).show();

        // Parent = new Child();
        }
    }
}

}