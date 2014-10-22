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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.pbxStatGraph = new System.Windows.Forms.PictureBox();
            this.pbxStatRose = new System.Windows.Forms.PictureBox();
            this.lblCplFire = new System.Windows.Forms.Label();
            this.pnlCplGenOff = new System.Windows.Forms.Panel();
            this.pnlCplBlock = new System.Windows.Forms.Panel();
            this.pnlCplHeater = new System.Windows.Forms.Panel();
            this.pnlCplBrake = new System.Windows.Forms.Panel();
            this.pnlCplFire = new System.Windows.Forms.Panel();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.lblCplGenOff = new System.Windows.Forms.Label();
            this.lblCplBlock = new System.Windows.Forms.Label();
            this.lblCplHeater = new System.Windows.Forms.Label();
            this.lblCplBrake = new System.Windows.Forms.Label();
            this.pnlEnvironment = new System.Windows.Forms.Panel();
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.lblBrakeSystem = new System.Windows.Forms.Label();
            this.lblHeater = new System.Windows.Forms.Label();
            this.lblFireSystem = new System.Windows.Forms.Label();
            this.lblRotorSpeed = new System.Windows.Forms.Label();
            this.lblOutdoorTemp = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblWindIntensity = new System.Windows.Forms.Label();
            this.lblValueWindIntensity = new System.Windows.Forms.Label();
            this.lblValueWindDirection = new System.Windows.Forms.Label();
            this.lblRotor = new System.Windows.Forms.Label();
            this.lblGenerator = new System.Windows.Forms.Label();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.pnlIndHeater = new System.Windows.Forms.Panel();
            this.pnlIndBrake = new System.Windows.Forms.Panel();
            this.pnlGenerator = new System.Windows.Forms.Panel();
            this.lblGeneratorTemp = new System.Windows.Forms.Label();
            this.pnlWater = new System.Windows.Forms.Panel();
            this.pnlRotor = new System.Windows.Forms.Panel();
            this.pnlCord = new System.Windows.Forms.Panel();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatRose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlControl.Controls.Add(this.btnStart);
            this.pnlControl.Controls.Add(this.btnStop);
            this.pnlControl.Controls.Add(this.btnFire);
            this.pnlControl.Controls.Add(this.pbxStatGraph);
            this.pnlControl.Controls.Add(this.pbxStatRose);
            this.pnlControl.Controls.Add(this.lblCplFire);
            this.pnlControl.Controls.Add(this.pnlCplGenOff);
            this.pnlControl.Controls.Add(this.pnlCplBlock);
            this.pnlControl.Controls.Add(this.pnlCplHeater);
            this.pnlControl.Controls.Add(this.pnlCplBrake);
            this.pnlControl.Controls.Add(this.pnlCplFire);
            this.pnlControl.Controls.Add(this.lblControlPanel);
            this.pnlControl.Controls.Add(this.lblCplGenOff);
            this.pnlControl.Controls.Add(this.lblCplBlock);
            this.pnlControl.Controls.Add(this.lblCplHeater);
            this.pnlControl.Controls.Add(this.lblCplBrake);
            this.pnlControl.Location = new System.Drawing.Point(618, -90);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(222, 414);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.Click += new System.EventHandler(this.panel1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(143, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 53);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "ПУСК";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(79, 308);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 53);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "СТОП";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Red;
            this.btnFire.Location = new System.Drawing.Point(15, 308);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(58, 53);
            this.btnFire.TabIndex = 5;
            this.btnFire.Text = "ПОЖАР";
            this.btnFire.UseVisualStyleBackColor = false;
            // 
            // pbxStatGraph
            // 
            this.pbxStatGraph.BackColor = System.Drawing.SystemColors.Menu;
            this.pbxStatGraph.Location = new System.Drawing.Point(100, 127);
            this.pbxStatGraph.Name = "pbxStatGraph";
            this.pbxStatGraph.Size = new System.Drawing.Size(96, 64);
            this.pbxStatGraph.TabIndex = 4;
            this.pbxStatGraph.TabStop = false;
            // 
            // pbxStatRose
            // 
            this.pbxStatRose.BackColor = System.Drawing.SystemColors.Menu;
            this.pbxStatRose.Location = new System.Drawing.Point(15, 127);
            this.pbxStatRose.Name = "pbxStatRose";
            this.pbxStatRose.Size = new System.Drawing.Size(64, 64);
            this.pbxStatRose.TabIndex = 4;
            this.pbxStatRose.TabStop = false;
            // 
            // lblCplFire
            // 
            this.lblCplFire.AutoSize = true;
            this.lblCplFire.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplFire.Location = new System.Drawing.Point(37, 197);
            this.lblCplFire.Name = "lblCplFire";
            this.lblCplFire.Size = new System.Drawing.Size(156, 16);
            this.lblCplFire.TabIndex = 2;
            this.lblCplFire.Text = "Система пожаротушения";
            // 
            // pnlCplGenOff
            // 
            this.pnlCplGenOff.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive16;
            this.pnlCplGenOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplGenOff.Location = new System.Drawing.Point(15, 285);
            this.pnlCplGenOff.Name = "pnlCplGenOff";
            this.pnlCplGenOff.Size = new System.Drawing.Size(16, 16);
            this.pnlCplGenOff.TabIndex = 3;
            // 
            // pnlCplBlock
            // 
            this.pnlCplBlock.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive16;
            this.pnlCplBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplBlock.Location = new System.Drawing.Point(15, 263);
            this.pnlCplBlock.Name = "pnlCplBlock";
            this.pnlCplBlock.Size = new System.Drawing.Size(16, 16);
            this.pnlCplBlock.TabIndex = 3;
            // 
            // pnlCplHeater
            // 
            this.pnlCplHeater.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive16;
            this.pnlCplHeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplHeater.Location = new System.Drawing.Point(15, 241);
            this.pnlCplHeater.Name = "pnlCplHeater";
            this.pnlCplHeater.Size = new System.Drawing.Size(16, 16);
            this.pnlCplHeater.TabIndex = 3;
            // 
            // pnlCplBrake
            // 
            this.pnlCplBrake.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive16;
            this.pnlCplBrake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplBrake.Location = new System.Drawing.Point(15, 219);
            this.pnlCplBrake.Name = "pnlCplBrake";
            this.pnlCplBrake.Size = new System.Drawing.Size(16, 16);
            this.pnlCplBrake.TabIndex = 3;
            // 
            // pnlCplFire
            // 
            this.pnlCplFire.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive16;
            this.pnlCplFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplFire.Location = new System.Drawing.Point(15, 197);
            this.pnlCplFire.Name = "pnlCplFire";
            this.pnlCplFire.Size = new System.Drawing.Size(16, 16);
            this.pnlCplFire.TabIndex = 3;
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.Location = new System.Drawing.Point(41, 382);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(152, 19);
            this.lblControlPanel.TabIndex = 2;
            this.lblControlPanel.Text = "Пульт оператора";
            // 
            // lblCplGenOff
            // 
            this.lblCplGenOff.AutoSize = true;
            this.lblCplGenOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplGenOff.Location = new System.Drawing.Point(37, 285);
            this.lblCplGenOff.Name = "lblCplGenOff";
            this.lblCplGenOff.Size = new System.Drawing.Size(134, 16);
            this.lblCplGenOff.TabIndex = 2;
            this.lblCplGenOff.Text = "Генератор выключен";
            // 
            // lblCplBlock
            // 
            this.lblCplBlock.AutoSize = true;
            this.lblCplBlock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplBlock.Location = new System.Drawing.Point(37, 263);
            this.lblCplBlock.Name = "lblCplBlock";
            this.lblCplBlock.Size = new System.Drawing.Size(141, 16);
            this.lblCplBlock.TabIndex = 2;
            this.lblCplBlock.Text = "Блокировка вращения";
            // 
            // lblCplHeater
            // 
            this.lblCplHeater.AutoSize = true;
            this.lblCplHeater.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplHeater.Location = new System.Drawing.Point(37, 241);
            this.lblCplHeater.Name = "lblCplHeater";
            this.lblCplHeater.Size = new System.Drawing.Size(122, 16);
            this.lblCplHeater.TabIndex = 2;
            this.lblCplHeater.Text = "Система подогрева";
            // 
            // lblCplBrake
            // 
            this.lblCplBrake.AutoSize = true;
            this.lblCplBrake.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCplBrake.Location = new System.Drawing.Point(37, 219);
            this.lblCplBrake.Name = "lblCplBrake";
            this.lblCplBrake.Size = new System.Drawing.Size(134, 16);
            this.lblCplBrake.TabIndex = 2;
            this.lblCplBrake.Text = "Система торможения";
            // 
            // pnlEnvironment
            // 
            this.pnlEnvironment.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEnvironment.Location = new System.Drawing.Point(1, 323);
            this.pnlEnvironment.Name = "pnlEnvironment";
            this.pnlEnvironment.Size = new System.Drawing.Size(839, 131);
            this.pnlEnvironment.TabIndex = 0;
            // 
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Interval = 50;
            this.tmrUpdateUI.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBrakeSystem
            // 
            this.lblBrakeSystem.AutoSize = true;
            this.lblBrakeSystem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrakeSystem.Location = new System.Drawing.Point(14, 142);
            this.lblBrakeSystem.Name = "lblBrakeSystem";
            this.lblBrakeSystem.Size = new System.Drawing.Size(134, 16);
            this.lblBrakeSystem.TabIndex = 2;
            this.lblBrakeSystem.Text = "Система торможения";
            // 
            // lblHeater
            // 
            this.lblHeater.AutoSize = true;
            this.lblHeater.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater.Location = new System.Drawing.Point(22, 243);
            this.lblHeater.Name = "lblHeater";
            this.lblHeater.Size = new System.Drawing.Size(122, 16);
            this.lblHeater.TabIndex = 2;
            this.lblHeater.Text = "Система подогрева";
            // 
            // lblFireSystem
            // 
            this.lblFireSystem.AutoSize = true;
            this.lblFireSystem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFireSystem.Location = new System.Drawing.Point(423, 53);
            this.lblFireSystem.Name = "lblFireSystem";
            this.lblFireSystem.Size = new System.Drawing.Size(156, 16);
            this.lblFireSystem.TabIndex = 2;
            this.lblFireSystem.Text = "Система пожаротушения";
            // 
            // lblRotorSpeed
            // 
            this.lblRotorSpeed.AutoSize = true;
            this.lblRotorSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotorSpeed.Location = new System.Drawing.Point(137, 74);
            this.lblRotorSpeed.Name = "lblRotorSpeed";
            this.lblRotorSpeed.Size = new System.Drawing.Size(169, 16);
            this.lblRotorSpeed.TabIndex = 2;
            this.lblRotorSpeed.Text = "ω = 120 оборотов в минуту";
            // 
            // lblOutdoorTemp
            // 
            this.lblOutdoorTemp.AutoSize = true;
            this.lblOutdoorTemp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutdoorTemp.Location = new System.Drawing.Point(82, 215);
            this.lblOutdoorTemp.Name = "lblOutdoorTemp";
            this.lblOutdoorTemp.Size = new System.Drawing.Size(61, 16);
            this.lblOutdoorTemp.TabIndex = 2;
            this.lblOutdoorTemp.Text = "t = 12 °C";
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindDirection.Location = new System.Drawing.Point(5, 9);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(129, 16);
            this.lblWindDirection.TabIndex = 2;
            this.lblWindDirection.Text = "Направление ветра:";
            // 
            // lblWindIntensity
            // 
            this.lblWindIntensity.AutoSize = true;
            this.lblWindIntensity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindIntensity.Location = new System.Drawing.Point(5, 25);
            this.lblWindIntensity.Name = "lblWindIntensity";
            this.lblWindIntensity.Size = new System.Drawing.Size(105, 16);
            this.lblWindIntensity.TabIndex = 2;
            this.lblWindIntensity.Text = "Скорость ветра:";
            // 
            // lblValueWindIntensity
            // 
            this.lblValueWindIntensity.AutoSize = true;
            this.lblValueWindIntensity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueWindIntensity.Location = new System.Drawing.Point(141, 25);
            this.lblValueWindIntensity.Name = "lblValueWindIntensity";
            this.lblValueWindIntensity.Size = new System.Drawing.Size(45, 16);
            this.lblValueWindIntensity.TabIndex = 2;
            this.lblValueWindIntensity.Text = "12 м/с";
            // 
            // lblValueWindDirection
            // 
            this.lblValueWindDirection.AutoSize = true;
            this.lblValueWindDirection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueWindDirection.Location = new System.Drawing.Point(141, 9);
            this.lblValueWindDirection.Name = "lblValueWindDirection";
            this.lblValueWindDirection.Size = new System.Drawing.Size(36, 16);
            this.lblValueWindDirection.TabIndex = 2;
            this.lblValueWindDirection.Text = "NNW";
            // 
            // lblRotor
            // 
            this.lblRotor.AutoSize = true;
            this.lblRotor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotor.Location = new System.Drawing.Point(116, 292);
            this.lblRotor.Name = "lblRotor";
            this.lblRotor.Size = new System.Drawing.Size(127, 19);
            this.lblRotor.TabIndex = 2;
            this.lblRotor.Text = "Ветротурбина";
            // 
            // lblGenerator
            // 
            this.lblGenerator.AutoSize = true;
            this.lblGenerator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerator.Location = new System.Drawing.Point(402, 292);
            this.lblGenerator.Name = "lblGenerator";
            this.lblGenerator.Size = new System.Drawing.Size(166, 19);
            this.lblGenerator.TabIndex = 2;
            this.lblGenerator.Text = "Электрогенератор";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackgroundImage = global::WFSystem.Properties.Resources.splitter;
            this.pnlSplitter.Location = new System.Drawing.Point(596, 47);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(3, 256);
            this.pnlSplitter.TabIndex = 1;
            // 
            // pnlIndHeater
            // 
            this.pnlIndHeater.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive;
            this.pnlIndHeater.Location = new System.Drawing.Point(150, 227);
            this.pnlIndHeater.Name = "pnlIndHeater";
            this.pnlIndHeater.Size = new System.Drawing.Size(32, 32);
            this.pnlIndHeater.TabIndex = 3;
            // 
            // pnlIndBrake
            // 
            this.pnlIndBrake.BackgroundImage = global::WFSystem.Properties.Resources.systeminactive;
            this.pnlIndBrake.Location = new System.Drawing.Point(95, 107);
            this.pnlIndBrake.Name = "pnlIndBrake";
            this.pnlIndBrake.Size = new System.Drawing.Size(32, 32);
            this.pnlIndBrake.TabIndex = 3;
            // 
            // pnlGenerator
            // 
            this.pnlGenerator.BackgroundImage = global::WFSystem.Properties.Resources.generator;
            this.pnlGenerator.Location = new System.Drawing.Point(382, 143);
            this.pnlGenerator.Name = "pnlGenerator";
            this.pnlGenerator.Size = new System.Drawing.Size(128, 128);
            this.pnlGenerator.TabIndex = 1;
            // 
            // lblGeneratorTemp
            // 
            this.lblGeneratorTemp.AutoSize = true;
            this.lblGeneratorTemp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratorTemp.Location = new System.Drawing.Point(451, 255);
            this.lblGeneratorTemp.Name = "lblGeneratorTemp";
            this.lblGeneratorTemp.Size = new System.Drawing.Size(68, 16);
            this.lblGeneratorTemp.TabIndex = 2;
            this.lblGeneratorTemp.Text = "t = 180 °C";
            // 
            // pnlWater
            // 
            this.pnlWater.BackgroundImage = global::WFSystem.Properties.Resources.water3;
            this.pnlWater.Location = new System.Drawing.Point(382, 44);
            this.pnlWater.Name = "pnlWater";
            this.pnlWater.Size = new System.Drawing.Size(128, 128);
            this.pnlWater.TabIndex = 1;
            // 
            // pnlRotor
            // 
            this.pnlRotor.BackgroundImage = global::WFSystem.Properties.Resources.blade0;
            this.pnlRotor.Location = new System.Drawing.Point(133, 96);
            this.pnlRotor.Name = "pnlRotor";
            this.pnlRotor.Size = new System.Drawing.Size(128, 128);
            this.pnlRotor.TabIndex = 1;
            // 
            // pnlCord
            // 
            this.pnlCord.BackgroundImage = global::WFSystem.Properties.Resources.Connection;
            this.pnlCord.Location = new System.Drawing.Point(163, 47);
            this.pnlCord.Name = "pnlCord";
            this.pnlCord.Size = new System.Drawing.Size(256, 256);
            this.pnlCord.TabIndex = 1;
            // 
            // WinderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(841, 465);
            this.Controls.Add(this.lblGeneratorTemp);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.lblOutdoorTemp);
            this.Controls.Add(this.lblFireSystem);
            this.Controls.Add(this.pnlIndHeater);
            this.Controls.Add(this.pnlIndBrake);
            this.Controls.Add(this.lblGenerator);
            this.Controls.Add(this.lblRotor);
            this.Controls.Add(this.lblHeater);
            this.Controls.Add(this.lblRotorSpeed);
            this.Controls.Add(this.lblValueWindDirection);
            this.Controls.Add(this.lblValueWindIntensity);
            this.Controls.Add(this.lblWindIntensity);
            this.Controls.Add(this.lblWindDirection);
            this.Controls.Add(this.lblBrakeSystem);
            this.Controls.Add(this.pnlGenerator);
            this.Controls.Add(this.pnlWater);
            this.Controls.Add(this.pnlRotor);
            this.Controls.Add(this.pnlEnvironment);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlCord);
            this.Name = "WinderMain";
            this.Text = "Form1";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatRose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlEnvironment;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private System.Windows.Forms.Panel pnlRotor;
        private System.Windows.Forms.Panel pnlGenerator;
        private System.Windows.Forms.Panel pnlWater;
        private System.Windows.Forms.Label lblBrakeSystem;
        private System.Windows.Forms.Panel pnlIndBrake;
        private System.Windows.Forms.Label lblHeater;
        private System.Windows.Forms.Panel pnlCord;
        private System.Windows.Forms.Label lblGeneratorTemp;
        private System.Windows.Forms.Label lblFireSystem;
        private System.Windows.Forms.Label lblRotorSpeed;
        private System.Windows.Forms.Label lblOutdoorTemp;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label lblWindIntensity;
        private System.Windows.Forms.Label lblValueWindIntensity;
        private System.Windows.Forms.Label lblValueWindDirection;
        private System.Windows.Forms.Panel pnlIndHeater;
        private System.Windows.Forms.Label lblRotor;
        private System.Windows.Forms.Label lblGenerator;
        private System.Windows.Forms.Panel pnlCplBrake;
        private System.Windows.Forms.Panel pnlCplFire;
        private System.Windows.Forms.Label lblControlPanel;
        private System.Windows.Forms.Panel pnlCplHeater;
        private System.Windows.Forms.PictureBox pbxStatRose;
        private System.Windows.Forms.Label lblCplFire;
        private System.Windows.Forms.Panel pnlCplGenOff;
        private System.Windows.Forms.Panel pnlCplBlock;
        private System.Windows.Forms.Label lblCplGenOff;
        private System.Windows.Forms.Label lblCplBlock;
        private System.Windows.Forms.Label lblCplHeater;
        private System.Windows.Forms.Label lblCplBrake;
        private System.Windows.Forms.Panel pnlSplitter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox pbxStatGraph;

    }
}

