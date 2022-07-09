using System;

namespace FirstBadVersion
{
    class Program
    {
        const int n = 2147483646;
        const int fbv = 3;
        static void Main(string[] args)
        {
            HammingWeight(1011);
            Console.WriteLine($"First bad version is : {FirstBadVersion(n)}");
            Console.ReadLine();
        }

        public static int FirstBadVersion(int n)
        {
            int low = 0, high = n, firstBadVersion = int.MaxValue;
            int mid;
            while (low <= high)
            {
                mid = low + (high - low ) / 2;
                if (IsBadVersion(mid))
                {
                    firstBadVersion = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                
            }
            return firstBadVersion;
        }

        public static bool IsBadVersion(int n)
        {
            Console.WriteLine($"IsBadVersion : {n}");
            return n >= fbv;
        }

        public static int HammingWeight(uint n)
        {
            int hammingCount = 0;
            while (n > 0)
            {
                uint remainder = n % 10;
                if (remainder == 1)
                {
                    hammingCount++;
                }
                n = n / 10;
            }
            return hammingCount;
        }
    }
}
