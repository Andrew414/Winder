using System;
using System.Collections.Generic;
using System.Text;

namespace FOLD
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
