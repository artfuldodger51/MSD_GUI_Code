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

