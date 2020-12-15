using System;

namespace _4._寻找两个正序数组的中位数
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int[] nums1 = { 1,3 };
            int[] nums2 = { 1, 2, 3, 4 };

            Console.WriteLine(s.FindMedianSortedArrays(nums1, nums2));

        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return FindMedianSorted(JoinNums(nums1, nums2));

        }

        public double FindMedianSorted(int[] nums)
        {
            int len = nums.Length;
            if (len % 2 == 1)
            {
                return nums[(len - 1) / 2];
            }
            else
            {
                return ((double)(nums[len / 2] + nums[len / 2 - 1]) / 2);
            }
        }
        public int[] JoinNums(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];
            int i1 = 0, i2 = 0;
            int count = 0;
            if (nums1.Length != 0 && nums2.Length != 0)
                while (i1 + i2 < nums.Length - 1)
                {

                    if (nums1[i1] <= nums2[i2])
                    {
                        nums[count] = nums1[i1];
                        count++;
                        if (i1 + i2 == nums.Length - 1)
                        {
                            break;
                        }
                        if (i1 == nums1.Length - 1)
                        {
                            i1 = nums1.Length - 1;
                            nums1[i1] = 1000000;
                        }
                        else
                        {
                            i1++;
                        }
                    }
                    else
                    {
                        nums[count] = nums2[i2];
                        count++;
                        if (i1 + i2 == nums.Length - 1)
                        {
                            break;
                        }
                        if (i2 == nums2.Length - 1)
                        {
                            i2 = nums2.Length - 1;
                            nums2[i2] = 1000000;
                        }
                        else
                        {
                            i2++;
                        }
                    }
                }
            else
            {
                if (nums1.Length == 0)
                {
                    foreach (var num in nums2)
                    {
                        nums[count] = num;
                        count++;
                    }
                }
                else
                {
                    foreach (var num in nums1)
                    {
                        nums[count] = num;
                        count++;
                    }
                }
            }

            return nums;
        }
    }
}
