using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0,count=0;
            int[] a = new int[100];

            Console.WriteLine("Please Insert Array Length: ");

            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please Input Array Elements: ");

            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            //Reverse
            Console.WriteLine("The values in reverse : ");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine( a[i]);
            }
            //sum
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum of All element : " + sum);
            //Copy
            int[] a2 = new int[100];

            for (int i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
            Console.WriteLine("First Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine("\nSecond Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" " + a2[i]);
            }
            //Duplicate
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] == a[i])
                        Console.WriteLine("Duplicated Numbers : "+ a[j]);
                }
            }



            //Unique
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < n + 1; j++)
                {
                    if (i != j)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                           
                            
                        }
                    }
                }
                
                
                if (count == 0)
                {
                    
                    Console.WriteLine("Unique Numbers: " + a[i]);
                }
            }
            
            
            
            


        }
    }
}
        

           