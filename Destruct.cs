using System;

namespace dest
{
    class Product
    {
        public  string name;
        public  int id;

        public Product(string name,int id)
        {
            this.name=name;
            this.id=id;
        }
        public string getname()
        {
            return this.name;
        }
        public int getid()
        {
            return this.id;
        }

        ~Product()
        {
            Console.WriteLine("Destructor is invoked");
        }
    }

          class Destruct
          {
              static void Main(string[] args)
              {
                Product p = new Product("fhhf",4578);
                Console.WriteLine(" Produt name is:{0}",p.getname());
                Console.WriteLine("roduct id is :{0}",p.getid());
              }
          }        
    }
    
