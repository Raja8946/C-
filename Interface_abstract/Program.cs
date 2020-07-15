using System;

namespace Interface_abstract
{
    public class Stud
    {
        public void show()
        {
            Console.WriteLine("Hello!!!");
        }
    }
    abstract class Stude : Stud
    {
        public Stude()
        {

        }

        ~Stude()
        {

        }

    }

    interface i1 : Stud
    {
        public i1()
        {

        }

        ~i1()
        {
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
