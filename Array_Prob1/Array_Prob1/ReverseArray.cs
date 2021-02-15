using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Prob1
{
    class ReverseArray
    {
        public static void reverse(int []a, int n)
        {
            int[] b = new int [n];
            int j = n;
            for(int i = 0; i<n;i++){
                b[j-1]=a[i];
                j = j - 1;
            }
            Console.Write("Reverse Array is : ");
            for(int k=0;k<n;k++){
                Console.Write(b[k]);

            }
        }
    }
}
