using System;

namespace Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Console.WriteLine(Search_In_Rotated_Sorted_Array(nums, 4)); // 0
            Console.WriteLine(Search_In_Rotated_Sorted_Array(nums, 2)); // 6

            int[] nums1 = new int[] { 6, 7, 0, 1, 2, 3, 4, 5 };
            Console.WriteLine(Search_In_Rotated_Sorted_Array(nums1, 4)); // 6
            Console.WriteLine(Search_In_Rotated_Sorted_Array(nums1, 2)); // 4

            int[] nums2 = new int[] { 5, 1, 2, 3, 4 }; // 1
            Console.WriteLine(Search_In_Rotated_Sorted_Array(nums2, 1));

            Console.ReadLine();
        }

        private static int Search_In_Rotated_Sorted_Array(int[] nums, int target)
        {
            for (int low = 0, high = nums.Length - 1; low <= high;)
            {
                if (nums[low] == target)
                    return low;
                if (nums[high] == target)
                    return high;

                int mid = (low + high) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[low] <= nums[mid])
                {
                    if (target >= nums[low] && target <= nums[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else
                {
                    if (target >= nums[mid] && target <= nums[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
    }
}
