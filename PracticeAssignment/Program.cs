
using ImTools;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace PracticeAssignment
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //// calculate sum of numbers

            //int[] num = new int[] { 1, 2, 3, 4, 5 };
            //var sum = 0;
            //for (var i = 0; i < num.Length; i++)
            //{
            //    sum = sum + num[i];
            //}
            //Console.WriteLine($"sum of numbers in aarray = { sum}");


            ////calculate squares of numbers

            //for (var i = 0; i < num.Length; i++)
            //{
            //    var squares = num[i] * num[i];

            //    Console.WriteLine($"square of numbers {num[i]} = {squares}");
            //}

            //// calulate sum of squares
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 7 };
            //var squaresum = 0;
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    var squares = nums[i] * nums[i];
            //    squaresum += squares;
            //}
            //Console.WriteLine($"sum of squares = {squaresum}");


            //// check if there is negative number
            //int[] array = new int[] { 1, -2, 3, -4, 5, 7 };
            //for (var i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    Console.WriteLine("false");
            //}


            ////given an array, a integer, and sum of integer; find index of number
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 7 };
            //var result = IntegerSum.FindIndex(numbers, 3, 4);
            //Console.WriteLine($"FindIndex = {result}");

            ////print even Indices of a given array
            //int[] nums1 = new int[] { 2, 4, 11, 13, 18, 20 };
            //EvenIndices.PrintEvenIndices(nums1);
            //Console.WriteLine(nums1);

            ////print odd Indices of a given array
            //int[] nums2 = new int[] { 2, 4, 11,13,18,20};
            //OddIndices.PrintOddIndices(nums2);
            //Console.WriteLine(nums2);

            //// print reverse
            //int[] arr1 = new int[] { 2, 4, 11, 14, 15, 16 };
            //ReverseArray.PrintReverse(arr1);
            //Console.WriteLine(arr1);

            //// return indices of two numbers
            //int[] nums3 = new int[] { 2, 4, 10, 6, 3 };
            //var results = TwoIndices.TwoSum(nums3, 10);
            //Console.WriteLine($" Indices = {results[0]}, {results[1]}");



            //// return largest value
            //int[] nums4 = new int[] { 2, 4, 5, 3, 1 };
            //var max = Largest.FindlargestValue(nums4);
            //Console.WriteLine($"Find Max Value = {max}");

            // unique elements in window
            //int[] nums5 = new int[] { 4, 1, 2, 1, 2, 3, -10 };
            //new UniqueElementWindow().FindUnique(nums5, 3);


            //// Missing Number
            //int[] a = new int[] { 4, 2, 3, 5 };
            //var result = Missing.FindMissingNumber(a, 4);
            //Console.WriteLine($"Missing number = {result}");

            //// equibilirium index
            //int[] A = new int[] {4,3,2,0,4,5};
            //var results = EquilibriumIndex.FindIndex(A, 6);
            //Console.WriteLine($"EquilibriumIndex = {results}");

            ////subarray of Given sum
            //int[] D= new int[] { 1, 4, 20, 3, 10, 5 };
            //var results1 = GivenSum.FindSubArraySum(D, 6, 33);
            //Console.WriteLine($"subarray of given sum = {results1}");

            //// print spiral
            //int[,] s = new int[4, 4]
            //{
            //    {1,2,3,4 },
            //    {5,6,7,8 },
            //    {9,10,11,12},
            //    {13,14,15,16},
            //};
            //Spiral.PrintSpiral(s);

            ////SortDict
            //var sortArray = new int[] { 2, 5, 2, 8, 5, 6, 8, 8 };
            //SortDict.Test(sortArray);

            ////print subarrays
            //int[] a5 = new int []{ 10, 2, -2, -20, 10 };
            //int sum = -10;
            //Subarrays.PrintSubarrays(a, sum);

            // LongestDistinctSubstring
            char[] letters = { 'a', 'b', 'c', 'b', 'a', 'd' };
            string str = new string(letters);
           var result4 = LongestDistinctSubstring.UniqueSubstring(str);
            Console.WriteLine ($" substring with distint character = {result4}");

            // convert Roman To Integers
            
            //string s = new string("XIV");
            string s = new string("X");
            var res = RomanToIntegers.ConvertRomanToIntegers(s);
            Console.WriteLine($"Roman to integers = {res}");

            //longest palindronic substring
            string m = new string("bcaacbzdf");
            var rest = LongestPalindromicSubstring.LongestPalindromic(m);
            Console.WriteLine($"Longest palindromic substring = {rest}");

            RecursiveRemove();
        }

        private static void RecursiveRemove()
        {
            // Recursive Remove Duplicates
            var input = "acaaabbbacdddd";
            var result = RecursiveRemoveDuplicates.RecursiveRemove(input);
            Console.WriteLine($"RecursiveRemoveDuplicates Result = {result} for input = {input}");
        }
    }
}
