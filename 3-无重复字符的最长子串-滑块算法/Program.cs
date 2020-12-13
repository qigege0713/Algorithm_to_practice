using System;
using System.Collections.Generic;

namespace 无重复字符的最长子串
{
    class Program
    {
        // 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度

        // 输入: s = "abcabcbb"
        // 输出: 3 
        // 解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
        static void Main(string[] args)
        {
            string s = "abcabcbb";//dvdf
            int reu = LengthOfLongestSubstring(s);
            Console.WriteLine(reu);
        }
        public static int LengthOfLongestSubstring(string str)
        {
            int left = 0, right = 0;
            int count = 0;
            int max = 0;
            List<char> cache = new List<char>();

            while (right < str.Length)
            {
                if (!cache.Contains(str[right]))
                {
                    cache.Add(str[right]);
                    right++;
                    count++;
                }
                else
                {
                    cache.Remove(str[left]);
                    left++;
                    count--;
                }
                max = max>count?max:count;
            }
            return max;
        }


    }
}
