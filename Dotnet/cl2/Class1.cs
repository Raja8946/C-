using System;

namespace cl2
{
    public class Class1
    {
      //  public double length=0;
        //public double breadth=0;
        //public double height=0;
       // public int Num1=0;
        //public string Str1="";
        private double length;   // Length of a box
      private double breadth;  // Breadth of a box
       private double height;   // Height of a box

      public double getVolume() {
         return length * breadth * height;
      }
      public void setLength( double len ) {
         length = len;
      }
      public void setBreadth( double bre ) {
         breadth = bre;
      }
      public void setHeight( double hei ) {
         height = hei;
      }
        public static Class1 operator +(Class1 obj1, Class1 obj2) {
         Class1 obj3 = new Class1();
          obj3.length = obj1.length + obj2.length;
          obj3.breadth = obj1.breadth + obj2.breadth;
          obj3.height = obj1.height + obj2.height;
          return obj3;
      //  obj3.Num1=obj1.Num1+obj2.Num1;
        //obj3.Str1=obj1.Str1+obj2.Str1;
        //return obj3;

    }
}
}
