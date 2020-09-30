using ImTools;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PracticeAssignment
{
    public static class LongestPalindromicSubstring
    {
        public static int LongestPalindromic(string s)
        {
            int n = s.Length;
            int start = 0;
            int end = 0;
            int length = 0;
            int max = 0;

            {
                for (var i = 0; i < n; i++)
                {

                    if (i % 2 == 1)
                    {
                        start = i;
                        end = i;
                    }
                    else
                    {
                        start = i;
                        end = i + 1;
                    }
                    while (start >= 0 && end < n && s[start] == s[end])
                    {
                        start--;
                        end++;
                    }

                    start++;
                    end--;
                    length = end - start + 1;
                    if (length > max)
                    {
                        max = length;
                    }
                }

                return max;
            }





        }

    }
}
