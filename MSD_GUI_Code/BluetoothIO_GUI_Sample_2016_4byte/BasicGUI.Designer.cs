<<<<<<< HEAD
﻿namespace BluetoothGUISample
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bluetooth = new System.IO.Ports.SerialPort(this.components);
            this.getIOtimer = new System.Windows.Forms.Timer(this.components);
            this.NextPos = new System.Windows.Forms.NumericUpDown();
            this.PosButton = new System.Windows.Forms.Button();
            this.VelButton = new System.Windows.Forms.Button();
            this.NextVel = new System.Windows.Forms.NumericUpDown();
            this.NextAcc = new System.Windows.Forms.NumericUpDown();
            this.AccButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelocityGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitValue1)).BeginInit();
            this.Troubleshooting.SuspendLayout();
            this.PID_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // bluetooth
            // 
            this.bluetooth.PortName = "COM5";
            // 
            // getIOtimer
            // 
            this.getIOtimer.Enabled = true;
            this.getIOtimer.Tick += new System.EventHandler(this.getIOtimer_Tick);
            // 
            // NextPos
            // 
            this.NextPos.Location = new System.Drawing.Point(14, 61);
            this.NextPos.Margin = new System.Windows.Forms.Padding(6);
            this.NextPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NextPos.Name = "NextPos";
            this.NextPos.Size = new System.Drawing.Size(250, 31);
            this.NextPos.TabIndex = 3;
            // 
            // PosButton
            // 
            this.PosButton.Location = new System.Drawing.Point(304, 53);
            this.PosButton.Margin = new System.Windows.Forms.Padding(6);
            this.PosButton.Name = "PosButton";
            this.PosButton.Size = new System.Drawing.Size(255, 44);
            this.PosButton.TabIndex = 4;
            this.PosButton.Text = "Change Position";
            this.PosButton.UseVisualStyleBackColor = true;
            // 
            // VelButton
            // 
            this.VelButton.Location = new System.Drawing.Point(304, 149);
            this.VelButton.Margin = new System.Windows.Forms.Padding(6);
            this.VelButton.Name = "VelButton";
            this.VelButton.Size = new System.Drawing.Size(255, 44);
            this.VelButton.TabIndex = 4;
            this.VelButton.Text = "Change Velocity";
            this.VelButton.UseVisualStyleBackColor = true;
            // 
            // NextVel
            // 
            this.NextVel.Location = new System.Drawing.Point(14, 157);
            this.NextVel.Margin = new System.Windows.Forms.Padding(6);
            this.NextVel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NextVel.Name = "NextVel";
            this.NextVel.Size = new System.Drawing.Size(250, 31);
            this.NextVel.TabIndex = 3;
            // 
            // NextAcc
            // 
            this.NextAcc.Location = new System.Drawing.Point(14, 253);
            this.NextAcc.Name = "NextAcc";
            this.NextAcc.Size = new System.Drawing.Size(250, 31);
            this.NextAcc.TabIndex = 5;
            // 
            // AccButton
            // 
            this.AccButton.Location = new System.Drawing.Point(304, 245);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(255, 44);
            this.AccButton.TabIndex = 6;
            this.AccButton.Text = "Change Acceleration";
            this.AccButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(602, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 31);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(602, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(602, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 31);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Acceleration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Next Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next Velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Next Acceleration";
            // 
            // PositionGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.PositionGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PositionGraph.Legends.Add(legend1);
            this.PositionGraph.Location = new System.Drawing.Point(1083, 48);
            this.PositionGraph.Name = "PositionGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PositionGraph.Series.Add(series1);
            this.PositionGraph.Size = new System.Drawing.Size(500, 400);
            this.PositionGraph.TabIndex = 16;
            this.PositionGraph.Text = "chart1";
            // 
            // VelocityGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.VelocityGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.VelocityGraph.Legends.Add(legend2);
            this.VelocityGraph.Location = new System.Drawing.Point(1093, 555);
            this.VelocityGraph.Name = "VelocityGraph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.VelocityGraph.Series.Add(series2);
            this.VelocityGraph.Size = new System.Drawing.Size(500, 400);
            this.VelocityGraph.TabIndex = 17;
            this.VelocityGraph.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(517, 555);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(500, 400);
            this.chart3.TabIndex = 18;
            this.chart3.Text = "chart3";
            // 
            // BitValue1
            // 
            this.BitValue1.Location = new System.Drawing.Point(14, 69);
            this.BitValue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BitValue1.Name = "BitValue1";
            this.BitValue1.Size = new System.Drawing.Size(151, 31);
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
            this.Troubleshooting.Location = new System.Drawing.Point(12, 551);
            this.Troubleshooting.Name = "Troubleshooting";
            this.Troubleshooting.Size = new System.Drawing.Size(346, 447);
            this.Troubleshooting.TabIndex = 21;
            this.Troubleshooting.TabStop = false;
            this.Troubleshooting.Text = "Troubleshooting";
            // 
            // TotalTicksLabel
            // 
            this.TotalTicksLabel.AutoSize = true;
            this.TotalTicksLabel.Location = new System.Drawing.Point(181, 150);
            this.TotalTicksLabel.Name = "TotalTicksLabel";
            this.TotalTicksLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalTicksLabel.TabIndex = 27;
            this.TotalTicksLabel.Text = "Blank";
            // 
            // DeadbandBox
            // 
            this.DeadbandBox.AutoSize = true;
            this.DeadbandBox.Location = new System.Drawing.Point(23, 204);
            this.DeadbandBox.Name = "DeadbandBox";
            this.DeadbandBox.Size = new System.Drawing.Size(252, 29);
            this.DeadbandBox.TabIndex = 26;
            this.DeadbandBox.Text = "Deadband Removed?";
            this.DeadbandBox.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 281);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 31);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 281);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Ticks";
            // 
            // TotalTicksBox
            // 
            this.TotalTicksBox.Location = new System.Drawing.Point(23, 145);
            this.TotalTicksBox.Name = "TotalTicksBox";
            this.TotalTicksBox.Size = new System.Drawing.Size(137, 31);
            this.TotalTicksBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 64);
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
            this.menuStrip1.Size = new System.Drawing.Size(1650, 24);
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
            this.comboBox1.Location = new System.Drawing.Point(31, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 33);
            this.comboBox1.TabIndex = 23;
            // 
            // PID_Control
            // 
            this.PID_Control.Controls.Add(this.VelButton);
            this.PID_Control.Controls.Add(this.NextPos);
            this.PID_Control.Controls.Add(this.NextVel);
            this.PID_Control.Controls.Add(this.PosButton);
            this.PID_Control.Controls.Add(this.NextAcc);
            this.PID_Control.Controls.Add(this.AccButton);
            this.PID_Control.Controls.Add(this.label6);
            this.PID_Control.Controls.Add(this.textBox1);
            this.PID_Control.Controls.Add(this.label5);
            this.PID_Control.Controls.Add(this.textBox2);
            this.PID_Control.Controls.Add(this.label4);
            this.PID_Control.Controls.Add(this.textBox3);
            this.PID_Control.Controls.Add(this.label3);
            this.PID_Control.Controls.Add(this.label1);
            this.PID_Control.Controls.Add(this.label2);
            this.PID_Control.Location = new System.Drawing.Point(12, 215);
            this.PID_Control.Name = "PID_Control";
            this.PID_Control.Size = new System.Drawing.Size(820, 303);
            this.PID_Control.TabIndex = 24;
            this.PID_Control.TabStop = false;
            this.PID_Control.Text = "PID_Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Choose Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1010);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PID_Control);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Troubleshooting);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.VelocityGraph);
            this.Controls.Add(this.PositionGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitValue1)).EndInit();
            this.Troubleshooting.ResumeLayout(false);
            this.Troubleshooting.PerformLayout();
            this.PID_Control.ResumeLayout(false);
            this.PID_Control.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart PositionGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart VelocityGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
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
    }
}

=======
﻿namespace BluetoothGUISample
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
            this.VelocityGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
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
            this.bluetooth.PortName = "COM5";
            // 
            // getIOtimer
            // 
            this.getIOtimer.Enabled = true;
            this.getIOtimer.Tick += new System.EventHandler(this.getIOtimer_Tick);
            // 
            // NextPos
            // 
            this.NextPos.Location = new System.Drawing.Point(91, 37);
            this.NextPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NextPos.Name = "NextPos";
            this.NextPos.Size = new System.Drawing.Size(119, 20);
            this.NextPos.TabIndex = 3;
            // 
            // PosButton
            // 
            this.PosButton.Location = new System.Drawing.Point(234, 37);
            this.PosButton.Name = "PosButton";
            this.PosButton.Size = new System.Drawing.Size(116, 23);
            this.PosButton.TabIndex = 4;
            this.PosButton.Text = "Change Position";
            this.PosButton.UseVisualStyleBackColor = true;
            // 
            // VelButton
            // 
            this.VelButton.Location = new System.Drawing.Point(234, 86);
            this.VelButton.Name = "VelButton";
            this.VelButton.Size = new System.Drawing.Size(116, 23);
            this.VelButton.TabIndex = 4;
            this.VelButton.Text = "Change Velocity";
            this.VelButton.UseVisualStyleBackColor = true;
            // 
            // NextVel
            // 
            this.NextVel.Location = new System.Drawing.Point(89, 91);
            this.NextVel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NextVel.Name = "NextVel";
            this.NextVel.Size = new System.Drawing.Size(125, 20);
            this.NextVel.TabIndex = 3;
            // 
            // NextAcc
            // 
            this.NextAcc.Location = new System.Drawing.Point(89, 141);
            this.NextAcc.Margin = new System.Windows.Forms.Padding(2);
            this.NextAcc.Name = "NextAcc";
            this.NextAcc.Size = new System.Drawing.Size(125, 20);
            this.NextAcc.TabIndex = 5;
            // 
            // AccButton
            // 
            this.AccButton.Location = new System.Drawing.Point(234, 136);
            this.AccButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(116, 23);
            this.AccButton.TabIndex = 6;
            this.AccButton.Text = "Change Acceleration";
            this.AccButton.UseVisualStyleBackColor = true;
            // 
            // PosRad
            // 
            this.PosRad.Location = new System.Drawing.Point(13, 51);
            this.PosRad.Margin = new System.Windows.Forms.Padding(2);
            this.PosRad.Name = "PosRad";
            this.PosRad.Size = new System.Drawing.Size(54, 20);
            this.PosRad.TabIndex = 7;
            // 
            // VelRad
            // 
            this.VelRad.Location = new System.Drawing.Point(13, 92);
            this.VelRad.Margin = new System.Windows.Forms.Padding(2);
            this.VelRad.Name = "VelRad";
            this.VelRad.Size = new System.Drawing.Size(52, 20);
            this.VelRad.TabIndex = 8;
            // 
            // AccRad
            // 
            this.AccRad.Location = new System.Drawing.Point(13, 133);
            this.AccRad.Margin = new System.Windows.Forms.Padding(2);
            this.AccRad.Name = "AccRad";
            this.AccRad.Size = new System.Drawing.Size(52, 20);
            this.AccRad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Acceleration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Next Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next Velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Next Acceleration";
            // 
            // PositionGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.PositionGraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PositionGraph.Legends.Add(legend4);
            this.PositionGraph.Location = new System.Drawing.Point(418, 35);
            this.PositionGraph.Margin = new System.Windows.Forms.Padding(2);
            this.PositionGraph.Name = "PositionGraph";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.PositionGraph.Series.Add(series4);
            this.PositionGraph.Size = new System.Drawing.Size(250, 208);
            this.PositionGraph.TabIndex = 16;
            this.PositionGraph.Text = "chart1";
            // 
            // VelocityGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.VelocityGraph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.VelocityGraph.Legends.Add(legend5);
            this.VelocityGraph.Location = new System.Drawing.Point(685, 256);
            this.VelocityGraph.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityGraph.Name = "VelocityGraph";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.VelocityGraph.Series.Add(series5);
            this.VelocityGraph.Size = new System.Drawing.Size(250, 208);
            this.VelocityGraph.TabIndex = 17;
            this.VelocityGraph.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(685, 35);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(250, 208);
            this.chart3.TabIndex = 18;
            this.chart3.Text = "chart3";
            // 
            // BitValue1
            // 
            this.BitValue1.Location = new System.Drawing.Point(7, 36);
            this.BitValue1.Margin = new System.Windows.Forms.Padding(2);
            this.BitValue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BitValue1.Name = "BitValue1";
            this.BitValue1.Size = new System.Drawing.Size(76, 20);
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
            this.Troubleshooting.Location = new System.Drawing.Point(237, 73);
            this.Troubleshooting.Margin = new System.Windows.Forms.Padding(2);
            this.Troubleshooting.Name = "Troubleshooting";
            this.Troubleshooting.Padding = new System.Windows.Forms.Padding(2);
            this.Troubleshooting.Size = new System.Drawing.Size(173, 179);
            this.Troubleshooting.TabIndex = 21;
            this.Troubleshooting.TabStop = false;
            this.Troubleshooting.Text = "Troubleshooting";
            // 
            // TotalTicksLabel
            // 
            this.TotalTicksLabel.AutoSize = true;
            this.TotalTicksLabel.Location = new System.Drawing.Point(90, 78);
            this.TotalTicksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTicksLabel.Name = "TotalTicksLabel";
            this.TotalTicksLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalTicksLabel.TabIndex = 27;
            this.TotalTicksLabel.Text = "Blank";
            // 
            // DeadbandBox
            // 
            this.DeadbandBox.AutoSize = true;
            this.DeadbandBox.Location = new System.Drawing.Point(12, 106);
            this.DeadbandBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeadbandBox.Name = "DeadbandBox";
            this.DeadbandBox.Size = new System.Drawing.Size(131, 17);
            this.DeadbandBox.TabIndex = 26;
            this.DeadbandBox.Text = "Deadband Removed?";
            this.DeadbandBox.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 126);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 127);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Ticks";
            // 
            // TotalTicksBox
            // 
            this.TotalTicksBox.Location = new System.Drawing.Point(12, 75);
            this.TotalTicksBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotalTicksBox.Name = "TotalTicksBox";
            this.TotalTicksBox.Size = new System.Drawing.Size(70, 20);
            this.TotalTicksBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 22);
            this.button2.TabIndex = 21;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bit Value Input";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
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
            this.comboBox1.Location = new System.Drawing.Point(16, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
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
            this.PID_Control.Location = new System.Drawing.Point(16, 327);
            this.PID_Control.Margin = new System.Windows.Forms.Padding(2);
            this.PID_Control.Name = "PID_Control";
            this.PID_Control.Padding = new System.Windows.Forms.Padding(2);
            this.PID_Control.Size = new System.Drawing.Size(364, 163);
            this.PID_Control.TabIndex = 24;
            this.PID_Control.TabStop = false;
            this.PID_Control.Text = "PID_Control";
            // 
            // AccRadio
            // 
            this.AccRadio.AutoSize = true;
            this.AccRadio.Location = new System.Drawing.Point(8, 140);
            this.AccRadio.Name = "AccRadio";
            this.AccRadio.Size = new System.Drawing.Size(84, 17);
            this.AccRadio.TabIndex = 18;
            this.AccRadio.TabStop = true;
            this.AccRadio.Text = "Acceleration";
            this.AccRadio.UseVisualStyleBackColor = true;
            this.AccRadio.CheckedChanged += new System.EventHandler(this.AccRadio_CheckedChanged);
            // 
            // VelRadio
            // 
            this.VelRadio.AutoSize = true;
            this.VelRadio.Location = new System.Drawing.Point(8, 90);
            this.VelRadio.Name = "VelRadio";
            this.VelRadio.Size = new System.Drawing.Size(62, 17);
            this.VelRadio.TabIndex = 17;
            this.VelRadio.TabStop = true;
            this.VelRadio.Text = "Velocity";
            this.VelRadio.UseVisualStyleBackColor = true;
            this.VelRadio.CheckedChanged += new System.EventHandler(this.VelRadio_CheckedChanged);
            // 
            // PosRadio
            // 
            this.PosRadio.AutoSize = true;
            this.PosRadio.Location = new System.Drawing.Point(8, 40);
            this.PosRadio.Name = "PosRadio";
            this.PosRadio.Size = new System.Drawing.Size(62, 17);
            this.PosRadio.TabIndex = 16;
            this.PosRadio.TabStop = true;
            this.PosRadio.Text = "Position";
            this.PosRadio.UseVisualStyleBackColor = true;
            this.PosRadio.CheckedChanged += new System.EventHandler(this.PosRadio_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
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
            this.Current_readings.Location = new System.Drawing.Point(386, 327);
            this.Current_readings.Name = "Current_readings";
            this.Current_readings.Size = new System.Drawing.Size(228, 163);
            this.Current_readings.TabIndex = 26;
            this.Current_readings.TabStop = false;
            this.Current_readings.Text = "Current_readings";
            // 
            // VelCount
            // 
            this.VelCount.Location = new System.Drawing.Point(150, 92);
            this.VelCount.Margin = new System.Windows.Forms.Padding(2);
            this.VelCount.Name = "VelCount";
            this.VelCount.Size = new System.Drawing.Size(52, 20);
            this.VelCount.TabIndex = 26;
            // 
            // AccCount
            // 
            this.AccCount.Location = new System.Drawing.Point(150, 133);
            this.AccCount.Margin = new System.Windows.Forms.Padding(2);
            this.AccCount.Name = "AccCount";
            this.AccCount.Size = new System.Drawing.Size(52, 20);
            this.AccCount.TabIndex = 27;
            // 
            // PosCount
            // 
            this.PosCount.Location = new System.Drawing.Point(150, 51);
            this.PosCount.Margin = new System.Windows.Forms.Padding(2);
            this.PosCount.Name = "PosCount";
            this.PosCount.Size = new System.Drawing.Size(54, 20);
            this.PosCount.TabIndex = 25;
            // 
            // VelDeg
            // 
            this.VelDeg.Location = new System.Drawing.Point(81, 92);
            this.VelDeg.Margin = new System.Windows.Forms.Padding(2);
            this.VelDeg.Name = "VelDeg";
            this.VelDeg.Size = new System.Drawing.Size(52, 20);
            this.VelDeg.TabIndex = 23;
            // 
            // AccDeg
            // 
            this.AccDeg.Location = new System.Drawing.Point(81, 133);
            this.AccDeg.Margin = new System.Windows.Forms.Padding(2);
            this.AccDeg.Name = "AccDeg";
            this.AccDeg.Size = new System.Drawing.Size(52, 20);
            this.AccDeg.TabIndex = 24;
            // 
            // PosDeg
            // 
            this.PosDeg.Location = new System.Drawing.Point(81, 51);
            this.PosDeg.Margin = new System.Windows.Forms.Padding(2);
            this.PosDeg.Name = "PosDeg";
            this.PosDeg.Size = new System.Drawing.Size(54, 20);
            this.PosDeg.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Counts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Deg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Rad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OLSpeedRoll);
            this.groupBox1.Controls.Add(this.OLSpeedSlide);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 67);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Loop - Speed percentage";
            // 
            // OLSpeedRoll
            // 
            this.OLSpeedRoll.Location = new System.Drawing.Point(5, 29);
            this.OLSpeedRoll.Margin = new System.Windows.Forms.Padding(2);
            this.OLSpeedRoll.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.OLSpeedRoll.Name = "OLSpeedRoll";
            this.OLSpeedRoll.Size = new System.Drawing.Size(76, 20);
            this.OLSpeedRoll.TabIndex = 28;
            // 
            // OLSpeedSlide
            // 
            this.OLSpeedSlide.Location = new System.Drawing.Point(95, 17);
            this.OLSpeedSlide.Maximum = 100;
            this.OLSpeedSlide.Minimum = -100;
            this.OLSpeedSlide.Name = "OLSpeedSlide";
            this.OLSpeedSlide.Size = new System.Drawing.Size(104, 45);
            this.OLSpeedSlide.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(16, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 173);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID Coefficients";
            // 
            // KPRoll
            // 
            this.KPRoll.Location = new System.Drawing.Point(4, 29);
            this.KPRoll.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.KPRoll.Name = "KPRoll";
            this.KPRoll.Size = new System.Drawing.Size(67, 20);
            this.KPRoll.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Kp";
            // 
            // KIButt
            // 
            this.KIButt.Location = new System.Drawing.Point(92, 76);
            this.KIButt.Name = "KIButt";
            this.KIButt.Size = new System.Drawing.Size(86, 23);
            this.KIButt.TabIndex = 18;
            this.KIButt.Text = "Change Ki";
            this.KIButt.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ki";
            // 
            // KIRoll
            // 
            this.KIRoll.Location = new System.Drawing.Point(2, 81);
            this.KIRoll.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.KIRoll.Name = "KIRoll";
            this.KIRoll.Size = new System.Drawing.Size(71, 20);
            this.KIRoll.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Kd";
            // 
            // KPButt
            // 
            this.KPButt.Location = new System.Drawing.Point(92, 29);
            this.KPButt.Name = "KPButt";
            this.KPButt.Size = new System.Drawing.Size(86, 23);
            this.KPButt.TabIndex = 19;
            this.KPButt.Text = "Change Kp";
            this.KPButt.UseVisualStyleBackColor = true;
            // 
            // KDButt
            // 
            this.KDButt.Location = new System.Drawing.Point(92, 126);
            this.KDButt.Margin = new System.Windows.Forms.Padding(2);
            this.KDButt.Name = "KDButt";
            this.KDButt.Size = new System.Drawing.Size(86, 23);
            this.KDButt.TabIndex = 21;
            this.KDButt.Text = "Change Kd";
            this.KDButt.UseVisualStyleBackColor = true;
            // 
            // KdRoll
            // 
            this.KdRoll.Location = new System.Drawing.Point(2, 131);
            this.KdRoll.Margin = new System.Windows.Forms.Padding(2);
            this.KdRoll.Name = "KdRoll";
            this.KdRoll.Size = new System.Drawing.Size(71, 20);
            this.KdRoll.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Current_readings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PID_Control);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Troubleshooting);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.VelocityGraph);
            this.Controls.Add(this.PositionGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NextPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart VelocityGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
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
    }
}

>>>>>>> parent of e3e1332... Test OL control
