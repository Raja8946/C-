using System;

class decarray
    {
        static void Main(string[] args)
        {
          int[] myarray1 = new int[3];
          myarray1[0]=5;
          myarray1[1]=7;
          myarray1[2]=8;
          
        //   for(int i=0;i<3;i++)
        //   {
        //       Console.WriteLine(myarray1[i]);
        //   }
          foreach (int item in myarray1)
          {
              Console.WriteLine(item);
          }
        }
    }
