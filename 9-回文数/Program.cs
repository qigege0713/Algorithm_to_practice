using System;

namespace _9_回文数
{
    class Program
    {
        // 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
        static void Main(string[] args)
        {
            int num = 101;
            var s = new Solution();
            Console.WriteLine(s.IsPalindrome(num));
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;
            int revertedNumber = 0;
            while(x>revertedNumber)
            {
                revertedNumber = revertedNumber*10+x%10;
                x/=10;
            }
            return x == revertedNumber || x == revertedNumber/10;
        }
    }
    public class OldSolution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var nums = x.ToString();
            int j = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++, j--)
                if (nums[i] != nums[j]) return false;
            return true;
        }
    }
}
