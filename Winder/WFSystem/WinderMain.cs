using System;
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

            state.generator.State = state.panel.State = state.rotor.State = sim.state = state;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
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
            lblValueWindDirection.Text = sim.state.env.WindDirection;

            // Draw rotor
            pnlRotor.BackgroundImage = Image.FromFile(@"..\..\img\blade" + animationState.ToString() + (sim.state.rotor.Active ? "" : "d") + ".png");
            lblRotorSpeed.Text = "ω = " + ((int)(60 * sim.state.rotor.speed)).ToString() + " оборотов в минуту";
            lblOutdoorTemp.Text = "t = " + ((Math.Round(sim.state.rotor.temperature,1))).ToString() + " °C";

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

            lblGeneratorTemp.Text = "t = " + ((Math.Round(sim.state.generator.temperature, 0))) + " °C";

            // Draw panel
            pnlCplBlock.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.Active ? "inactive" : "alarm") + "16.png");
            pnlCplBrake.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.brakeEnabled ? "active" : "inactive") + "16.png");
            pnlCplFire.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.generator.FireSystemActive ? "alarm" : "inactive") + "16.png");
            pnlCplGenOff.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.generator.Active ? "inactive" : "alarm") + "16.png");
            pnlCplHeater.BackgroundImage = Image.FromFile(@"..\..\img\system" + (sim.state.rotor.heaterEnabled ? "active" : "inactive") + "16.png");

            lblStatDir.Text = sim.state.env.WindDirection;
            if (timerState % 10 == 0)
            {
                lblStatIntensity.Text = sim.state.env.WindSpeed.ToString() + " м/с";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tmrUpdateUI.Enabled)
            {
                tmrUpdateUI.Stop();
                btnModelStartStop.Text = "Старт!";
            }
            else
            {
                tmrUpdateUI.Start();
                btnModelStartStop.Text = "Стоп!";
            }
        }

        private void numWind_ValueChanged(object sender, EventArgs e)
        {
            sim.state.env.WindSpeedAvg = (double) numWind.Value;
        }

        private void rbnN_CheckedChanged(object sender, EventArgs e)
        {
            sim.state.env.WindDirection = (sender as RadioButton).Text;
        }

        private void numTemp_ValueChanged(object sender, EventArgs e)
        {
            sim.state.env.Temperature = (double)numTemp.Value;
        }

        private void btnModelFire_Click(object sender, EventArgs e)
        {
            sim.state.generator.temperature = 600;
        }

        private void btnTornado_Click(object sender, EventArgs e)
        {
            sim.state.env.WindSpeed = 35;
            sim.ProcessSignals();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            sim.state.generator.ActivateFireSystem();
        }

        private void lblGeneratorTemp_DoubleClick(object sender, EventArgs e)
        {
            sim.state.generator.temperature = 300;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sim.state.rotor.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sim.state.rotor.Start();
            sim.state.generator.Start();
        }
    }
}
