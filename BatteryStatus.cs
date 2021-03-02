using System;

namespace Checker
{
    class BatteryStatus
    {
      
        public static void CheckBatteryCondition(float temperature, float soc, float chargeRate)
        {
            TestBatteryCondition.CheckTemperature(temperature);
            TestBatteryCondition.CheckChargeState(soc);
            TestBatteryCondition.CheckChargeRate(chargeRate);
        }

        public static void DisplayBatteryStatus(string property, BatteryLevel.BatteryCondition batteryCondition)
        {
            Console.WriteLine($"Battery {property} is {batteryCondition}");
        }
    }
}
