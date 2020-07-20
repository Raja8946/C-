using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter first number");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter Second number");
            // int b = int.Parse(Console.ReadLine());
            // try{
            //       int res = a/b;
            //          Console.WriteLine("Divison result is : {0}",res);
            //       }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }


        //  int[] array = new int[3];
        // try{
        //  array[0]=10;
        //  array[1]=20;
        //  array[2]=30;
        //  array[3]=40;
        //  foreach (int item in array)
        //  {
        //      Console.WriteLine(item);
        //  }
        // }
        // catch(IndexOutOfRangeException e)
        // {
        //    // Console.WriteLine("Array value is excedded its len");
        //     Console.WriteLine(e.Message);
        // }


        // try{
        // string name=null;
        // Console.WriteLine(name.Length);
        // }
        // catch(NullReferenceException e)
        // {
        //     Console.WriteLine(e.Message);
        // }

        //    Console.WriteLine("Enter a number");
        //    string Number=Console.ReadLine();
        //    try
        //    {
        //    int num=int.Parse(Number);
        //    Console.WriteLine("The entered no is :{0}",num);
        //    }

        //    catch(FormatException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }


        // try
        // {
        //     // int[] array =  new int[3];
        //     //  array[0]=10;
        //     //  array[1]=20;
        //     //  array[2]=30;
        //     //  array[3]=40;

        //     string Name="23";
        //      int i= int.Parse(Name);

        //      string name=null;
        //      Console.WriteLine(name.Length);
        // }
        // catch(Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }

        //     Console.WriteLine("Reading Statement1----");
        //     Console.WriteLine("Reading Statement2----");
        //     Console.WriteLine("Reading Statement3----");


        // try
        // {
        //     int a=10;
        //     int b=0;
        //     int res=a/b;

            
        // }

        //  catch(DivideByZeroException e)
        //  {
        //      Console.WriteLine(e.Message);
        //  }

        // finally
        // {
        //     Console.WriteLine("Final block is executed");
        // }

          Console.WriteLine("Enter your age");
          int age = int.Parse(Console.ReadLine());
          try
          {
          if(age>=18)
          {
              Console.WriteLine("U are eligible for vote!!!");
          }

          else
          {
              throw new Exception("You are not eligible for vote");
          }
          }

          catch(Exception e)
          {
              Console.WriteLine(e.Message);
          }

          int account_balance=5000;
          int Withdraw_amount=6000;
          if(Withdraw_amount>account_balance)
          {
              throw new Exception("Insufficient Balance!!!");

          }
          else
          {
              account_balance=account_balance-Withdraw_amount;
              Console.WriteLine("Remaining Balance is: {0}",account_balance);
              Console.WriteLine("Transacation Successful!!!!");
          }

        }
    }
}
