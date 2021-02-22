using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    class Array
    {
        
    static void  Print2dArray(string[,] arr){
    int r = arr.GetLength(0);
        int c = arr.GetLength(1);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
    }
}
