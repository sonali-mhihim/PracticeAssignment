using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
   static class ReverseArray
    {
        public static void PrintReverse(int[] arr1)
        {
            for (var i = (arr1.Length-1); i >= 0; i= i - 1)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
