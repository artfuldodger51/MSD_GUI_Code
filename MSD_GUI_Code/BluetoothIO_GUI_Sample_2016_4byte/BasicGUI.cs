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

        bool runBluetooth = false;
        int Input1 = 0;
        int Input2 = 0;
        int DecTickNew = 0;
        int DecTickOld = 0;
        double TotalTicks = 0;
        int Diff = 0;
        double time = 0;
        double error = 0;
        int BitVal1 = 0;
        int Lowbyte = 0;
        int Highbyte = 0;

        // Circumference of Decoder DIsc
        // 

        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[5];

        const byte START = 255;
        const byte ZERO = 0;



        public Form1()
        {


            // Initialize required for form controls.
            InitializeComponent();


            Stopwatch watch = new Stopwatch();
            watch.Start();

            Thread t = new Thread(() => outputTimer(watch, textBox3));          // Kick off a new thread
            t.IsBackground = true;
            t.Start();                               // running WriteY()
 



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

        private void outputTimer (Stopwatch watch, TextBox textBox)
        {

            while(true)
            {
                textBox.Invalidate();
                textBox.Text = watch.ElapsedMilliseconds.ToString();
                
               // textBox.Update();
            }
        }

        // Send a four byte message to the Arduino via serial.
        private void SendIO(byte PORT, byte DATA)
        {
            Outputs[0] = START;    //Set the first byte to the start value that indicates the beginning of the message.
            Outputs[1] = PORT;     //Set the second byte to represent the port where, Input 1 = 0, Input 2 = 1, Output 1 = 2 & Output 2 = 3. This could be enumerated to make writing code simpler... (see Arduino driver)
            Outputs[2] = DATA;  //Set the third byte to the value to be assigned to the port. This is only necessary for outputs, however it is best to assign a consistent value such as 0 for input ports.
            Outputs[3] = (byte)(START + PORT + DATA); //Calculate the checksum byte, the same calculation is performed on the Arduino side to confirm the message was received correctly.

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
                    SendIO(2, (byte)BitVal1); // The value 1 indicates troubleshooting box 1.}
                }
                else if (BitValue1.Value < 127 & BitValue1.Value > 107)
                {
                    BitVal1 = 107;
                    SendIO(2, (byte)BitVal1); // The value 1 indicates troubleshooting box 1.}
                }
                
                else 
                {
                    SendIO(2, (byte)BitValue1.Value); // The value 1 indicates troubleshooting box 1.
                }
            }

            else if (DeadbandBox.Checked == false)
            {
                SendIO(2, (byte)BitValue1.Value); // The value 1 indicates troubleshooting box 1.}
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
                if (bluetooth.BytesToRead >= 5) //Check that the buffer contains a full four byte package.
                {
                    Inputs[0] = (byte)bluetooth.ReadByte(); //Read the first byte of the package.

                    if (Inputs[0] == START) //Check that the first byte is in fact the start byte.
                    {
                        time++;

                        //Read the rest of the package.
                        Inputs[1] = (byte)bluetooth.ReadByte();
                        Inputs[2] = (byte)bluetooth.ReadByte(); // Data byte (The byte thats useful)
                        Inputs[3] = (byte)bluetooth.ReadByte(); // Data byte (The byte thats useful)
                        Inputs[4] = (byte)bluetooth.ReadByte();

                        Lowbyte = Inputs[2];
                        Highbyte = Inputs[3];

                        DecTickNew = Lowbyte + 256*Highbyte;


                        Diff = DecTickNew - DecTickOld;


                        if (Diff > 30000)
                        { Diff = 1; }

                        else if (Diff < -30000)
                        { Diff = -1; }

                        DecTickOld = DecTickNew;
                        TotalTicks += Diff;
                        TotalTicksBox.Text = TotalTicks.ToString();
                        TotalTicksBox.Update(); // Hopefully updates textbox
                        TotalTicksLabel.Text = TotalTicks.ToString(); // If this works im going to cry

                        //Print to Position Graph
                        textBox4.Text = (Math.Abs(0.039885 * TotalTicks) + Math.Sin(2)).ToString();
                        PositionGraph.Series[0].Points.AddXY(time, PositionGraphCalc(TotalTicks));
                        PositionGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                        //Calculate the checksum.
                        byte checkSum = (byte)(Inputs[0] + Inputs[1] + Inputs[2]);

                        //Check that the calculated check sum matches the checksum sent with the message.
                        if (Inputs[4] == checkSum)
                        {
                            //Check which port the incoming data is associated with.
                            switch (Inputs[1])
                            {

                                case 0: //Save the data to a variable and place in the textbox.
                                    

 

                                    TotalTicksBox.Text = TotalTicks.ToString();
                                    break;
                                case 1: //Save the data to a variable and place in the textbox. 
                                    Input2 = Inputs[2];
                                    break;
                            }
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------
                //
                //
                //
                //  PID CONTROL
                //  u = K_p x e + K_i x (integral of e) + K_d x (derivative of e)

                //  Proportional Control
                // 
               /* switch (controlMode)
                {
                    case position:
                        setpoint = box;
                        current = DecTickNew;
                        break;
                    case speed:


                        // General PID error calcs
                        // error = setpoint - currentValue;
                        // iError = prevError + error;
                        // dError = error - prevError;
                        // 
                        // prevError = error
                        //
                        //
                        // controlAction = Kp * error + Ki * iError + Kd * dError;
                        // SendIO(1, controlAction);  

                        //
                        //
                        //
                        //-----------------------------------------------------------------------------------------------------------


                        //-----------------------------------------------------------------------------------------------------------
                }*/ 
            }

        }

        double PositionGraphCalc(double x)
        {
            return (Math.Abs(0.039885*x)+Math.Sin(2));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PositionGraph.ChartAreas[0].AxisY.ScaleView.Zoom(-15, 15); // -15<= y <=15
            PositionGraph.ChartAreas[0].AxisX.ScaleView.Zoom(-15, 2); // -15 <= x <= 2
            PositionGraph.ChartAreas[0].CursorX.IsUserEnabled = true;
            PositionGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            PositionGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            PositionGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //for (int i = -15; i <2; i++)
            //{
            //    PositionGraph.Series[0].Points.AddXY(i, function(i));
            //    PositionGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //}
        }





    }

}
