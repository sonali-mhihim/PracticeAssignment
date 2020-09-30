using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PracticeAssignment
{
    public class Spiral
    {
        public static void PrintSpiral(int[,] a)
        {
            int k = 0;
            int m = a.GetLength(0);
            int l = 0;
            int n = a.GetLength(1);
            while (k < m && l < n)
            {
                //print first row from the remaining rows
                for (var i = l; i < n; i++)
                {
                    Console.WriteLine(a[k, i]);

                }
                k++;
                // print last column from the remaining columns
                for (var i = k; i < m; i++)
                {
                    Console.WriteLine(a[i, (n - 1)]);
                }
                n--;
                if (k < m)
                //print the  last row from the remaining rows
                {
                    for (var i = n- 1; i >= l; i--)
                    {
                        Console.WriteLine(a[m-1, i]);


                    }
                    m--;

                }
                if (l < n)
                    // print the first column from the remaining columns
                {
                    for ( var i = m-1; i>= k; i--)
                    {
                        Console.WriteLine(a[i, l]);

                    }
                    l++;
                }




            }
        }
    }
}
