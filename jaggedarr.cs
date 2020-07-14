using System;

namespace  jaggedarr

{
 class  jaggedarr
 {
     static void Main(string[] args)
     {
         int[][] array = new int[3][];
         array[0] = new[] {11,22,33,44};
         array[1] = new[] {11,22,33,44,55};
         array[2] = new[] {11,22,33,44,55,66};

     
     for (int i = 0; i < 3; i++)
     {
         for (int j = 0; j < array[i].Length; j++)
         {
             Console.Write(array[i][j]+" ");
         }
         Console.WriteLine();
     }
 }

}

}
