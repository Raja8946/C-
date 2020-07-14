using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Can only be used in override method
namespace Default
{
class A
{
    public virtual void show()
    {
        Console.WriteLine("----A---");
    }
}

class B : A
{
    public sealed override void show()
    {
        Console.WriteLine("---B---");

    }
}
class C : B
{
    public override void show()
    {
        Console.WriteLine("---C---");
    }
}

    public class Sealedmethod
    {
        static void Main(string[] args)
        {
          C c=new C();
          c.show();
        }
    }
}
