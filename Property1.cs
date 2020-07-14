using System;
namespace property
{
    class Student
    {
        private string _name;
        private int _age;

        public string name 
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter a name first");
                }
                else
                {
                    this._name = value;
                }
            }   
            get 
            {
              
                  return this._name;
               
            } 
        
        }
    public int age 
    {
        set
        {
            if(value>0)
            {
                this._age=value;
            }
            else
            {
                Console.WriteLine("Enter a valid age");
            }
        }
        get
        {
            return this._age;
        }
    }

    }
        
         class property1
         {
             static void Main(string[] args)
             {
                 Student s1 =new Student();
                 s1.name=null;
                 
                 s1.age=20;
                 Console.WriteLine(s1.age);
               Console.WriteLine(s1.name);
             }
         }   
        

    }
