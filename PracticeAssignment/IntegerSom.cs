using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    static class IntegerSum
    {

        public static int FindIndex(int[] numbers, int num, int sum)
        {
            int sumOfInteger = sum;
            int a = num;
            for (var i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] + num == sum)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            return -1;
        }
    }
}
