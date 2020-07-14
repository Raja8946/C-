using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Employee
    {
         private int[] age = new int[3];
         public int this[int index]
         {
             set 
             {  
                 if(index>=0 && index<3)
                 {
                     if(value>0)
                     {
                           age[index]=value;
                     }
                     else
                     {
                         Console.WriteLine("Invalid age!!");
                     }
                 }
                 else
                 {
                     Console.WriteLine("Invalid index");
                 }
             }
             get 
             {  
                 return age[index];
             }
         }
    
    public int this[int index,int i]
    {
        set 
        {  
            age[index]=value+i;
        }
        get 
        {  
            return age[index];
        }
    }
    
    }
 
    public class indexer
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[2,2]=5;
            Console.WriteLine(emp[2]);
        }
    }
}

