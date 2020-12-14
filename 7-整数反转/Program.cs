using System;
using System.Collections.Generic;


namespace _7_整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int x = 1534236469;
            Console.WriteLine(s.Reverse(x));
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {
            List<int> results = new List<int>();

            int len = GetDigit(x);
            for (int i = 0; i < len; i++)
            {
                results.Add(x % 10);
                x /= 10;
            }
            long num = 0;
            for (int i = 0; i < len; i++)
            {
                int a = (int)Math.Pow(10, len - i - 1);
                num += results[i] * a;
            }
            if (num < Int && num > (-(int)(Math.Pow(2, 32))))
            {
                return (int)num;
            }
            return 0;
        }
        public int GetDigit(int x)
        {
            int dight = 1;
            if (x < 0) x = x * (-1);
            while (x / 10 > 0)
            {
                x /= 10;
                dight += 1;
            }
            return dight;
        }
    }
}
