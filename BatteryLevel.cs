using System;
using System.Collections.Generic;
using System.Text;

namespace Checker
{
    class BatteryLevel
    {
       public enum BatteryCondition
       {
           Low,
           Normal,
           High
       }

       public static BatteryCondition CheckBatteryCondition(float currentValue, float minValue, float maxValue)
       {
           if (currentValue > maxValue)
           {
               return BatteryCondition.High;
               
           }

           if (currentValue < minValue)
           {
               return BatteryCondition.Low;

           }

           return BatteryCondition.Normal;
       }
    }
}
