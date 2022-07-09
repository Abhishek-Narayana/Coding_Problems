using System;

namespace RemoveDuplicateFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 1, 2 };
            int pos = RemoveDuplicates(data);
            Console.WriteLine(pos);
            Console.ReadLine();
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int left = 0;
            for (int right = 1; right < nums.Length; right++)
            {
                if (nums[left] != nums[right])
                {
                    left++;
                    nums[left] = nums[right];
                }
            }
            return left;
        }

    }
}
