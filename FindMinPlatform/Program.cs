using System;
using System.Linq;
namespace FindMinPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrivalTime = { 6, 7, 8, 9};
            int[] departureTime = { 7, 9, 9, 9 };
            Console.WriteLine("Minimum number of platform needed is: {0}", FindMinimumPlatformRequired(arrivalTime, departureTime));
        }

        private static int FindMinimumPlatformRequired(int[] arrivalTime, int[] departureTime)
        {
            int TrainInStation = 0;
            int PlatformNeeded = 0;
            int[] ArrivalDepartureTime = arrivalTime.Union(departureTime).ToArray();
            Array.Sort(ArrivalDepartureTime);
            foreach (int time in ArrivalDepartureTime)
            {
                if(arrivalTime.Contains(time))
                {
                    TrainInStation++;
                    if(TrainInStation > PlatformNeeded)
                    {
                        PlatformNeeded++;
                    }
                }
                if (departureTime.Contains(time))
                {
                    TrainInStation--;
                }
            }

            return PlatformNeeded;
        }
    }
}
