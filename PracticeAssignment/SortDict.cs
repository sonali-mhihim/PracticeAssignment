using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PracticeAssignment
{
    public static class SortDict
    {
        public static void Test(int[] arr)
        {
            var dict = new Dictionary<int, Tuple<int, int>>();
            for (var i = 0; i < arr.Length; i++)
            {
                var ele = arr[i];
                if (dict.ContainsKey(arr[i]))
                {
                    var value = dict[ele];
                    var res = new Tuple<int, int>(value.Item1 + 1, value.Item2);
                    dict[ele] = res;
                }
                else
                {
                    var res = new Tuple<int, int>(1, i);
                    dict[ele] = res;
                }
            }

            var sorted = dict.Values.ToList().OrderByDescending(item => item.Item1);

            var result = new int[arr.Length];
            int index = 0;
            foreach (var sortedEle in sorted)
            {
                Console.WriteLine("dadsad " + sortedEle);
                for (var j = 0; j < sortedEle.Item1; j++)
                {
                    result[index++] = arr[sortedEle.Item2];
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
