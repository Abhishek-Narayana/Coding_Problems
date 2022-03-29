using System;

namespace FindNumberOfStudentPassed
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] marksArray = new int[] { 40, 40, 30, 29, 28, 26, 25, 24, 23 };
            // int[] marksArray = new int[] { 80, 70, 60, 50, 44, 43, 42, 41, 40, 30, 20, 10 };
            // int[] marksArray = new int[] { -1, -1 };
            // int[] marksArray = new int[] { 35, 30, 30 };
            int[] marksArray = new int[] { 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 39 };
            
            int passingMark = 40;
            Console.WriteLine("Number of passed student {0}", FindNumberOfStudentPassedExam(marksArray, passingMark));
            Console.ReadLine();
        }

        public static int FindNumberOfStudentPassedExam(int[] marksArray, int passingMark)
        {
            int mid = 0, start= 0, end = marksArray.Length - 1;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (marksArray[mid] >= passingMark)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return end + 1;
        }
    }
}
