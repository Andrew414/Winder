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
            this.Active = true;

            return true;
        }

        public Boolean Stop()
        {
            Active = false;
            this.speed = 0;
            this.State.generator.Stop();

            return true;
        }

        private DateTime brakeStart;
        public Boolean brakeEnabled;

        private DateTime heaterStart;
        public Boolean heaterEnabled;

        public Boolean ReportHighSpeed()
        {
            if (brakeEnabled) 
            {
                return false;
            }

            brakeEnabled = true;
            brakeStart = DateTime.Now;

            return true;
        }

        public Boolean CheckHighSpeed()
        {
            if (!brakeEnabled)
            {
                return false;
            }

            if (brakeEnabled && brakeStart.AddSeconds(Constants.MAINTENANSE_PERIOD.TotalSeconds) < DateTime.Now)
            {
                brakeEnabled = false;
                return false;
            }

            return true;
        }

        public Boolean ReportLowTemp()
        {
            if (heaterEnabled)
            {
                return false;
            }

            heaterEnabled = true;
            heaterStart = DateTime.Now;

            return true;
        }

        public Boolean CheckLowTemp()
        {
            if (!heaterEnabled)
            {
                return false;
            }

            if (heaterEnabled && heaterStart.AddSeconds(Constants.MAINTENANSE_PERIOD.TotalSeconds) < DateTime.Now)
            {
                heaterEnabled = false;
                return false;
            }

            return true;
        }

        public Rotor()
        {
            heaterEnabled = false;
            brakeEnabled = false;

            Active = true;

            temperature = 10;
            speed = 2.0;
        }
    }
}
