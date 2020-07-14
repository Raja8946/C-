using  System;

namespace class_obj
{
    class class_obj
    {
        string student_name;
        int roll_no;
        int age;
        int std;
        
        public  void setstudent(string student_name,int roll_no,int age,int std)
        {
            this.student_name=student_name;
            this.roll_no=roll_no;
            this.age=age;
            this.std=std;
        }

        public  void getstudent()
        {
            Console.WriteLine("----STUDENT DATA----");
            Console.WriteLine("Student name is:{0} ",this.student_name);
            Console.WriteLine("Student roll no is:{0}",this.roll_no);
            Console.WriteLine("Student age is:{0} ",this.age);
            Console.WriteLine("Student class is:{0} ",this.std);
        }
        public static void Main(string[] args)
        {
            class_obj p = new class_obj();
            Console.WriteLine("Enter your name  ");
           string name = Console.ReadLine();
            Console.WriteLine("Enter your roll no ");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your class ");
            int std = int.Parse(Console.ReadLine());
            
            p.setstudent(name,roll,age,std);
            p.getstudent();
        }
    }
}