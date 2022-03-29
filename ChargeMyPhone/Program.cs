using System;

namespace ChargeMyPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            ChargePhone(5, 50);
        }
        public static void ChargePhone(int initialCharge, int batteryCapacity)
        {
            int timeElapsed = 0;
            int currentCharge = initialCharge;

            while(currentCharge < batteryCapacity)
            {
                int smartChargeRate = GetChargingRate(currentCharge);
                currentCharge = currentCharge + smartChargeRate;
                timeElapsed++;
            }

            Console.WriteLine("Total time taken to charge the phone from {0} to {1} is : {2}min", initialCharge, currentCharge, timeElapsed);
        }

        private static int GetChargingRate(int currentCharge)
        {
            int smartChargeRate = 0;
            switch (currentCharge)
            {
                case int n when 0 <= n && n <= 10:
                    smartChargeRate = 10;
                    break;
                case int n when 11 <= n && n <= 230:
                    smartChargeRate = 5;
                    break;
                case int n when 231 <= n && n <= 559:
                    smartChargeRate = 8;
                    break;
                case int n when 560 <= n && n <= 1009:
                    smartChargeRate = 2;
                    break;
                case int n when 1010 <= n && n <= 5000:
                    smartChargeRate = 7;
                    break;
                case int n when 5001 <= n && n <= 10000:
                    smartChargeRate = 8;
                    break;
                case int n when 10001 <= n && n <= 1000000000:
                    smartChargeRate = 3;
                    break;
                default:
                    break;
            }

            return smartChargeRate;
        }
    }
}


