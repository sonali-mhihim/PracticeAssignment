using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    public static class RomanToIntegers
    {
        public static int ConvertRomanToIntegers(string s)
        {
            int n = s.Length;
            int result = 0;
            
            Dictionary<char, int> roman = new Dictionary<char, int>();
            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

                                                                                                                                                           
            for (var i = 0; i < n; i++)
            {
                var current = s[i];
                var currentNumber = roman[current];
                if (i < n-1)
                {
                    var next = s[i + 1];
                    var nextNumber = roman[next];

                    if (nextNumber > currentNumber)
                    {
                        result = result + (nextNumber - currentNumber);
                        i++;
                    }
                    else
                    {
                        result = result + currentNumber;
                    }
                }
                else
                {
                    result = result + currentNumber;
                }

            }
            return result;
        }
           
        }
}

