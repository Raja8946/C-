using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class University
    {
        private static string Universityname;
        private static string Deptname;

        public static string _univname { 
            set
            {
               
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter a name first");
                }
                else
                {
                    Universityname = value;
                }
            } 
            get
            {
                  
              
                
                    return Universityname;
                
            } 
            
            }
 public static string _deptname { 
            set
            {
               
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter a name first");
                }
                else
                {
                    Deptname = value;
                }
            } 
            get
            {
                  
              
                
                    return Deptname;
                
            } 
            
            }

        
            
        
    }
    public class Static_Property
    {
        static void Main(string[] args)
        {
               University._univname="Techno Main Salt Lake";
               Console.WriteLine(University._univname);
        }
    }
}
