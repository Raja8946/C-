using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{

    abstract class Person
    {
        public abstract uint ID{ get; set; }    // Abstract Property do not have its body same loke Abstract Method
        public abstract string Name { get; set; }
    }

    class Student : Person
    {
        private uint Studentid;
        private string Studentname;

       public override  uint ID         // We override or Implement body of Abstractact property in child class using override keyword
        {
            set
            {
                if(value==0)
                {
                    Console.WriteLine("Id is Invalid!!!");
                }
                else
                {
                   this.Studentid=value;
                }
            }
            


            get
            {
                 return this.Studentid;
            }
        }
        public override  string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter a valid name!!!");
                }
                else
                {
               this.Studentname=value;
                }
            }

            get
            {   
               return this.Studentname;
            }
        }
    }
    public class Abstract_property
    {
        static void Main(string[]  args)
        {
            Student s1 = new Student();
            s1.ID=0;
            s1.Name="";
            Console.WriteLine(s1.ID);
            Console.WriteLine(s1.Name);
        }
    }
}
