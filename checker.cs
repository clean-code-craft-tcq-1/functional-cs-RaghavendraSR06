namespace Checker
{
    class Battery
    {
        static int Main()
        {
            BatteryStatus.CheckBatteryCondition(40, 60, 0.4f);
            return 0;
        }
    }
}
