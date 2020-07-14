using  System;

namespace constructor
{
   class Construct
   {
       int emp_id;
       string emp_name;
       int emp_age;

       static Construct()// static constructor
       {
           Console.WriteLine("----Employee Data----\n");//static constructor
       }

         Construct(int emp_id,string emp_name,int emp_age)
       {
           this.emp_id=emp_id;
           this.emp_name=emp_name;
           this.emp_age=emp_age;
       }
       Construct()
       {
           Console.WriteLine("----- Fill Your Detail----");
       }
        // Construct(int a, string na,int c)
        // {
        //     this.a=a;
        // } constructor overload
    //    public int getId()
    //    {
    //        return this.emp_id;
    //    }
    //    public string getname()
    //    {
    //        return this.emp_name;
    //    }
    //    public int getage()
    //    {
    //        return this.emp_age;
    //    }

        public void  getDetails()
        {
            Console.WriteLine("Employee id is:{0}",this.emp_id);
            Console.WriteLine("Employee name is:{0}",this.emp_name);
            Console.WriteLine("Employee age is:{0}",this.emp_age);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee age ");
            int age = int.Parse(Console.ReadLine());
            Construct p = new Construct(id,name,age);
            // Console.WriteLine("Employee id is:{0}",p.emp_id);
            //  Console.WriteLine("Employee id is:{0}",p.emp_name);
            //   Console.WriteLine("Employee id is:{0}",p.emp_age);

           Construct p1 = new Construct();
           Console.WriteLine(p1);
 

            p.getDetails();

        }
   } 
}
    
