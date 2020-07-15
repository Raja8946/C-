using System;
using cl2;
namespace Operatoroverload
{
    class Program 
    {
    //   private double length;   // Length of a box
    //   private double breadth;  // Breadth of a box
    //    private double height;   // Height of a box

    //   public double getVolume() {
    //      return length * breadth * height;
    //   }
    //   public void setLength( double len ) {
    //      length = len;
    //   }
    //   public void setBreadth( double bre ) {
    //      breadth = bre;
    //   }
    //   public void setHeight( double hei ) {
    //      height = hei;
    //   }
        static void Main(string[] args)
        {

            // Class1 obj1=new Class1();
            // obj1.Num1=10;
            // obj1.Str1="Raj";
            // Class1 obj2=new Class1();
            // obj2.Num1=20;
            // obj2.Str1="Sonam";
            // Class1 obj3=new Class1();
            // obj3=obj1+obj2;
            // Console.WriteLine(obj3.Num1);
            // Console.WriteLine(obj3.Str1);
        //     Class1 obj = new Class1();
            Class1 obj1 = new Class1();   // Declare Box1 of type Box
            Class1 obj2 = new Class1();   // Declare Box2 of type Box
        //  Box Box3 = new Box();   // Declare Box3 of type Box
         double volume = 0.0;    // Store the volume of a box here

        //  // box 1 specification
         obj1.setLength(6.0);
         obj1.setBreadth(7.0);
         obj1.setHeight(5.0);

        //  // box 2 specification
         obj2.setLength(12.0);
          obj2.setBreadth(13.0);
          obj2.setHeight(10.0);

        //  // volume of box 1
         volume = obj1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);

        //  // volume of box 2
         volume = obj2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);

        //  // Add two object as follows:
        Class1 obj3=new Class1();
          obj3 = obj1 + obj2;

        //  // volume of box 3
          volume = obj3.getVolume();
          Console.WriteLine("Volume of Box3 : {0}", volume);
        //  Console.ReadKey();
        //  // box 1 specification
         obj1.setLength(8.0);
         obj1.setBreadth(7.0);
         obj1.setHeight(4.0);

        //  // box 2 specification
         obj2.setLength(12.0);
          obj2.setBreadth(13.0);
          obj2.setHeight(10.0);

        //  // volume of box 1
         volume = obj1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);

        //  // volume of box 2
         volume = obj2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);

        //  // Add two object as follows:
   //     Class1 obj3=new Class1();
          obj3 = obj1 + obj2;

        //  // volume of box 3
          volume = obj3.getVolume();
          Console.WriteLine("Volume of Box3 : {0}", volume);
        //  Console.ReadKey();
          //  // box 1 specification
         obj1.setLength(6.0);
         obj1.setBreadth(7.0);
         obj1.setHeight(5.0);

        //  // box 2 specification
         obj2.setLength(15.0);
          obj2.setBreadth(13.0);
          obj2.setHeight(10.0);

        //  // volume of box 1
         volume = obj1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);

        //  // volume of box 2
         volume = obj2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);

        //  // Add two object as follows:
       // Class1 obj3=new Class1();
          obj3 = obj1 + obj2;

        //  // volume of box 3
          volume = obj3.getVolume();
          Console.WriteLine("Volume of Box3 : {0}", volume);
        //  Console.ReadKey();
        //  // box 1 specification
         obj1.setLength(6.0);
         obj1.setBreadth(7.0);
         obj1.setHeight(5.0);

        //  // box 2 specification
         obj2.setLength(12.0);
          obj2.setBreadth(10.0);
          obj2.setHeight(12.0);

        //  // volume of box 1
         volume = obj1.getVolume();
         Console.WriteLine("Volume of Box1 : {0}", volume);

        //  // volume of box 2
         volume = obj2.getVolume();
         Console.WriteLine("Volume of Box2 : {0}", volume);

        //  // Add two object as follows:
       // Class1 obj3=new Class1();
          obj3 = obj1 + obj2;

        //  // volume of box 3
          volume = obj3.getVolume();
          Console.WriteLine("Volume of Box3 : {0}", volume);
        //  Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
