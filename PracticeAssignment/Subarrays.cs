using DryIoc;
using ImTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticeAssignment
{
    class Subarrays
    {
        public static void PrintSubarrays(int[] a, int sum)
        {
            var currentSum = 0;
            int start = 0;
            int end = -1;
            int n = a.Length;

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (var i = 0; i < a.Length; i++)
            {
                currentSum += a[i];
                start++;

                if (currentSum == sum)
                {
                    start = 0;
                    end = i;

                    Console.WriteLine($"Subarrays = { start}, { i}");
                }
                if (d.ContainsKey(currentSum))
                {
                    //start = (a[currentSum] + 1, i);

                    Console.WriteLine($"Subarrays = { start}, { i}");
                }
            }

        }
    }
}
