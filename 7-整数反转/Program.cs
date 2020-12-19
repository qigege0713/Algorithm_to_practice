using System;

namespace _7_整数反转
{
    class Program
    {
        // 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
        static void Main(string[] args)
        {
            int num = -10001;
            var s = new Solution();
            Console.WriteLine(s.Reverse(num));
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {

            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
    }
}
