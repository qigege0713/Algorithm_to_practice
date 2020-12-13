using System;

namespace 两数之和
{
    class Program
    {
        // 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        // 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

        // 给定 nums = [2, 7, 11, 15], target = 9
        // 因为 nums[0] + nums[1] = 2 + 7 = 9
        // 所以返回 [0, 1]
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15,1,23,4,5};
            int target = 7;
            int[] x = TwoSum(nums, target);

            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                int b = Array.IndexOf(nums[(i + 1)..nums.Length], target - nums[i]);
                if (b != -1)
                {
                    return new int[] {i,b+i+1};
                }
            }
            return new int[] {0,0};
        }
    }
}
