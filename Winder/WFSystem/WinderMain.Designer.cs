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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinderMain));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblStatIntensity = new System.Windows.Forms.Label();
            this.lblStatDir = new System.Windows.Forms.Label();
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
            this.btnModelStartStop = new System.Windows.Forms.Button();
            this.gbxBad = new System.Windows.Forms.GroupBox();
            this.btnModelFire = new System.Windows.Forms.Button();
            this.btnTornado = new System.Windows.Forms.Button();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.gbxWind = new System.Windows.Forms.GroupBox();
            this.rbnSE = new System.Windows.Forms.RadioButton();
            this.rbnE = new System.Windows.Forms.RadioButton();
            this.rbnNE = new System.Windows.Forms.RadioButton();
            this.rbnS = new System.Windows.Forms.RadioButton();
            this.rbnSW = new System.Windows.Forms.RadioButton();
            this.rbnW = new System.Windows.Forms.RadioButton();
            this.rbnN = new System.Windows.Forms.RadioButton();
            this.rbnNW = new System.Windows.Forms.RadioButton();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblMeterSeconds = new System.Windows.Forms.Label();
            this.numWind = new System.Windows.Forms.NumericUpDown();
            this.lblModel = new System.Windows.Forms.Label();
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
            this.pnlEnvironment.SuspendLayout();
            this.gbxBad.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            this.gbxWind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWind)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlControl.Controls.Add(this.lblStatIntensity);
            this.pnlControl.Controls.Add(this.lblStatDir);
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
            // lblStatIntensity
            // 
            this.lblStatIntensity.AutoSize = true;
            this.lblStatIntensity.BackColor = System.Drawing.SystemColors.Menu;
            this.lblStatIntensity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatIntensity.Location = new System.Drawing.Point(116, 151);
            this.lblStatIntensity.Name = "lblStatIntensity";
            this.lblStatIntensity.Size = new System.Drawing.Size(63, 19);
            this.lblStatIntensity.TabIndex = 2;
            this.lblStatIntensity.Text = "12 м/с";
            // 
            // lblStatDir
            // 
            this.lblStatDir.AutoSize = true;
            this.lblStatDir.BackColor = System.Drawing.SystemColors.Menu;
            this.lblStatDir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatDir.Location = new System.Drawing.Point(35, 151);
            this.lblStatDir.Name = "lblStatDir";
            this.lblStatDir.Size = new System.Drawing.Size(21, 19);
            this.lblStatDir.TabIndex = 2;
            this.lblStatDir.Text = "N";
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
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
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
            this.pnlCplGenOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCplGenOff.BackgroundImage")));
            this.pnlCplGenOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplGenOff.Location = new System.Drawing.Point(15, 285);
            this.pnlCplGenOff.Name = "pnlCplGenOff";
            this.pnlCplGenOff.Size = new System.Drawing.Size(16, 16);
            this.pnlCplGenOff.TabIndex = 3;
            // 
            // pnlCplBlock
            // 
            this.pnlCplBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCplBlock.BackgroundImage")));
            this.pnlCplBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplBlock.Location = new System.Drawing.Point(15, 263);
            this.pnlCplBlock.Name = "pnlCplBlock";
            this.pnlCplBlock.Size = new System.Drawing.Size(16, 16);
            this.pnlCplBlock.TabIndex = 3;
            // 
            // pnlCplHeater
            // 
            this.pnlCplHeater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCplHeater.BackgroundImage")));
            this.pnlCplHeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplHeater.Location = new System.Drawing.Point(15, 241);
            this.pnlCplHeater.Name = "pnlCplHeater";
            this.pnlCplHeater.Size = new System.Drawing.Size(16, 16);
            this.pnlCplHeater.TabIndex = 3;
            // 
            // pnlCplBrake
            // 
            this.pnlCplBrake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCplBrake.BackgroundImage")));
            this.pnlCplBrake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCplBrake.Location = new System.Drawing.Point(15, 219);
            this.pnlCplBrake.Name = "pnlCplBrake";
            this.pnlCplBrake.Size = new System.Drawing.Size(16, 16);
            this.pnlCplBrake.TabIndex = 3;
            // 
            // pnlCplFire
            // 
            this.pnlCplFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCplFire.BackgroundImage")));
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
            this.pnlEnvironment.Controls.Add(this.btnModelStartStop);
            this.pnlEnvironment.Controls.Add(this.gbxBad);
            this.pnlEnvironment.Controls.Add(this.gbxTemp);
            this.pnlEnvironment.Controls.Add(this.gbxWind);
            this.pnlEnvironment.Controls.Add(this.lblModel);
            this.pnlEnvironment.Location = new System.Drawing.Point(1, 323);
            this.pnlEnvironment.Name = "pnlEnvironment";
            this.pnlEnvironment.Size = new System.Drawing.Size(839, 196);
            this.pnlEnvironment.TabIndex = 0;
            // 
            // btnModelStartStop
            // 
            this.btnModelStartStop.Location = new System.Drawing.Point(696, 152);
            this.btnModelStartStop.Name = "btnModelStartStop";
            this.btnModelStartStop.Size = new System.Drawing.Size(136, 40);
            this.btnModelStartStop.TabIndex = 4;
            this.btnModelStartStop.Text = "Старт!";
            this.btnModelStartStop.UseVisualStyleBackColor = true;
            this.btnModelStartStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbxBad
            // 
            this.gbxBad.Controls.Add(this.btnModelFire);
            this.gbxBad.Controls.Add(this.btnTornado);
            this.gbxBad.Location = new System.Drawing.Point(187, 101);
            this.gbxBad.Name = "gbxBad";
            this.gbxBad.Size = new System.Drawing.Size(134, 87);
            this.gbxBad.TabIndex = 3;
            this.gbxBad.TabStop = false;
            this.gbxBad.Text = "Аварийные ситуации";
            // 
            // btnModelFire
            // 
            this.btnModelFire.BackColor = System.Drawing.Color.Red;
            this.btnModelFire.Location = new System.Drawing.Point(25, 54);
            this.btnModelFire.Name = "btnModelFire";
            this.btnModelFire.Size = new System.Drawing.Size(95, 28);
            this.btnModelFire.TabIndex = 5;
            this.btnModelFire.Text = "ПОЖАР";
            this.btnModelFire.UseVisualStyleBackColor = false;
            this.btnModelFire.Click += new System.EventHandler(this.btnModelFire_Click);
            // 
            // btnTornado
            // 
            this.btnTornado.BackColor = System.Drawing.Color.Red;
            this.btnTornado.Location = new System.Drawing.Point(25, 24);
            this.btnTornado.Name = "btnTornado";
            this.btnTornado.Size = new System.Drawing.Size(95, 28);
            this.btnTornado.TabIndex = 5;
            this.btnTornado.Text = "УРАГАН";
            this.btnTornado.UseVisualStyleBackColor = false;
            this.btnTornado.Click += new System.EventHandler(this.btnTornado_Click);
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.lblCelsius);
            this.gbxTemp.Controls.Add(this.numTemp);
            this.gbxTemp.Location = new System.Drawing.Point(187, 45);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(134, 50);
            this.gbxTemp.TabIndex = 3;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "Температура";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(102, 21);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(18, 13);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "°C";
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(17, 19);
            this.numTemp.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTemp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(79, 20);
            this.numTemp.TabIndex = 0;
            this.numTemp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTemp.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // gbxWind
            // 
            this.gbxWind.Controls.Add(this.rbnSE);
            this.gbxWind.Controls.Add(this.rbnE);
            this.gbxWind.Controls.Add(this.rbnNE);
            this.gbxWind.Controls.Add(this.rbnS);
            this.gbxWind.Controls.Add(this.rbnSW);
            this.gbxWind.Controls.Add(this.rbnW);
            this.gbxWind.Controls.Add(this.rbnN);
            this.gbxWind.Controls.Add(this.rbnNW);
            this.gbxWind.Controls.Add(this.lblDirections);
            this.gbxWind.Controls.Add(this.lblMeterSeconds);
            this.gbxWind.Controls.Add(this.numWind);
            this.gbxWind.Location = new System.Drawing.Point(24, 45);
            this.gbxWind.Name = "gbxWind";
            this.gbxWind.Size = new System.Drawing.Size(157, 143);
            this.gbxWind.TabIndex = 3;
            this.gbxWind.TabStop = false;
            this.gbxWind.Text = "Ветер";
            // 
            // rbnSE
            // 
            this.rbnSE.AutoSize = true;
            this.rbnSE.Location = new System.Drawing.Point(102, 119);
            this.rbnSE.Name = "rbnSE";
            this.rbnSE.Size = new System.Drawing.Size(39, 17);
            this.rbnSE.TabIndex = 2;
            this.rbnSE.Text = "SE";
            this.rbnSE.UseVisualStyleBackColor = true;
            this.rbnSE.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnE
            // 
            this.rbnE.AutoSize = true;
            this.rbnE.Location = new System.Drawing.Point(102, 96);
            this.rbnE.Name = "rbnE";
            this.rbnE.Size = new System.Drawing.Size(32, 17);
            this.rbnE.TabIndex = 2;
            this.rbnE.Text = "E";
            this.rbnE.UseVisualStyleBackColor = true;
            this.rbnE.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnNE
            // 
            this.rbnNE.AutoSize = true;
            this.rbnNE.Location = new System.Drawing.Point(102, 73);
            this.rbnNE.Name = "rbnNE";
            this.rbnNE.Size = new System.Drawing.Size(40, 17);
            this.rbnNE.TabIndex = 2;
            this.rbnNE.Text = "NE";
            this.rbnNE.UseVisualStyleBackColor = true;
            this.rbnNE.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnS
            // 
            this.rbnS.AutoSize = true;
            this.rbnS.Location = new System.Drawing.Point(60, 119);
            this.rbnS.Name = "rbnS";
            this.rbnS.Size = new System.Drawing.Size(32, 17);
            this.rbnS.TabIndex = 2;
            this.rbnS.Text = "S";
            this.rbnS.UseVisualStyleBackColor = true;
            this.rbnS.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnSW
            // 
            this.rbnSW.AutoSize = true;
            this.rbnSW.Location = new System.Drawing.Point(9, 119);
            this.rbnSW.Name = "rbnSW";
            this.rbnSW.Size = new System.Drawing.Size(43, 17);
            this.rbnSW.TabIndex = 2;
            this.rbnSW.Text = "SW";
            this.rbnSW.UseVisualStyleBackColor = true;
            this.rbnSW.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnW
            // 
            this.rbnW.AutoSize = true;
            this.rbnW.Location = new System.Drawing.Point(9, 96);
            this.rbnW.Name = "rbnW";
            this.rbnW.Size = new System.Drawing.Size(36, 17);
            this.rbnW.TabIndex = 2;
            this.rbnW.Text = "W";
            this.rbnW.UseVisualStyleBackColor = true;
            this.rbnW.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnN
            // 
            this.rbnN.AutoSize = true;
            this.rbnN.Checked = true;
            this.rbnN.Location = new System.Drawing.Point(60, 73);
            this.rbnN.Name = "rbnN";
            this.rbnN.Size = new System.Drawing.Size(33, 17);
            this.rbnN.TabIndex = 2;
            this.rbnN.TabStop = true;
            this.rbnN.Text = "N";
            this.rbnN.UseVisualStyleBackColor = true;
            this.rbnN.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // rbnNW
            // 
            this.rbnNW.AutoSize = true;
            this.rbnNW.Location = new System.Drawing.Point(9, 73);
            this.rbnNW.Name = "rbnNW";
            this.rbnNW.Size = new System.Drawing.Size(44, 17);
            this.rbnNW.TabIndex = 2;
            this.rbnNW.Text = "NW";
            this.rbnNW.UseVisualStyleBackColor = true;
            this.rbnNW.CheckedChanged += new System.EventHandler(this.rbnN_CheckedChanged);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(6, 50);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(78, 13);
            this.lblDirections.TabIndex = 1;
            this.lblDirections.Text = "Направление:";
            // 
            // lblMeterSeconds
            // 
            this.lblMeterSeconds.AutoSize = true;
            this.lblMeterSeconds.Location = new System.Drawing.Point(98, 21);
            this.lblMeterSeconds.Name = "lblMeterSeconds";
            this.lblMeterSeconds.Size = new System.Drawing.Size(26, 13);
            this.lblMeterSeconds.TabIndex = 1;
            this.lblMeterSeconds.Text = "м/с";
            // 
            // numWind
            // 
            this.numWind.Location = new System.Drawing.Point(6, 19);
            this.numWind.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWind.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWind.Name = "numWind";
            this.numWind.Size = new System.Drawing.Size(79, 20);
            this.numWind.TabIndex = 0;
            this.numWind.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWind.ValueChanged += new System.EventHandler(this.numWind_ValueChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(16, 11);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(144, 19);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Моделирование";
            // 
            // tmrUpdateUI
            // 
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
            this.pnlSplitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSplitter.BackgroundImage")));
            this.pnlSplitter.Location = new System.Drawing.Point(596, 47);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(3, 256);
            this.pnlSplitter.TabIndex = 1;
            // 
            // pnlIndHeater
            // 
            this.pnlIndHeater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIndHeater.BackgroundImage")));
            this.pnlIndHeater.Location = new System.Drawing.Point(150, 227);
            this.pnlIndHeater.Name = "pnlIndHeater";
            this.pnlIndHeater.Size = new System.Drawing.Size(32, 32);
            this.pnlIndHeater.TabIndex = 3;
            // 
            // pnlIndBrake
            // 
            this.pnlIndBrake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIndBrake.BackgroundImage")));
            this.pnlIndBrake.Location = new System.Drawing.Point(95, 107);
            this.pnlIndBrake.Name = "pnlIndBrake";
            this.pnlIndBrake.Size = new System.Drawing.Size(32, 32);
            this.pnlIndBrake.TabIndex = 3;
            // 
            // pnlGenerator
            // 
            this.pnlGenerator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGenerator.BackgroundImage")));
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
            this.lblGeneratorTemp.DoubleClick += new System.EventHandler(this.lblGeneratorTemp_DoubleClick);
            // 
            // pnlWater
            // 
            this.pnlWater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWater.BackgroundImage")));
            this.pnlWater.Location = new System.Drawing.Point(382, 44);
            this.pnlWater.Name = "pnlWater";
            this.pnlWater.Size = new System.Drawing.Size(128, 128);
            this.pnlWater.TabIndex = 1;
            // 
            // pnlRotor
            // 
            this.pnlRotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRotor.BackgroundImage")));
            this.pnlRotor.Location = new System.Drawing.Point(133, 96);
            this.pnlRotor.Name = "pnlRotor";
            this.pnlRotor.Size = new System.Drawing.Size(128, 128);
            this.pnlRotor.TabIndex = 1;
            // 
            // pnlCord
            // 
            this.pnlCord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCord.BackgroundImage")));
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
            this.ClientSize = new System.Drawing.Size(841, 519);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WinderMain";
            this.Text = "Ветрогенератор";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatRose)).EndInit();
            this.pnlEnvironment.ResumeLayout(false);
            this.pnlEnvironment.PerformLayout();
            this.gbxBad.ResumeLayout(false);
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            this.gbxWind.ResumeLayout(false);
            this.gbxWind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWind)).EndInit();
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
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.GroupBox gbxWind;
        private System.Windows.Forms.Button btnModelFire;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.RadioButton rbnSE;
        private System.Windows.Forms.RadioButton rbnE;
        private System.Windows.Forms.RadioButton rbnNE;
        private System.Windows.Forms.RadioButton rbnS;
        private System.Windows.Forms.RadioButton rbnSW;
        private System.Windows.Forms.RadioButton rbnW;
        private System.Windows.Forms.RadioButton rbnN;
        private System.Windows.Forms.RadioButton rbnNW;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblMeterSeconds;
        private System.Windows.Forms.NumericUpDown numWind;
        private System.Windows.Forms.Button btnModelStartStop;
        private System.Windows.Forms.GroupBox gbxBad;
        private System.Windows.Forms.Button btnTornado;
        private System.Windows.Forms.Label lblStatIntensity;
        private System.Windows.Forms.Label lblStatDir;

    }
}

