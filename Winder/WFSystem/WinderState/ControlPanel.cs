using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSystem.WinderState
{
    class ControlPanel
    {
        public GlobalState State { get; set; }

        /*public Boolean RotorStoppedIndicator { get; set; }
        public Boolean GeneratorStoppedIndicator { get; set; }
        public Boolean FireSystemActivatedIndicator { get; set; }

        public Boolean WarmingSystemActivated { get; set; }
        public Boolean BrakingSystemActivated { get; set; }*/

        public Boolean StartGenerator()
        {
            return true;
        }

        public Boolean StartFireSystem()
        {
            return true;
        }

        public Boolean LockRotor()
        {
            return true;
        }
    }
}
