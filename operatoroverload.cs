using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getvolume()
        {
            return length*breadth*height;
        }

        
        public double setlen(double len)
        {
            length=len;
        }
        public double setbre(double bre)
        {
            breadth=bre;
        }
        public double sethei(double hei)
        {
            height=hei;
        }
    }
    
    public class operatoroverload
    {
        static void Main(string[] args)
        {
        Box Box1=new Box();
        Box Box2= new Box();

        Box Box3=new Box();
        double volume=0.0;
        // Setting up for first box
       Box1.setlen(5.0);
       Box1.setbre(5.0);
       Box1.sethei(5.0);
      Console.WriteLine( Box1.getvolume());
        }
    }
}
