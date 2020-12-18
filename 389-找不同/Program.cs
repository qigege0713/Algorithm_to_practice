using System;

namespace _389_找不同
{
    class Program
    {
        // 给定两个字符串 s 和 t，它们只包含小写字母。
        // 字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
        // 请找出在 t 中被添加的字母。
        static void Main(string[] args)
        {
            string s = "ab";
            string t = "abb";
            var solution = new Solution();
            

            Console.WriteLine(solution.FindTheDifference(s,t));
            
            
        }
    }
    public class Solution 
    {
        public char FindTheDifference(string s, string t) 
        {
            int ssum = 0,tsum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ssum+=s[i];
                tsum+=t[i];
            }
            tsum+=t[t.Length-1];
            return (char)(tsum-ssum);
        }

    }
}
