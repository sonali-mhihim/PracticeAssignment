using DryIoc;
using ImTools;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeAssignment
{
    public class GivenSum
    { 
        public static int FindSubArraySum(int[] a, int n, int sum)
        {
            int currentSum = a[0];
            int start = 0; 
             
            for ( var i = 1; i < n; i++)
            {
                currentSum = currentSum + a[i];
                while (currentSum > sum)
                {
                    currentSum = currentSum - a[start];
                    start++;

                }
                if (currentSum == sum)
                {
                    Console.WriteLine($"SubArraySum find between indices=[{start}, {i}]");
                    return 1;
                }
            }
            Console.WriteLine("No subarray found");
            return -1;
           
        }
    }
}
