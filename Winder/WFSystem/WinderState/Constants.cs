using System;
using System.Collections.Generic;
using System.Text;

namespace WFSystem.WinderState
{
    class Constants
    {
        public static double WIND_AVG = 10.0;
        public static double TEMP_DELTA = 0.05;
        public static double HEAT_DELTA = 2 * TEMP_DELTA;
        public static double SPEED_COEF = 0.01;
        public static double BRAKE_COEF = 2 * SPEED_COEF;

        public static TimeSpan MAINTENANSE_PERIOD = TimeSpan.FromSeconds(10);
    }
}
