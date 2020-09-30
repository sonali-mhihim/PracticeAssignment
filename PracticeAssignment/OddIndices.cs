using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    class OddIndices
    {
        public static void PrintOddIndices(int[] nums2)
        {
            for (var i = 1; i < (nums2.Length); i = i + 2)
            {
                Console.WriteLine(nums2[i]);
            }
        }
    }
}
