namespace BatteryManagementSystem
{
    class Battery
    {
        static int Main()
        {
            BatteryStatus.CheckBatteryStatus(40, 60, 0.4f);
            BatteryStatus.CheckBatteryStatus(-1, 20, 0.3f);
            BatteryStatus.CheckBatteryStatus(100, -20, 0.1f);
            return 0;
        }
    }
}
