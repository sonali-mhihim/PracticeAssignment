using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    static class TwoIndices
    {


        public static int[] TwoSum(int[] nums3, int target)
        {
            for (var i = 0; i < (nums3.Length - 1); i++)
            {
                for (var j = i + 1; j < nums3.Length; j++)
                {
                    var sum = nums3[i] + nums3[j];

                    if (sum == target)
                    {
                        return new int[] { i, j };

                    }
                }

            }
            return null;
        }
    }
}
