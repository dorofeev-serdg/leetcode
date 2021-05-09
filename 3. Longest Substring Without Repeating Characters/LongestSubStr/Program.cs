using System;

namespace LongestSubStr
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = LengthOfLongestSubstring("abcabcbb");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            for (int startIndex = 0; startIndex < s.Length - result; startIndex++)
            {
                int localMaxCounter = CountUnrepeatableCharacters(s.Substring(startIndex));
                result = localMaxCounter > result ? localMaxCounter : result;
            }
            return result;
        }

        public static int CountUnrepeatableCharacters(string str)
        {
            var chars = new bool[1000];
            int result = 0;
            var sArray = str.ToCharArray();

            for (int i = 0; i < str.Length ; i++)
            {
                var currentChar = sArray[i];

                if (!chars[currentChar])
                {
                    chars[currentChar] = true;
                    result++;
                }
                else
                {
                    return result;
                }
            }

            return result;
        }
    }
}
