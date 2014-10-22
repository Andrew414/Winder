﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSystem.WinderState
{
    class Generator
    {
        public GlobalState State { get; set; }

        public Boolean Active{ get; set; }

        public Boolean Start()
        {
            return true;
        }

        public Boolean Stop()
        {
            return true;
        }

        public Boolean ActivateFireSystem()
        {
            return true;
        }
    }
}
