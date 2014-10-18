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
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        int timerState = 0;
        int timerPlus = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timerState += timerPlus;
            timerState %= 4;
            panel3.BackgroundImage = Bitmap.FromFile(@"..\..\img\" + "blade" + timerState.ToString() + ".png");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (timerPlus == 1)
            {
                timerPlus = 3;
            }
            else
            {
                timerPlus = 1;
            }
        }
    }
}
