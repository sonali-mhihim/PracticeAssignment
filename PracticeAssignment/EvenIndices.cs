using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    static class EvenIndices
    {

        public static void PrintEvenIndices(int[] nums)
        {
            for (var i = 0; i < (nums.Length - 1); i = i + 2)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
