using System;
using System.Collections.Generic;
using System.Text;

namespace FOLD
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
        public FOLD.Rotor rotor = null;
        public FOLD.ControlPanel panel = null;
        public FOLD.Generator generator = null;

    }
}
