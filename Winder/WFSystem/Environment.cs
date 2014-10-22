using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSystem
{
    class Environment
    {

        public Double WindSpeed { get; set; }
        public Double WindSpeedAvg { get; set; }
        public String WindDirection { get; set; }
        public Double Temperature { get; set; }

        public Environment()
        {
            WindDirection = "N";
            WindSpeed = WindSpeedAvg = 12;
            Temperature = 10;
        }

    }
}
