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


        public Boolean StartGenerator()
        {
            if (State.rotor.Start() && State.generator.Start()) return true;
            return false;
        }

        public Boolean StartFireSystem()
        {
            return State.generator.ActivateFireSystem();
        }

        public Boolean LockRotor()
        {
            return State.rotor.Stop();
            
        }
    }
}
