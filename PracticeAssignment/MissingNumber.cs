using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PracticeAssignment
{
    class Missing
    {
        public static int FindMissingNumber(int[] a, int n)
        {
            //actual size of the array is n+1 since missing element is from the array
            int m = n + 1;
            // sum of N natural numbers
            int total = m * (m + 1) / 2;
            int sum = 0;
            for (var i=0; i<n; i++)
            {
                sum += a[i];
            }
            return (total - sum);
        }
        
    }
}
