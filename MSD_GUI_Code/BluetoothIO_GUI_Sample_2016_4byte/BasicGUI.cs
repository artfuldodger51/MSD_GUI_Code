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
        int Lowbyte = 0;
        int Highbyte = 0;
        int arraynum = 0;
        int i = 0;
        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[5];
        const byte START = 255;
        const byte ZERO = 0;
        int controlMode = 0; // 0-no control, 1-open loop, 2-closed loop
        const int noControl = 0;
        const int openLoop = 1;
        const int closedLoop = 2;
        long time1 = 0;
        double distance1 = 0;
        double distance2 = 0;
        double velocitydisplay = 0;
        double acceldisplay = 0;
        double velocity1 = 0;
        double velocity2 = 0;
        int PIDMode = 0;
        const int position = 0;
        const int velocity = 1;
        const int acceleration = 2;

        // PID variables
        System.Diagnostics.Stopwatch Dt = new Stopwatch();
        long PIDtime = 0;
        long PIDtime_new = 0;
        long PIDtime_prev = 0;
        double posSet = 0;
        double velSet = 0;
        double accSet = 0;
        double SettingValue = 0;
        double pError = 0;
        double iError = 0;
        double dError = 0;
        double prevError = 0;
        double Kp = 0;
        double Ki = 0;
        double Kd = 0;
        byte controlAction = 0;
        byte OLSpeed = 0;

        public Form1()
        {


            // Initialize required for form controls.
            InitializeComponent();
            
            // Create Seperate Threads to run Calculations and Update Graphs
            Thread t = new Thread(CalculateTicks);
            t.Start();

            Thread b = new Thread(Calculate_Velocity);
            b.Start();

            Thread d = new Thread(Graph_Stuff);
            d.Start();



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

// ---------------------------------------------------------------------------------------------------------------- //
// -------------------------------------- Send Data to the Arduino ------------------------------------------------ //
// ---------------------------------------------------------------------------------------------------------------- //
        
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

        }



// ---------------------------------------------------------------------------------------------------------------- //
// ---------------------------------------- Read From the Arduino ------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void getIOtimer_Tick(object sender, EventArgs e) //It is best to continuously check for incoming data as handling the buffer or waiting for event is not practical in C#.
        {
            if(Dt.IsRunning == false)
                Dt.Start();


            if (bluetooth.IsOpen) //Check that a serial connection exists.
            {

                // READ DATA FROM THE ARDUINO
                //-----------------------------------------------------------------------------------------------------------
                if (bluetooth.BytesToRead >= 4) //Check that the buffer contains a full four byte package.
                {
                    //if (bluetooth.BytesToRead >= 16)
                    //    var++;
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

                        DecTickNew = Lowbyte + 256 * Highbyte;


                        Diff = DecTickNew - DecTickOld;


                        if (Diff > 30000)
                        { Diff = 1; }

                        else if (Diff < -30000)
                        { Diff = -1; }

                        DecTickOld = DecTickNew;
                        TotalTicks += Diff;


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
                            // PID Control
                            case position:
                                pError = posSet + TotalTicks;
                                break;

                            case velocity:
                                pError = velSet - velocitydisplay;
                                break;

                        }

                        // PID Control Control using a timer (Dt)
                        PIDtime = Dt.ElapsedMilliseconds;
                        PIDtime_new = PIDtime - PIDtime_prev;

                        iError = iError + pError * PIDtime_new;
                        dError = (pError - prevError) / PIDtime;

                        prevError = pError;
                        PIDtime_prev = PIDtime;

                        // Set Integral error to a maximum value if a too high value is reached
                        if (iError > 1000000)
                            iError = 1000000;
                        else if (iError < -1000000)
                            iError = -1000000;

                        // Create the output value to send to the arduino to control the motor
                        SettingValue = ((Kp * -pError + Ki * -iError + Kd * -dError) + 127);

                        // If the value is larger than a byte, reduce it to the maximum allowable value and vice versa
                        if (SettingValue > 255)
                            SettingValue = 255;
                        else if (SettingValue < 0)
                            SettingValue = 0;

                        // Value to be sent to the Arduino
                        controlAction = (byte)SettingValue;

                            break;
                        default:
                            break;
                }

                // Send the value, controlAction, to the Arduino to control the motor
                SendIO(1, controlAction);
                SendIO(2, 0);

            }

         }


// ---------------------------------------------------------------------------------------------------------------- //
// -------------------------------------- Update Tick Text Box ---------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void CalculateTicks()
        {

            while (TotalTicksBox.IsHandleCreated == false) { }
            while (true)
            {

                Thread.Sleep(50);
                this.Invoke((MethodInvoker)delegate ()
                {
                    TotalTicksBox.Text = TotalTicks.ToString();
                });



            }
        } 

// ---------------------------------------------------------------------------------------------------------------- //
// ------------------------------------ Graph Creation and Plotting ----------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void Graph_Stuff()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (VelGraph.IsHandleCreated == false) { }
            while (VelButton.IsHandleCreated == false) { }
            while (true)
            {
                Thread.Sleep(100);
                this.Invoke((MethodInvoker)delegate ()
                {
                    time1 = watch.ElapsedMilliseconds;
                    PositionGraph.Series[0].Points.AddXY(time1 / 1000.0, TotalTicks);
                    VelGraph.Series[0].Points.AddXY(time1 / 1000.0, velocitydisplay);
                    VelGraph.Series[1].Points.AddXY(time1 / 1000.0, velSet);
                    AccelGraph.Series[0].Points.AddXY(time1 / 1000.0, acceldisplay);
                    AccelGraph.Series[1].Points.AddXY(time1 / 1000.0, accSet);
                    if (PositionGraph.Series[0].Points.Count() > 100)
                    {
                        PositionGraph.Series[0].Points.RemoveAt(0);
                        VelGraph.Series[0].Points.RemoveAt(0);
                        AccelGraph.Series[0].Points.RemoveAt(0);
                    }

                    PositionGraph.ResetAutoValues();
                    VelGraph.ResetAutoValues();
                    AccelGraph.ResetAutoValues();



                });

                

            }
        }



// ---------------------------------------------------------------------------------------------------------------- //
// ------------------------------- Velocity and Acceleration Calcluations ----------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void Calculate_Velocity()
        {
            double j = 0;
            double[] velocityarray = new double[10];
            Stopwatch watch2 = new Stopwatch();
            watch2.Start();

            while (VelCount.IsHandleCreated == false) { }
            while (true)
            {

                
                distance1 = TotalTicks;
                Thread.Sleep(50);
                distance2 = TotalTicks;
                velocitydisplay = (distance2 - distance1) / 50 * 1000;
                velocityarray[arraynum] = velocitydisplay;
                velocity1 = velocitydisplay;
                for (i = 0; i < 10; i++)
                {
                    j += velocityarray[i];
                }
                velocitydisplay = j / 10;
                j = 0;

                this.Invoke((MethodInvoker)delegate ()
                {
                    VelCount.Text = velocitydisplay.ToString();
                });

                acceldisplay = (velocity1 - velocity2) / 50 * 1000;

                this.Invoke((MethodInvoker)delegate ()
                {
                    AccCount.Text = acceldisplay.ToString();
                });
                if (arraynum == 9)
                    arraynum = 0;
                velocity2 = velocity1;
                arraynum++;
            }
        }


// ---------------------------------------------------------------------------------------------------------------- //
// --------------------------------------- System Control Options ------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
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
                case "Positional Control":
                    controlMode = closedLoop;
                    break;

            }
        }



// ---------------------------------------------------------------------------------------------------------------- //
// ------------------------------------------- PID Mode Setting --------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
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

// ---------------------------------------------------------------------------------------------------------------- //
// ------------------------------------- PID Coefficient Adjustments ---------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void KPButt_Click(object sender, EventArgs e)
        {
            Kp = (float)KPRoll.Value;
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


// ---------------------------------------------------------------------------------------------------------------- //
// --------------------------------------- Setpoint Adjusting ----------------------------------------------------- //
// ---------------------------------------------------------------------------------------------------------------- //
        private void PosButton_Click_1(object sender, EventArgs e)
        {
            if (PosRadio.Checked == true)
            {
                posSet = -(int)NextPos.Value;
                iError = 0;
                PositionGraph.Series[0].Points.Clear();
            }
            
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
            OLSpeed = (byte)((OLSpeedRoll.Value));// + 100) / 200 * 255);
        }

        private void OLSpeedRoll_ValueChanged(object sender, EventArgs e)
        {
            OLSpeedSlide.Value = (int)OLSpeedRoll.Value;
            OLSpeed = (byte)((OLSpeedSlide.Value + 100) / 200.0 * 255);
        }


    }

}