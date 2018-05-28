namespace BluetoothGUISample
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bluetooth = new System.IO.Ports.SerialPort(this.components);
            this.getIOtimer = new System.Windows.Forms.Timer(this.components);
            this.NextPos = new System.Windows.Forms.NumericUpDown();
            this.PosButton = new System.Windows.Forms.Button();
            this.VelButton = new System.Windows.Forms.Button();
            this.NextVel = new System.Windows.Forms.NumericUpDown();
            this.NextAcc = new System.Windows.Forms.NumericUpDown();
            this.AccButton = new System.Windows.Forms.Button();
            this.PosRad = new System.Windows.Forms.TextBox();
            this.VelRad = new System.Windows.Forms.TextBox();
            this.AccRad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccelGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BitValue1 = new System.Windows.Forms.NumericUpDown();
            this.Troubleshooting = new System.Windows.Forms.GroupBox();
            this.TotalTicksLabel = new System.Windows.Forms.Label();
            this.DeadbandBox = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalTicksBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PID_Control = new System.Windows.Forms.GroupBox();
            this.AccRadio = new System.Windows.Forms.RadioButton();
            this.VelRadio = new System.Windows.Forms.RadioButton();
            this.PosRadio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Current_readings = new System.Windows.Forms.GroupBox();
            this.VelCount = new System.Windows.Forms.TextBox();
            this.AccCount = new System.Windows.Forms.TextBox();
            this.PosCount = new System.Windows.Forms.TextBox();
            this.VelDeg = new System.Windows.Forms.TextBox();
            this.AccDeg = new System.Windows.Forms.TextBox();
            this.PosDeg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OLSpeedRoll = new System.Windows.Forms.NumericUpDown();
            this.OLSpeedSlide = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KPRoll = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.KIButt = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.KIRoll = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.KPButt = new System.Windows.Forms.Button();
            this.KDButt = new System.Windows.Forms.Button();
            this.KdRoll = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitValue1)).BeginInit();
            this.Troubleshooting.SuspendLayout();
            this.PID_Control.SuspendLayout();
            this.Current_readings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLSpeedRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLSpeedSlide)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KPRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // bluetooth
            // 
            this.bluetooth.PortName = "COM4";
            // 
            // getIOtimer
            // 
            this.getIOtimer.Enabled = true;
            this.getIOtimer.Interval = 40;
            this.getIOtimer.Tick += new System.EventHandler(this.getIOtimer_Tick);
            // 
            // NextPos
            // 
            this.NextPos.Location = new System.Drawing.Point(182, 71);
            this.NextPos.Margin = new System.Windows.Forms.Padding(6);
            this.NextPos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NextPos.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.NextPos.Name = "NextPos";
            this.NextPos.Size = new System.Drawing.Size(238, 31);
            this.NextPos.TabIndex = 3;
            // 
            // PosButton
            // 
            this.PosButton.Location = new System.Drawing.Point(468, 71);
            this.PosButton.Margin = new System.Windows.Forms.Padding(6);
            this.PosButton.Name = "PosButton";
            this.PosButton.Size = new System.Drawing.Size(232, 44);
            this.PosButton.TabIndex = 4;
            this.PosButton.Text = "Change Position";
            this.PosButton.UseVisualStyleBackColor = true;
            this.PosButton.Click += new System.EventHandler(this.PosButton_Click_1);
            // 
            // VelButton
            // 
            this.VelButton.Location = new System.Drawing.Point(468, 165);
            this.VelButton.Margin = new System.Windows.Forms.Padding(6);
            this.VelButton.Name = "VelButton";
            this.VelButton.Size = new System.Drawing.Size(232, 44);
            this.VelButton.TabIndex = 4;
            this.VelButton.Text = "Change Velocity";
            this.VelButton.UseVisualStyleBackColor = true;
            this.VelButton.Click += new System.EventHandler(this.VelButton_Click_1);
            // 
            // NextVel
            // 
            this.NextVel.Location = new System.Drawing.Point(178, 175);
            this.NextVel.Margin = new System.Windows.Forms.Padding(6);
            this.NextVel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NextVel.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NextVel.Name = "NextVel";
            this.NextVel.Size = new System.Drawing.Size(250, 31);
            this.NextVel.TabIndex = 3;
            // 
            // NextAcc
            // 
            this.NextAcc.Location = new System.Drawing.Point(178, 271);
            this.NextAcc.Margin = new System.Windows.Forms.Padding(4);
            this.NextAcc.Name = "NextAcc";
            this.NextAcc.Size = new System.Drawing.Size(250, 31);
            this.NextAcc.TabIndex = 5;
            // 
            // AccButton
            // 
            this.AccButton.Location = new System.Drawing.Point(468, 262);
            this.AccButton.Margin = new System.Windows.Forms.Padding(4);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(232, 44);
            this.AccButton.TabIndex = 6;
            this.AccButton.Text = "Change Acceleration";
            this.AccButton.UseVisualStyleBackColor = true;
            this.AccButton.Click += new System.EventHandler(this.AccButton_Click_1);
            // 
            // PosRad
            // 
            this.PosRad.Location = new System.Drawing.Point(26, 98);
            this.PosRad.Margin = new System.Windows.Forms.Padding(4);
            this.PosRad.Name = "PosRad";
            this.PosRad.Size = new System.Drawing.Size(104, 31);
            this.PosRad.TabIndex = 7;
            // 
            // VelRad
            // 
            this.VelRad.Location = new System.Drawing.Point(26, 177);
            this.VelRad.Margin = new System.Windows.Forms.Padding(4);
            this.VelRad.Name = "VelRad";
            this.VelRad.Size = new System.Drawing.Size(100, 31);
            this.VelRad.TabIndex = 8;
            // 
            // AccRad
            // 
            this.AccRad.Location = new System.Drawing.Point(26, 256);
            this.AccRad.Margin = new System.Windows.Forms.Padding(4);
            this.AccRad.Name = "AccRad";
            this.AccRad.Size = new System.Drawing.Size(100, 31);
            this.AccRad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Acceleration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Next Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next Velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Next Acceleration";
            // 
            // PositionGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.PositionGraph.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.PositionGraph.Legends.Add(legend4);
            this.PositionGraph.Location = new System.Drawing.Point(836, 40);
            this.PositionGraph.Margin = new System.Windows.Forms.Padding(4);
            this.PositionGraph.Name = "PositionGraph";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.PositionGraph.Series.Add(series4);
            this.PositionGraph.Size = new System.Drawing.Size(1298, 404);
            this.PositionGraph.TabIndex = 16;
            this.PositionGraph.Text = "chart1";
            // 
            // AccelGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.AccelGraph.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.AccelGraph.Legends.Add(legend5);
            this.AccelGraph.Location = new System.Drawing.Point(836, 977);
            this.AccelGraph.Margin = new System.Windows.Forms.Padding(1, 4, 4, 4);
            this.AccelGraph.Name = "AccelGraph";
            series5.BorderWidth = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.AccelGraph.Series.Add(series5);
            this.AccelGraph.Size = new System.Drawing.Size(1298, 425);
            this.AccelGraph.TabIndex = 17;
            this.AccelGraph.Text = "chart2";
            // 
            // VelGraph
            // 
            chartArea6.Name = "ChartArea1";
            this.VelGraph.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.VelGraph.Legends.Add(legend6);
            this.VelGraph.Location = new System.Drawing.Point(836, 494);
            this.VelGraph.Margin = new System.Windows.Forms.Padding(4);
            this.VelGraph.Name = "VelGraph";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.VelGraph.Series.Add(series6);
            this.VelGraph.Size = new System.Drawing.Size(1298, 415);
            this.VelGraph.TabIndex = 18;
            this.VelGraph.Text = "chart3";
            // 
            // BitValue1
            // 
            this.BitValue1.Location = new System.Drawing.Point(14, 69);
            this.BitValue1.Margin = new System.Windows.Forms.Padding(4);
            this.BitValue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BitValue1.Name = "BitValue1";
            this.BitValue1.Size = new System.Drawing.Size(152, 31);
            this.BitValue1.TabIndex = 19;
            // 
            // Troubleshooting
            // 
            this.Troubleshooting.Controls.Add(this.TotalTicksLabel);
            this.Troubleshooting.Controls.Add(this.DeadbandBox);
            this.Troubleshooting.Controls.Add(this.textBox5);
            this.Troubleshooting.Controls.Add(this.textBox4);
            this.Troubleshooting.Controls.Add(this.label8);
            this.Troubleshooting.Controls.Add(this.TotalTicksBox);
            this.Troubleshooting.Controls.Add(this.button2);
            this.Troubleshooting.Controls.Add(this.label7);
            this.Troubleshooting.Controls.Add(this.BitValue1);
            this.Troubleshooting.Location = new System.Drawing.Point(474, 140);
            this.Troubleshooting.Margin = new System.Windows.Forms.Padding(4);
            this.Troubleshooting.Name = "Troubleshooting";
            this.Troubleshooting.Padding = new System.Windows.Forms.Padding(4);
            this.Troubleshooting.Size = new System.Drawing.Size(346, 344);
            this.Troubleshooting.TabIndex = 21;
            this.Troubleshooting.TabStop = false;
            this.Troubleshooting.Text = "Troubleshooting";
            // 
            // TotalTicksLabel
            // 
            this.TotalTicksLabel.AutoSize = true;
            this.TotalTicksLabel.Location = new System.Drawing.Point(180, 150);
            this.TotalTicksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalTicksLabel.Name = "TotalTicksLabel";
            this.TotalTicksLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalTicksLabel.TabIndex = 27;
            this.TotalTicksLabel.Text = "Blank";
            // 
            // DeadbandBox
            // 
            this.DeadbandBox.AutoSize = true;
            this.DeadbandBox.Location = new System.Drawing.Point(24, 204);
            this.DeadbandBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeadbandBox.Name = "DeadbandBox";
            this.DeadbandBox.Size = new System.Drawing.Size(252, 29);
            this.DeadbandBox.TabIndex = 26;
            this.DeadbandBox.Text = "Deadband Removed?";
            this.DeadbandBox.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 242);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 31);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 244);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Ticks";
            // 
            // TotalTicksBox
            // 
            this.TotalTicksBox.Location = new System.Drawing.Point(24, 144);
            this.TotalTicksBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTicksBox.Name = "TotalTicksBox";
            this.TotalTicksBox.Size = new System.Drawing.Size(136, 31);
            this.TotalTicksBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bit Value Input";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2415, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No Control",
            "Manual Motor Speed",
            "Deadband Testing",
            "Positional Control"});
            this.comboBox1.Location = new System.Drawing.Point(32, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 33);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PID_Control
            // 
            this.PID_Control.Controls.Add(this.NextAcc);
            this.PID_Control.Controls.Add(this.AccRadio);
            this.PID_Control.Controls.Add(this.VelRadio);
            this.PID_Control.Controls.Add(this.PosRadio);
            this.PID_Control.Controls.Add(this.NextPos);
            this.PID_Control.Controls.Add(this.VelButton);
            this.PID_Control.Controls.Add(this.NextVel);
            this.PID_Control.Controls.Add(this.PosButton);
            this.PID_Control.Controls.Add(this.AccButton);
            this.PID_Control.Controls.Add(this.label6);
            this.PID_Control.Controls.Add(this.label5);
            this.PID_Control.Controls.Add(this.label4);
            this.PID_Control.Location = new System.Drawing.Point(32, 629);
            this.PID_Control.Margin = new System.Windows.Forms.Padding(4);
            this.PID_Control.Name = "PID_Control";
            this.PID_Control.Padding = new System.Windows.Forms.Padding(4);
            this.PID_Control.Size = new System.Drawing.Size(728, 313);
            this.PID_Control.TabIndex = 24;
            this.PID_Control.TabStop = false;
            this.PID_Control.Text = "PID_Control";
            // 
            // AccRadio
            // 
            this.AccRadio.AutoSize = true;
            this.AccRadio.Location = new System.Drawing.Point(16, 269);
            this.AccRadio.Margin = new System.Windows.Forms.Padding(6);
            this.AccRadio.Name = "AccRadio";
            this.AccRadio.Size = new System.Drawing.Size(162, 29);
            this.AccRadio.TabIndex = 18;
            this.AccRadio.TabStop = true;
            this.AccRadio.Text = "Acceleration";
            this.AccRadio.UseVisualStyleBackColor = true;
            this.AccRadio.CheckedChanged += new System.EventHandler(this.AccRadio_CheckedChanged);
            // 
            // VelRadio
            // 
            this.VelRadio.AutoSize = true;
            this.VelRadio.Location = new System.Drawing.Point(16, 173);
            this.VelRadio.Margin = new System.Windows.Forms.Padding(6);
            this.VelRadio.Name = "VelRadio";
            this.VelRadio.Size = new System.Drawing.Size(119, 29);
            this.VelRadio.TabIndex = 17;
            this.VelRadio.TabStop = true;
            this.VelRadio.Text = "Velocity";
            this.VelRadio.UseVisualStyleBackColor = true;
            this.VelRadio.CheckedChanged += new System.EventHandler(this.VelRadio_CheckedChanged);
            // 
            // PosRadio
            // 
            this.PosRadio.AutoSize = true;
            this.PosRadio.Location = new System.Drawing.Point(16, 77);
            this.PosRadio.Margin = new System.Windows.Forms.Padding(6);
            this.PosRadio.Name = "PosRadio";
            this.PosRadio.Size = new System.Drawing.Size(120, 29);
            this.PosRadio.TabIndex = 16;
            this.PosRadio.TabStop = true;
            this.PosRadio.Text = "Position";
            this.PosRadio.UseVisualStyleBackColor = true;
            this.PosRadio.CheckedChanged += new System.EventHandler(this.PosRadio_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Choose Mode";
            // 
            // Current_readings
            // 
            this.Current_readings.Controls.Add(this.VelCount);
            this.Current_readings.Controls.Add(this.AccCount);
            this.Current_readings.Controls.Add(this.PosCount);
            this.Current_readings.Controls.Add(this.VelDeg);
            this.Current_readings.Controls.Add(this.AccDeg);
            this.Current_readings.Controls.Add(this.PosDeg);
            this.Current_readings.Controls.Add(this.label12);
            this.Current_readings.Controls.Add(this.label11);
            this.Current_readings.Controls.Add(this.label10);
            this.Current_readings.Controls.Add(this.VelRad);
            this.Current_readings.Controls.Add(this.label2);
            this.Current_readings.Controls.Add(this.label1);
            this.Current_readings.Controls.Add(this.label3);
            this.Current_readings.Controls.Add(this.AccRad);
            this.Current_readings.Controls.Add(this.PosRad);
            this.Current_readings.Location = new System.Drawing.Point(32, 952);
            this.Current_readings.Margin = new System.Windows.Forms.Padding(6);
            this.Current_readings.Name = "Current_readings";
            this.Current_readings.Padding = new System.Windows.Forms.Padding(6);
            this.Current_readings.Size = new System.Drawing.Size(456, 313);
            this.Current_readings.TabIndex = 26;
            this.Current_readings.TabStop = false;
            this.Current_readings.Text = "Current_readings";
            // 
            // VelCount
            // 
            this.VelCount.Location = new System.Drawing.Point(300, 177);
            this.VelCount.Margin = new System.Windows.Forms.Padding(4);
            this.VelCount.Name = "VelCount";
            this.VelCount.Size = new System.Drawing.Size(100, 31);
            this.VelCount.TabIndex = 26;
            // 
            // AccCount
            // 
            this.AccCount.Location = new System.Drawing.Point(300, 256);
            this.AccCount.Margin = new System.Windows.Forms.Padding(4);
            this.AccCount.Name = "AccCount";
            this.AccCount.Size = new System.Drawing.Size(100, 31);
            this.AccCount.TabIndex = 27;
            // 
            // PosCount
            // 
            this.PosCount.Location = new System.Drawing.Point(300, 98);
            this.PosCount.Margin = new System.Windows.Forms.Padding(4);
            this.PosCount.Name = "PosCount";
            this.PosCount.Size = new System.Drawing.Size(104, 31);
            this.PosCount.TabIndex = 25;
            // 
            // VelDeg
            // 
            this.VelDeg.Location = new System.Drawing.Point(162, 177);
            this.VelDeg.Margin = new System.Windows.Forms.Padding(4);
            this.VelDeg.Name = "VelDeg";
            this.VelDeg.Size = new System.Drawing.Size(100, 31);
            this.VelDeg.TabIndex = 23;
            // 
            // AccDeg
            // 
            this.AccDeg.Location = new System.Drawing.Point(162, 256);
            this.AccDeg.Margin = new System.Windows.Forms.Padding(4);
            this.AccDeg.Name = "AccDeg";
            this.AccDeg.Size = new System.Drawing.Size(100, 31);
            this.AccDeg.TabIndex = 24;
            // 
            // PosDeg
            // 
            this.PosDeg.Location = new System.Drawing.Point(162, 98);
            this.PosDeg.Margin = new System.Windows.Forms.Padding(4);
            this.PosDeg.Name = "PosDeg";
            this.PosDeg.Size = new System.Drawing.Size(104, 31);
            this.PosDeg.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Counts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Deg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Rad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OLSpeedRoll);
            this.groupBox1.Controls.Add(this.OLSpeedSlide);
            this.groupBox1.Location = new System.Drawing.Point(32, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(410, 129);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Loop - Speed percentage";
            // 
            // OLSpeedRoll
            // 
            this.OLSpeedRoll.Location = new System.Drawing.Point(10, 56);
            this.OLSpeedRoll.Margin = new System.Windows.Forms.Padding(4);
            this.OLSpeedRoll.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OLSpeedRoll.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.OLSpeedRoll.Name = "OLSpeedRoll";
            this.OLSpeedRoll.Size = new System.Drawing.Size(152, 31);
            this.OLSpeedRoll.TabIndex = 28;
            this.OLSpeedRoll.ValueChanged += new System.EventHandler(this.OLSpeedRoll_ValueChanged);
            // 
            // OLSpeedSlide
            // 
            this.OLSpeedSlide.Location = new System.Drawing.Point(190, 33);
            this.OLSpeedSlide.Margin = new System.Windows.Forms.Padding(6);
            this.OLSpeedSlide.Maximum = 255;
            this.OLSpeedSlide.Name = "OLSpeedSlide";
            this.OLSpeedSlide.Size = new System.Drawing.Size(208, 90);
            this.OLSpeedSlide.TabIndex = 0;
            this.OLSpeedSlide.Scroll += new System.EventHandler(this.OLSpeedSlide_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KPRoll);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.KIButt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.KIRoll);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.KPButt);
            this.groupBox2.Controls.Add(this.KDButt);
            this.groupBox2.Controls.Add(this.KdRoll);
            this.groupBox2.Location = new System.Drawing.Point(32, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(410, 333);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID Coefficients";
            // 
            // KPRoll
            // 
            this.KPRoll.DecimalPlaces = 5;
            this.KPRoll.Location = new System.Drawing.Point(8, 56);
            this.KPRoll.Margin = new System.Windows.Forms.Padding(6);
            this.KPRoll.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KPRoll.Name = "KPRoll";
            this.KPRoll.Size = new System.Drawing.Size(134, 31);
            this.KPRoll.TabIndex = 16;
            this.KPRoll.ValueChanged += new System.EventHandler(this.KPRoll_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Kp";
            // 
            // KIButt
            // 
            this.KIButt.Location = new System.Drawing.Point(184, 146);
            this.KIButt.Margin = new System.Windows.Forms.Padding(6);
            this.KIButt.Name = "KIButt";
            this.KIButt.Size = new System.Drawing.Size(172, 44);
            this.KIButt.TabIndex = 18;
            this.KIButt.Text = "Change Ki";
            this.KIButt.UseVisualStyleBackColor = true;
            this.KIButt.Click += new System.EventHandler(this.KIButt_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 125);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ki";
            // 
            // KIRoll
            // 
            this.KIRoll.DecimalPlaces = 6;
            this.KIRoll.Location = new System.Drawing.Point(4, 156);
            this.KIRoll.Margin = new System.Windows.Forms.Padding(6);
            this.KIRoll.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KIRoll.Name = "KIRoll";
            this.KIRoll.Size = new System.Drawing.Size(142, 31);
            this.KIRoll.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 221);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Kd";
            // 
            // KPButt
            // 
            this.KPButt.Location = new System.Drawing.Point(184, 56);
            this.KPButt.Margin = new System.Windows.Forms.Padding(6);
            this.KPButt.Name = "KPButt";
            this.KPButt.Size = new System.Drawing.Size(172, 44);
            this.KPButt.TabIndex = 19;
            this.KPButt.Text = "Change Kp";
            this.KPButt.UseVisualStyleBackColor = true;
            this.KPButt.Click += new System.EventHandler(this.KPButt_Click);
            // 
            // KDButt
            // 
            this.KDButt.Location = new System.Drawing.Point(184, 242);
            this.KDButt.Margin = new System.Windows.Forms.Padding(4);
            this.KDButt.Name = "KDButt";
            this.KDButt.Size = new System.Drawing.Size(172, 44);
            this.KDButt.TabIndex = 21;
            this.KDButt.Text = "Change Kd";
            this.KDButt.UseVisualStyleBackColor = true;
            this.KDButt.Click += new System.EventHandler(this.KDButt_Click);
            // 
            // KdRoll
            // 
            this.KdRoll.DecimalPlaces = 5;
            this.KdRoll.Location = new System.Drawing.Point(4, 252);
            this.KdRoll.Margin = new System.Windows.Forms.Padding(4);
            this.KdRoll.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KdRoll.Name = "KdRoll";
            this.KdRoll.Size = new System.Drawing.Size(142, 31);
            this.KdRoll.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(836, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 25);
            this.label16.TabIndex = 29;
            this.label16.Text = "Displacement";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(836, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 25);
            this.label17.TabIndex = 30;
            this.label17.Text = "Velocity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(836, 945);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 25);
            this.label18.TabIndex = 31;
            this.label18.Text = "Acceleration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2415, 1404);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Current_readings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PID_Control);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Troubleshooting);
            this.Controls.Add(this.VelGraph);
            this.Controls.Add(this.AccelGraph);
            this.Controls.Add(this.PositionGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitValue1)).EndInit();
            this.Troubleshooting.ResumeLayout(false);
            this.Troubleshooting.PerformLayout();
            this.PID_Control.ResumeLayout(false);
            this.PID_Control.PerformLayout();
            this.Current_readings.ResumeLayout(false);
            this.Current_readings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLSpeedRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLSpeedSlide)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KPRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KIRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer getIOtimer;
        private System.Windows.Forms.NumericUpDown NextPos;
        private System.IO.Ports.SerialPort bluetooth;
        private System.Windows.Forms.Button PosButton;
        private System.Windows.Forms.Button VelButton;
        private System.Windows.Forms.NumericUpDown NextVel;
        private System.Windows.Forms.NumericUpDown NextAcc;
        private System.Windows.Forms.Button AccButton;
        private System.Windows.Forms.TextBox PosRad;
        private System.Windows.Forms.TextBox VelRad;
        private System.Windows.Forms.TextBox AccRad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart PositionGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart VelGraph;
        private System.Windows.Forms.NumericUpDown BitValue1;
        private System.Windows.Forms.GroupBox Troubleshooting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalTicksBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox DeadbandBox;
        private System.Windows.Forms.Label TotalTicksLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox PID_Control;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Current_readings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox VelCount;
        private System.Windows.Forms.TextBox AccCount;
        private System.Windows.Forms.TextBox PosCount;
        private System.Windows.Forms.TextBox VelDeg;
        private System.Windows.Forms.TextBox AccDeg;
        private System.Windows.Forms.TextBox PosDeg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown OLSpeedRoll;
        private System.Windows.Forms.TrackBar OLSpeedSlide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown KPRoll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button KIButt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown KIRoll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button KPButt;
        private System.Windows.Forms.Button KDButt;
        private System.Windows.Forms.NumericUpDown KdRoll;
        private System.Windows.Forms.RadioButton AccRadio;
        private System.Windows.Forms.RadioButton VelRadio;
        private System.Windows.Forms.RadioButton PosRadio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

