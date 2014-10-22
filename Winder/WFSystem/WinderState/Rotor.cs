using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSystem.WinderState
{
    class Rotor
    {
        public GlobalState State { get; set; }

        public Boolean Active { get; set; }

        public double temperature;
        public double speed;

        public Boolean Start()
        { 
            return true;
        }

        public Boolean Stop()
        {
            return true;
        }
    }
}
