using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFSystem.WinderState
{
    class Generator
    {
        public GlobalState State { get; set; }

        public Boolean Active{ get; set; }
        public Boolean FireSystemActive { get; set; }

        public double temperature;

        public Boolean Start()
        {
            if (!State.rotor.Active)
            {
                return false; 
            }

            this.Active = true;
            return true;
        }

        public Boolean Stop()
        {
            this.Active = false;
            return true;
        }

        public Boolean ActivateFireSystem()
        {
            this.Active = false;
            this.FireSystemActive = true;

            return true;
        }

        public Generator()
        {
            Active = true;
            FireSystemActive = false;
            temperature = 180;
        }
    }
}
