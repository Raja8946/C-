using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Student
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public Student(string yname,int yage)
        {
            name=yname;
            age=yage;
        }

    }
    public class Prperty2
    {
        static void Main(string[] args)
        {
             Student s1 = new Student("Raj",20);
          //   s1.age=30;
             Console.WriteLine(s1.age);
        }
    }
    
}
