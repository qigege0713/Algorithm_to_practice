﻿using System;

namespace _13_罗马数字转整数
{
    class Program
    {
        // 罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。
        // 字符          数值
        // I             1
        // V             5
        // X             10
        // L             50
        // C             100
        // D             500
        // M             1000
        //IV --A          4
        //IX  --B        9
        //XL   --E       40
        //XC    --F      90
        //CD     --G     400
        //CM      --H    900
        // 例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。

        // 通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：

        // I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
        // X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。 
        // C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
        // 给定一个罗马数字，将其转换成整数。输入确保在 1 到 3999 的范围内     。

        static void Main(string[] args)
        {
            string str = "IX";
            var s = new Solution();
            Console.WriteLine(s.RomanToInt(str));
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            s = s.Replace("IV", "A");
            s = s.Replace("IX", "B");
            s = s.Replace("XL", "E");
            s = s.Replace("XC", "F");
            s = s.Replace("CD", "G");
            s = s.Replace("CM", "H");

            int num = 0;
            foreach (var item in s)
            {
                switch (item)
                {
                    case 'I': num += 1; break;
                    case 'V': num += 5; break;
                    case 'X': num += 10; break;
                    case 'L': num += 50; break;
                    case 'C': num += 100; break;
                    case 'D': num += 500; break;
                    case 'M': num += 1000; break;
                    case 'A': num += 4; break;
                    case 'B': num += 9; break;
                    case 'E': num += 40; break;
                    case 'F': num += 90; break;
                    case 'G': num += 400; break;
                    case 'H': num += 900; break;
                    default: break;
                }
            }

            return num;
        }
    }
}
