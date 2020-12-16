using System;
using System.Collections;
using System.Collections.Generic;

namespace _290_单词规律
{
    class Program
    {
        // 给定一种规律 pattern 和一个字符串 str ，判断 str 是否遵循相同的规律。
        // 这里的 遵循 指完全匹配，例如， pattern 里的每个字母和字符串 str 中的每个非空单词之间存在着双向连接的对应规律。
        // 输入: pattern = "abba", str = "dog cat cat dog"
        // 输出: true
        static void Main(string[] args)
        {
            string pattern = "abba";
            string str = "dog dog dog dog";
            var s = new Solution();
            Console.WriteLine(s.wordPattern(pattern, str));
        }
    }

    class Solution
    {
        public bool wordPattern(string pattern, string s)
        {
            string[] arr = s.Split(" ");
            if (pattern.Length != arr.Length) return false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (pattern[i] == pattern[j])
                    {
                        if (arr[i] != arr[j]) return false;
                    }
                    else
                    {
                        if(arr[i] == arr[j]) return false;
                    }
                }
            }

            return true;
        }
    }
}
