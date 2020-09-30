using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
   public class EquilibriumIndex
    {
        public static int FindIndex(int[] a, int n)
        {
            var leftSum = a[0];
            var sum = 0;
            
            for (var i = 1 ; i < n; i++)
            {
                sum += a[i];
            }

            for (var i = 1; i < n; i++)
            {
                //sum is now considered as right sum
                sum = sum - a[i];

                if (leftSum == sum)
                {
                    return i;
                   
                }
                leftSum += a[i];

            }
            return -1;
        }
   
        }
    }

