using System;
using System.Collections.Generic;
using System.Text;

namespace WFSystem
{
    class GlobalState
    {
        private GlobalState() { }
        private static GlobalState _globalstate = null;

        public static GlobalState GetState()
        {
            if (_globalstate == null)
            {
                _globalstate = new GlobalState();
            }

            return _globalstate;
        }

        public Environment env = null;
        public WFSystem.WinderState.Rotor rotor = null;
        public WFSystem.WinderState.ControlPanel panel = null;
        public WFSystem.WinderState.Generator generator = null;

    }
}
