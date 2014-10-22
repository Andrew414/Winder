using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSystem
{
    public partial class WinderMain : Form
    {
        public WinderMain()
        {
            InitializeComponent();
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

        int animationState = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            animationState ++ ;
            animationState %= 4;

            pnlRotor.BackgroundImage = Image.FromFile(@"..\..\img\blade" + animationState.ToString() + ".png");
            pnlGenerator.BackgroundImage = Image.FromFile(@"..\..\img\generator.png");
            pnlWater.BackgroundImage = Image.FromFile(@"..\..\img\water" + animationState.ToString() + ".png");
        }
    }
}
