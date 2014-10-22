﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSystem.WinderState;

namespace WFSystem
{
    public partial class WinderMain : Form
    {
        public WinderMain()
        {
            InitializeComponent();
            sim = new Simulator();

            GlobalState state = GlobalState.GetState();
            state.env = new Environment();
            state.generator = new Generator();
            state.panel = new ControlPanel();
            state.rotor = new Rotor();

            sim.state = state;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (tmrUpdateUI.Enabled)
            {
                tmrUpdateUI.Stop();
            }
            else
            {
                tmrUpdateUI.Start();
            }
        }

        int timerState = 0;

        Random rand = new Random(DateTime.Now.Millisecond);
        int defaultx = 381;
        int defaulty = 143;

        Simulator sim;
        
        void DrawStats()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerState ++ ;
            int animationState = timerState % 4;

            sim.DoOneStep();

            // Draw common info
            DrawStats();
            lblValueWindIntensity.Text = sim.state.env.WindSpeed.ToString() + " м/с";
            lblValueWindDirection.Text = "NW";

            // Draw rotor
            pnlRotor.BackgroundImage = Image.FromFile(@"..\..\img\blade" + animationState.ToString() + (sim.state.rotor.Active ? "" : "d") + ".png");
            lblRotorSpeed.Text = "ω = " + ((int)(60 * sim.state.rotor.speed)).ToString() + " оборотов в минуту";
            lblOutdoorTemp.Text = "t = " + sim.state.rotor.temperature.ToString() + " °C";

            pnlIndBrake.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.brakeEnabled ? "" : "in") + "active.png");
            pnlIndHeater.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.heaterEnabled ? "" : "in") + "active.png");


            // Draw generator
            pnlGenerator.BackgroundImage = Image.FromFile(@"..\..\img\generator" + animationState.ToString() + (sim.state.generator.Active ? "" : "d") + ".png");

            if (sim.state.generator.Active)
            {
                pnlGenerator.Top = defaulty + rand.Next(3) - 1;
                pnlGenerator.Left = defaultx + rand.Next(3) - 1;
            }

            if (sim.state.generator.FireSystemActive)
            {
                pnlWater.BackgroundImage = Image.FromFile(@"..\..\img\water" + animationState.ToString() + ".png");
            }
            else
            {
                pnlWater.BackgroundImage = Image.FromFile(@"..\..\img\water0.png");
            }

            lblGeneratorTemp.Text = "t = " + sim.state.generator.temperature.ToString() + " °C";

            // Draw panel
            pnlCplBlock.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.Active ? "inactive" : "alarm") + "16.png");
            pnlCplBrake.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.brakeEnabled ? "active" : "inactive") + "16.png");
            pnlCplFire.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.generator.FireSystemActive ? "alarm" : "inactive") + "16.png");
            pnlCplGenOff.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.generator.Active ? "inactive" : "alarm") + "16.png");
            pnlCplHeater.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.heaterEnabled ? "active" : "inactive") + "16.png");
        }
    }
}
