using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    class UniqueElementWindow
    {
        public void FindUnique(int[] nums, int k)
        {
            for (var i = 0; i < nums.Length - k + 1; i++)
            {
                var dictionary = new Dictionary<int, int>();
                for (var j = i; j < i + k; j++)
                {
                    if (!dictionary.ContainsKey(nums[j]))
                    {
                        dictionary.Add(nums[j], 1);
                    }
                }

                Console.WriteLine("Unique element Count " + dictionary.Count);
            }
        }
    }
}
