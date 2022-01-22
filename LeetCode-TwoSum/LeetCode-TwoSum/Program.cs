using System;
using System.Collections.Generic;

namespace LeetCode_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"result of [2,7,11,15] & target = 9 -> [{result1[0]},{result1[1]}]");

            var result2 = TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"result of [3, 2, 4] & target = 6 -> [{result2[0]},{result2[1]}]");

            var result3 = TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine($"result of [3, 3] & target = 6 -> [{result3[0]},{result3[1]}]");

            Console.WriteLine($"=====================================>");

            var result1D = TwoSumD(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"result of [2,7,11,15] & target = 9 -> [{result1D[0]},{result1D[1]}]");

            var result2D = TwoSumD(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"result of [3, 2, 4] & target = 6 -> [{result2D[0]},{result2D[1]}]");

            var result3D = TwoSumD(new int[] { 3, 3 }, 6);
            Console.WriteLine($"result of [3, 3] & target = 6 -> [{result3D[0]},{result3D[1]}]");
        }

        /// <summary>
        ///  Brute Force
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2 || nums.Length > Math.Pow(10, 4))
                return null;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -Math.Pow(10, 9) || nums[i] > Math.Pow(10, 9))
                    break;

                for (int j = i; j < nums.Length; j++)
                {
                    if (j == i)
                        continue;

                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }

            }

            return null;
        }

        /// <summary>
        /// Dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumD(int[] nums, int target)
        {
            if (nums.Length < 2 || nums.Length > Math.Pow(10, 4))
                return null;

            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -Math.Pow(10, 9) || nums[i] > Math.Pow(10, 9))
                    break;

                int diff = target - nums[i];
                if (result.ContainsKey(diff))
                    return new int[] { result[diff], i };
                if (!result.ContainsKey(nums[i]))
                    result.Add(nums[i], i);
            }

            return null;
        }
    }
}
