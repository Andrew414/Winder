namespace WFSystem
{
    partial class WinderMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlGenerator = new System.Windows.Forms.Panel();
            this.pnlWater = new System.Windows.Forms.Panel();
            this.pnlRotor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlGenerator.SuspendLayout();
            this.pnlRotor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(544, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 226);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(544, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 268);
            this.panel2.TabIndex = 0;
            // 
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Interval = 50;
            this.tmrUpdateUI.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Система торможения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Система подогрева";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WFSystem.Properties.Resources.systemactive;
            this.panel5.Location = new System.Drawing.Point(149, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 32);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WFSystem.Properties.Resources.systemactive;
            this.panel3.Location = new System.Drawing.Point(94, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 32);
            this.panel3.TabIndex = 3;
            // 
            // pnlGenerator
            // 
            this.pnlGenerator.BackgroundImage = global::WFSystem.Properties.Resources.generator;
            this.pnlGenerator.Controls.Add(this.label6);
            this.pnlGenerator.Location = new System.Drawing.Point(322, 234);
            this.pnlGenerator.Name = "pnlGenerator";
            this.pnlGenerator.Size = new System.Drawing.Size(128, 128);
            this.pnlGenerator.TabIndex = 1;
            // 
            // pnlWater
            // 
            this.pnlWater.BackgroundImage = global::WFSystem.Properties.Resources.water3;
            this.pnlWater.Location = new System.Drawing.Point(322, 150);
            this.pnlWater.Name = "pnlWater";
            this.pnlWater.Size = new System.Drawing.Size(128, 128);
            this.pnlWater.TabIndex = 1;
            // 
            // pnlRotor
            // 
            this.pnlRotor.BackgroundImage = global::WFSystem.Properties.Resources.blade0;
            this.pnlRotor.Controls.Add(this.panel4);
            this.pnlRotor.Location = new System.Drawing.Point(132, 188);
            this.pnlRotor.Name = "pnlRotor";
            this.pnlRotor.Size = new System.Drawing.Size(128, 128);
            this.pnlRotor.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WFSystem.Properties.Resources.systemactive;
            this.panel4.Location = new System.Drawing.Point(20, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::WFSystem.Properties.Resources.Connection;
            this.panel6.Location = new System.Drawing.Point(162, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 192);
            this.panel6.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Система пожаротушения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "v = 120 оборотов в минуту";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "t = 12*C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "t = 180*C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Направление ветра:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Скорость ветра:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "12 м/с";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "NNW";
            // 
            // WinderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGenerator);
            this.Controls.Add(this.pnlWater);
            this.Controls.Add(this.pnlRotor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "WinderMain";
            this.Text = "Form1";
            this.pnlGenerator.ResumeLayout(false);
            this.pnlGenerator.PerformLayout();
            this.pnlRotor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private System.Windows.Forms.Panel pnlRotor;
        private System.Windows.Forms.Panel pnlGenerator;
        private System.Windows.Forms.Panel pnlWater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

    }
}

