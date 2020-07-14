using System;

namespace matrixmulti
{
  class  matrixmulti
  {
      static void Main(string[] args)
      {
          Console.Write(" Enter first matrix row size ");
          int row1 = int.Parse(Console.ReadLine());
          Console.Write("Enter first matrix column size ");
          int col1 = int.Parse(Console.ReadLine());
          Console.Write(" Enter second matrix row size ");
          int row2 = int.Parse(Console.ReadLine());
          Console.Write("Enter second matrix column size ");
          int col2 = int.Parse(Console.ReadLine());
          int[,] mat1 = new int[row1,col1];
          int[,] mat2 = new int[row2,col2];
          int[,] mat3 = new int[row1,col2];
          Console.Write("Enter element into first matrix\n");
          int i,j;
          for(i=0;i<row1;i++)
          {
              for(j=0;j<col1;j++)
              {
                  mat1[i,j]=int.Parse(Console.ReadLine());
              }
          }
            Console.Write(" --- First Matrix ---\n");
            for(i=0;i<row1;i++)
            {
                for(j=0;j<col1;j++)
                {
                    Console.Write(mat1[i,j]+"\t");
                }
                Console.WriteLine();
            }
              Console.Write("Enter element into second matrix\n");
          
          for(i=0;i<row2;i++)
          {
              for(j=0;j<col2;j++)
              {
                  mat2[i,j]=int.Parse(Console.ReadLine());
              }
          }
            Console.Write(" --- Second Matrix ---\n");
            for(i=0;i<row2;i++)
            {
                for(j=0;j<col2;j++)
                {
                    Console.Write(mat2[i,j]+"\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----Matrix Multiplication----");
             if(col1==row2)
             {
                 for(i=0;i<row1;i++)
                 {
                     for(j=0;j<col2;j++)
                     {
                         mat3[i,j]=0;
                         for(int k=0;k<col1;k++)
                         {
                             
                             mat3[i,j]+=mat1[i,k]*mat2[k,j];
                         }
                     }
                 }
             }
             else
             {
                 Console.WriteLine(" Invalid Multiplication");
             }
             
              for(i=0;i<row1;i++)
              {
                  for(j=0;j<col2;j++)
                  {
                      Console.Write(mat3[i,j]+"\t");
                  }
                  Console.WriteLine();
              }

      }
  }   
}
