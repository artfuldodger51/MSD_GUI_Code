// Curtin University
// Mechatronics Engineering
// Bluetooth I/O Card - Sample GUI Code

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace BluetoothGUISample
{    

    

    public partial class Form1 : Form
    {
        // Declare variables to store inputs and outputs.

        bool runBluetooth = true;
        int DecTickNew = 0;
        int DecTickOld = 0;
        int TotalTicks = 0;
        int Diff = 0;
        double time = 0;
        int BitVal1 = 0;
        int Lowbyte = 0;
        int Highbyte = 0;
        int var = 0;

        // Circumference of Decoder DIsc
        // 

        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[5];

        const byte START = 255;
        const byte ZERO = 0;

        int controlMode = 0; // 0-no control, 1-open loop, 2-closed loop

        const int noControl = 0;
        const int openLoop = 1;
        const int closedLoop = 2;
        bool deadbandRemove = false;

        int PIDMode = 0;
        const int position = 0;
        const int velocity = 1;
        const int acceleration = 2;

        // PID variables
        int runningTime = 0;
        float posSet = 0;
        float velSet = 0;
        float accSet = 0;
        float setpoint = 0;
        float SettingValue = 0;

        float pError = 0;
        float iError = 0;
        float dError = 0;
        float prevError = 0;

        float Kp = 200;
        float Ki = 200;
        float Kd = 200;
        

        byte controlAction = 0;
        byte OLSpeed = 0;

        

        public Form1()
        {


            // Initialize required for form controls.
            InitializeComponent();


            Stopwatch watch = new Stopwatch();
            watch.Start();

            // Do all Tick calculations in a seperate thread.
            Thread t = new Thread(CalculateTicks);
            t.Start();

            // Mode Thread
            //Thread g = new Thread(SetControl);
            //g.Start();


            // Establish connection with Bluetooth IOCard
            if (runBluetooth == true)
            {
                if (!bluetooth.IsOpen)                                  // Check if the bluetooth has been connected.
                {
                    try
                    {
                        bluetooth.Open();                               //Try to connect to the bluetooth.
                    }
                    catch
                    {
                        
                    }
                }
            }
        }
        
        // Send a four byte message to the Arduino via serial.
        private void SendIO(byte PORT, byte DATA)
        {
            Outputs[0] = START;    //Set the first byte to the start value that indicates the beginning of the message.
            Outputs[1] = PORT;     //Set the second byte to represent the port where, Input 1 = 0, Input 2 = 1, Output 1 = 2 & Output 2 = 3. This could be enumerated to make writing code simpler... (see Arduino driver)
            Outputs[2] = DATA;  //Set the third byte to the value to be assigned to the port. This is only necessary for outputs, however it is best to assign a consistent value such as 0 for input ports.
            Outputs[3] = (byte)(START + PORT + DATA); //Calculate the checksum byte, the same calculation is performed on the Arduino side to confirm the message was received correctly.
            //Debug.WriteLine(Outputs[3]);
            if (bluetooth.IsOpen)
            {
                bluetooth.Write(Outputs, 0, 4);         //Send all four bytes to the IO card.                      
            }
        }

        private void button2_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            SendIO(0, 0);
            if (DeadbandBox.Checked == true)
            {
                if (BitValue1.Value < 150 & BitValue1.Value > 127)
                {
                    BitVal1 = 150;
                    SendIO(1, (byte)BitVal1); // The value 1 indicates troubleshooting box 1.}
                }
                else if (BitValue1.Value < 127 & BitValue1.Value > 107)
                {
                    BitVal1 = 107;
                    SendIO(1, (byte)BitVal1); // The value 1 indicates troubleshooting box 1.}
                }
                
                else 
                {
                    SendIO(1, (byte)BitValue1.Value); // The value 1 indicates troubleshooting box 1.
                }
            }

            else if (DeadbandBox.Checked == false)
            {
                SendIO(1, (byte)BitValue1.Value); // The value 1 indicates troubleshooting box 1.}
            }

        }
        // Distance Changer Button
        private void PosButton_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            SendIO(2, (byte)NextPos.Value); // The value 1 indicates troubleshooting box 1.
        }

        // Velocity Changer Button
        private void VelButton_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            SendIO(2, (byte)NextVel.Value); // The value 1 indicates troubleshooting box 1.
        }

        // Acceleration Changer Button
        private void AccButton_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            SendIO(2, (byte)NextAcc.Value); // The value 1 indicates troubleshooting box 1.
        }


        private void Get1_Click(object sender, EventArgs e) //Press the button to request value from Input 1, Arduino Port F.
        {
            SendIO(0, ZERO);  // The value 0 indicates Input 1, ZERO just maintains a fixed value for the discarded data in order to maintain a consistent package format.
        }

        private void Get2_Click(object sender, EventArgs e) //Press the button to request value from Input 1, Arduino Port K.
        {
            SendIO(1, ZERO);  // The value 1 indicates Input 2, ZERO maintains a consistent value for the message output.
        }




        private void getIOtimer_Tick(object sender, EventArgs e) //It is best to continuously check for incoming data as handling the buffer or waiting for event is not practical in C#.
        {

            if (bluetooth.IsOpen) //Check that a serial connection exists.
            {

                // READ DATA FROM THE ARDUINO
                //-----------------------------------------------------------------------------------------------------------
                if (bluetooth.BytesToRead >= 4) //Check that the buffer contains a full four byte package.
                {

                    Inputs[0] = (byte)bluetooth.ReadByte(); //Read the first byte of the package.

                    if (Inputs[0] == START) //Check that the first byte is in fact the start byte.
                    {
                        time++;

                        //Read the rest of the package.
                        Inputs[1] = (byte)bluetooth.ReadByte(); // Low Data Byte
                        Inputs[2] = (byte)bluetooth.ReadByte(); // High Data byte (The byte thats useful)
                        Inputs[3] = (byte)bluetooth.ReadByte(); // Checksum Byte 
                        
                       
                        Lowbyte = Inputs[1];
                        Highbyte = Inputs[2];

                        if (Lowbyte == 69 && Highbyte == 69)
                        {
                            deadbandRemove = false;
                        }

                                              
                    }
                }

                // Do adjustments for Control Settings in a seperate thread to remove lag


                switch (controlMode)
                {
                    case noControl:
                        controlAction = 129;
                        break;

                    case openLoop:
                        controlAction = OLSpeed;
                        break;

                    case closedLoop:
                        switch (PIDMode)
                        {
                            case position:
                                setpoint = posSet;
                                pError = (setpoint - TotalTicks);
                                break;

                            case velocity:
                                //setpoint = box;
                                //current = DecTickNew;
                                break;

                            case acceleration:
                                break;
                        }


                        //
                        // http://robotsforroboticists.com/pid-control/
                        // https://tutorial.cytron.io/2012/06/22/pid-for-embedded-design/
                        //

                        // PID Control
                        pError = posSet + TotalTicks;
                        iError = iError + pError;
                        dError = pError - prevError;
                        prevError = pError;

                        if (pError <= 1000 && pError >= -1000)
                        {
                            SettingValue = ((Kp / 1000 * pError + Ki / 1000 * iError + Kd / 1000 * dError) + 127);
                            if (SettingValue > 150)
                                SettingValue = 150;
                            else if (SettingValue < 100)
                                SettingValue = 100;

                            controlAction = (byte)SettingValue;
                        }

                        else if (pError <= 20000 && pError >= -20000)
                        {
                            SettingValue = ((Kp / 1000 * pError + Ki / 1000 * iError + Kd / 1000 * dError) + 127);
                            if (SettingValue > 200)
                                SettingValue = 200;
                            else if (SettingValue < 55)
                                SettingValue = 55;

                            controlAction = (byte)SettingValue;
                        }

                        else
                        {
                            SettingValue = ((Kp / 1000 * pError + Ki / 1000 * iError + Kd / 1000 * dError) + 127);
                            if (SettingValue > 255)
                                SettingValue = 255;
                            else if (SettingValue < 0)
                                SettingValue = 0;

                            controlAction = (byte)SettingValue;
                        }


                        Debug.WriteLine("-------------------------------------------------");
                        Debug.WriteLine("Error:");
                        Debug.WriteLine(pError);
                        Debug.WriteLine("IError:");
                        Debug.WriteLine(iError);
                        Debug.WriteLine("dError:");
                        Debug.WriteLine(dError);
                        Debug.WriteLine("ControlAction:");
                        Debug.WriteLine(controlAction);
                        

                        break;
                    default:
                        break;

                }


                if (deadbandRemove != true)
                {
                
                    SendIO(1, controlAction);
                    SendIO(2, 0);
                }
                //Debug.WriteLine("DAC Value");
                //Debug.WriteLine(controlAction);


            }

         }

        //Thread t - Count Ticks
        private void CalculateTicks()
        {
            while (TotalTicksBox.IsHandleCreated == false) { }
            while (true)
            {
                //Debug.WriteLine(Lowbyte);
                //Debug.WriteLine(Highbyte);
                DecTickNew = Lowbyte + 256 * Highbyte;


                Diff = DecTickNew - DecTickOld;


                if (Diff > 30000)
                { Diff = 1; }

                else if (Diff < -30000)
                { Diff = -1; }

                DecTickOld = DecTickNew;
                TotalTicks += Diff;
                //Debug.WriteLine(Lowbyte);
                this.Invoke((MethodInvoker)delegate ()
                {
                    TotalTicksBox.Text = TotalTicks.ToString();
                });

                //Debug.WriteLine(TotalTicks);
                //TotalTicksBox.Update(); // Hopefully updates textbox
            }
        }

        //Thread g - Choose Mode
        /*private void SetControl()
        {
            while (TotalTicksBox.IsHandleCreated == false) { }
            while (true)
            { 
                switch (controlMode)
                {
                    case noControl:
                        controlAction = 129;
                        break;

                    case openLoop:
                        controlAction = OLSpeed;
                        break;

                    case closedLoop:
                        switch (PIDMode)
                        {
                            case position:
                                setpoint = posSet;
                                //error = setpoint - currentCountVal
                                break;

                            case velocity:
                                //setpoint = box;
                                //current = DecTickNew;
                                break;

                            case acceleration:
                                break;
                        }

                        // General PID error calcs
                        //error = setpoint - current;
                        iError = prevError + error;
                        dError = error - prevError;
                        // 
                        prevError = error;
                        //
                        //
                        controlAction = (byte)(Kp * error + Ki * iError + Kd * dError);


                        break;
                    default:
                        break;

                }
                
            }
        }*/

        /*double PositionGraphCalc(double x)
        {
            return (Math.Abs(0.039885*x)+Math.Sin(2));
            
        }*/

        /*private void Form1_Load(object sender, EventArgs e)
        {
            PositionGraph.ChartAreas[0].AxisY.ScaleView.Zoom(-15, 15); // -15<= y <=15
            PositionGraph.ChartAreas[0].AxisX.ScaleView.Zoom(-15, 2); // -15 <= x <= 2
            PositionGraph.ChartAreas[0].CursorX.IsUserEnabled = false;
            PositionGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
            PositionGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            PositionGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //for (int i = -15; i <2; i++)
            //{
            //    PositionGraph.Series[0].Points.AddXY(i, function(i));
            //    PositionGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //}
        }*/


        // Set contol mode for the motor
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(comboBox1.SelectedItem.ToString());
            switch (comboBox1.SelectedItem.ToString())
            {

                case "No Control":
                    controlMode = noControl;
                    break;
                case "Manual Motor Speed":
                    controlMode = openLoop;
                    break;
                case "Deadband Testing":
                    break;
                case "Positional Control":
                    controlMode = closedLoop;
                    break;

            }
        }
   


// ---------------------------------------------------------------------------------------------------------------- //
// ------------------------------------------- PID CONTROL -------------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //

        // These 3 radio buttons select the PID control mode. Only 1 may be selected at a time. 
        private void PosRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    PIDMode = position;
                }
            }
        }

        private void VelRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    PIDMode = velocity;
                }
            }

        }

        private void AccRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    PIDMode = acceleration;
                }
            }
        }

        private void KPButt_Click(object sender, EventArgs e)
        {
            Kp = (float)KdRoll.Value;
        }

        private void KIButt_Click(object sender, EventArgs e)
        {
            Ki = (float)KIRoll.Value;
        }

        private void KDButt_Click(object sender, EventArgs e)
        {
            Kd = (float)KdRoll.Value;
        }

        private void KPRoll_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PosButton_Click_1(object sender, EventArgs e)
        {
            if (PosRadio.Checked == true)
                posSet = (int)NextPos.Value;
        }

        private void VelButton_Click_1(object sender, EventArgs e)
        {
            if (VelRadio.Checked == true)
                velSet = (float)NextVel.Value;
        }

        private void AccButton_Click_1(object sender, EventArgs e)
        {
            if (AccRadio.Checked == true)
                accSet = (float)NextAcc.Value;
        }

        private void OLSpeedSlide_Scroll(object sender, EventArgs e)
        {
            OLSpeedRoll.Value = OLSpeedSlide.Value;
            OLSpeed = (byte)((OLSpeedRoll.Value + 100) / 200 * 255);
        }

        private void OLSpeedRoll_ValueChanged(object sender, EventArgs e)
        {
            OLSpeedSlide.Value = (int)OLSpeedRoll.Value;
            OLSpeed = (byte)((OLSpeedSlide.Value + 100) / 200 * 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deadbandRemove = true;
            SendIO(3, 0);
        }

        private void DeadbandBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendIO(4, 0);
            DeadbandBox.Checked = !DeadbandBox.Checked;
        }
    }

}