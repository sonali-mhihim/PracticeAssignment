using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PracticeAssignment
{
    public static class LongestDistinctSubstring
    {
        public static int UniqueSubstring(string s)
        {
            int n = s.Length;
            int start = 0;
            int end = 0;
            int currentLength = end - start + 1;
            int max = currentLength;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (var i = 0; i < n; i++)
            {
                var current = s[i];

                // Check for dupllicate in the current window
                if (dict.ContainsKey(s[i]))
                {
                    int value = dict[current];
                    if (value >= start)
                    {
                        start = value + 1;
                    }
                }

                // Add/Update index for the current element
                dict[current] = i;

                // Find new substring length
                currentLength = i - start + 1;

                // if new substring length > the max known. Update max length
                if (currentLength > max)
                {
                    max = currentLength;
                }
            }

            return max;

        }
        
    }
}





