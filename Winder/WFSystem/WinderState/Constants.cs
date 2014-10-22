using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSystem.WinderState
{
    class Constants
    {
        public static double WIND_AVG = 10.0;
        public static double TEMP_DELTA = 0.05;
        public static double SPEED_COEF = 0.05;

        public static TimeSpan MAINTENANSE_PERIOD = TimeSpan.FromSeconds(30);
    }
}
