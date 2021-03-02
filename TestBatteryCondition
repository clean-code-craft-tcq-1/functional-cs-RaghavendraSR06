namespace Checker
{
    class TestBatteryCondition
    {
        public static void CheckChargeRate(float chargeRate)
        {
            float minChargeRate = 0.3f;
            float maxChargeRate = 0.8f;

            BatteryLevel.BatteryCondition batteryChargeRate = BatteryLevel.CheckBatteryCondition(chargeRate, minChargeRate, maxChargeRate);
            BatteryStatus.DisplayBatteryStatus("Charge Rate", batteryChargeRate);
        }
        
        public static void CheckChargeState(float soc)
        {
            float minStateOfCharge = 20;
            float maxStateOfCharge = 80;

            BatteryLevel.BatteryCondition batteryChargeState = BatteryLevel.CheckBatteryCondition(soc, minStateOfCharge, maxStateOfCharge);
            BatteryStatus.DisplayBatteryStatus("State of charge",batteryChargeState);
        }

        public static void CheckTemperature(float temperature)
        {
            float minTemperature = 0;
            float maxTemperature = 45;

            BatteryLevel.BatteryCondition batteryTemperature = BatteryLevel.CheckBatteryCondition(temperature, minTemperature, maxTemperature);
            BatteryStatus.DisplayBatteryStatus("Temperature", batteryTemperature);
        }
    }
}
