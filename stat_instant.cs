



using System;

namespace stat_instant
{
    class Student
    {
        public int rollno;
        public string name;
        public static string School="ABC"; 

          public void setstuden()
    {
          string fullname = this.name;
          Console.WriteLine("Your full name is :",fullname);
    }
    
   


    
    class stat_instant
    {
       
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.rollno=23;
            s1.name="Raj";
            Console.WriteLine("Student1 roll no is:{0} ",s1.rollno);
            Console.WriteLine("Student1 name is:{0} ",s1.name);
            Console.WriteLine("Schoole name is:{0}",Student.School);
            
            s1.setstuden();
          

        }

    }
    
    }

}