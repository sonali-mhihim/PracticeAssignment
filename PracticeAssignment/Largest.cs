using DryIoc;
using ImTools;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PracticeAssignment
{
   static class Largest
    {
      public static int FindlargestValue(int[] nums)
        {
            var max = nums[0];
            
            for (var i = 1; i<nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                  
                }
            }
            return (max);
        }
        
    }
}
