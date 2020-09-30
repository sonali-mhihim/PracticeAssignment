using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    static class RecursiveRemoveDuplicates
    {
        public static string RecursiveRemove(string s)
        {
            return RecursiveRemoveInternal(s, 0);
        }

        private static string RecursiveRemoveInternal(string s, int startIndex)
        {
            if (startIndex >= s.Length)
            {
                return string.Empty;
            }

            var current = s[startIndex];
            startIndex++;
            while (startIndex < s.Length && current == s[startIndex])
            {
                startIndex++;
            }

            var result = RecursiveRemoveInternal(s, startIndex);
            return current + result;
        }
    }
}