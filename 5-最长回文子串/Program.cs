using System;

namespace _5_最长回文子串
{

    // 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
    // 输入: "babad"
    // 输出: "bab"
    // 注意: "aba" 也是一个有效答案。
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            string str = "abc";
            Console.WriteLine(s.LongestPalindrome(str));
        }
    }

    //算法超时
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int len = 1;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length-i; j > 1; j--)
                {
                    if (Judg(s.Substring(i,j))&&len<j)
                    {
                        len = j;
                        start = i;
                    }
                }
            }
            return s.Substring(start,len);
        }
        public bool Judg(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left<right)
            {
                if(s[left] != s[right])
                return false;
                left++;
                right--;
            }
            return true;
        }
    }

}
