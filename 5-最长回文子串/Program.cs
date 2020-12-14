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
            //old commit
            // var s = new oldSolution();
            // string str = "abc";
            // Console.WriteLine(s.LongestPalindrome(str));

            var s = new Solution();
            string str = "abbdbbbba";
            Console.WriteLine(s.LongestPalindrome(str));

        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            int maxlen = 1, start = 0;
            if (s.Length < 2) return s;

            bool[,] P = new bool[n, n];

            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (s[i] != s[j])
                    {
                        P[i, j] = false;
                    }
                    else
                    {
                        if (j - i < 3) P[i, j] = true;
                        else P[i, j] = P[i + 1, j - 1];
                    }

                    if(P[i,j]&&j-i+1>maxlen)
                    {
                        maxlen = j-i+1;
                        start = i;
                    }
                }
            }

            return s.Substring(start, maxlen);
        }

    }
    //算法超时
    public class oldSolution
    {
        public string LongestPalindrome(string s)
        {
            int start = 0;
            int len = 1;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - i; j > 1; j--)
                {
                    if (Judg(s.Substring(i, j)) && len < j)
                    {
                        len = j;
                        start = i;
                    }
                }
            }
            return s.Substring(start, len);
        }
        public bool Judg(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }

}
