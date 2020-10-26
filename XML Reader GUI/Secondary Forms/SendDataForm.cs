using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using XMLReaderClassLibrary;
using S7.Net;
using XML_Reader_GUI.popups;
using FontAwesome;

namespace XML_Reader_GUI.Secondary_Forms
{
    public partial class SendDataForm : Form
    {
        /// <summary>
        /// instance of CPU variable
        /// </summary>
        /// <param name="cpuType"> type of cpu, 40 = S71500, of custom type CpuType (enumeration of ints) </param>
        /// <param name="ip"> IP number of the CPU, of type string </param>
        /// <param name="rack"> number of rack, of type Int16 </param>
        /// <param name="slot"> number of slot, of type Int16 </param>

        private XMLReader reader;
        //private Plc plc;
        private string global_lifebit = "no_data";
        private string global_z = "no_data";
        private string global_char = "no_data";


        public SendDataForm(XMLReader xmlFile)
        {
            InitializeComponent();
            reader = xmlFile;
            //this.plc = mainPlc;

            comboBoxPlcType.SelectedItem = S7.Net.CpuType.S71500;   // Select PLC S71200
            textBoxIpFirst.Text = "192";
            textBoxIpSecond.Text = "168";
            textBoxIpThird.Text = "0";
            textBoxIpFourth.Text = "2";
            textBoxRack.Text = "0";
            textBoxSlot.Text = "1";
        }


        #region LostFocus Methods

        private void textBoxRack_LostFocus(object sender, EventArgs e)
        {
            // if "Text" is not a number or lower than 0 then change Text = "0"
            int number;
            bool result = Int32.TryParse(textBoxRack.Text, out number);
            if (result && number < 0 || result == false)
            {
                textBoxRack.Text = "0";
            }
        }


        private void textBoxSlot_LostFocus(object sender, EventArgs e)
        {
            // if "Text" is not a number or lower than 0 then change Text = "0"
            int number;
            bool result = Int32.TryParse(textBoxSlot.Text, out number);
            if (result && number < 0 || result == false)
            {
                textBoxSlot.Text = "0";
            }
        }


        private void textBoxIpFirst_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxIpFirst.Text, out number);
            if (result && number < 0 || result == false)    // if "Text" is not a number or lower than 0 then change Text = "0"
            {
                textBoxIpFirst.Text = "0";
            }
            else if (result && number > 255)    // if "Text" is higher than 255 then change Text = "255"
            {
                textBoxIpFirst.Text = "255";
            }
        }


        private void textBoxIpSecond_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxIpSecond.Text, out number);
            if (result && number < 0 || result == false)    // if "Text" is not a number or lower than 0 then change Text = "0"
            {
                textBoxIpSecond.Text = "0";
            }
            else if (result && number > 255)    // if "Text" is higher than 255 then change Text = "255"
            {
                textBoxIpSecond.Text = "255";
            }
        }


        private void textBoxIpThird_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxIpThird.Text, out number);
            if (result && number < 0 || result == false)    // if "Text" is not a number or lower than 0 then change Text = "0"
            {
                textBoxIpThird.Text = "0";
            }
            else if (result && number > 255)    // if "Text" is higher than 255 then change Text = "255"
            {
                textBoxIpThird.Text = "255";
            }
        }


        private void textBoxIpFourth_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxIpFourth.Text, out number);
            if (result && number < 0 || result == false)    // if "Text" is not a number or lower than 0 then change Text = "0"
            {
                textBoxIpFourth.Text = "0";
            }
            else if (result && number > 255)        // if "Text" is higher than 255 then change Text = "255"
            {
                textBoxIpFourth.Text = "255";
            }
        }


        private void textBoxX_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxX.Text, out number);
            if (result == false)    // if "Text" is not a number
            {
                textBoxX.Text = "";
            }
        }

        private void textBoxY_LostFocus(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(textBoxY.Text, out number);
            if (result == false)    // if "Text" is not a number
            {
                textBoxY.Text = "";
            }
        }

        private void textBoxCharSent_LostFocus(object sender, EventArgs e)
        {
            if (textBoxCharSent.Text.Length > 1)
            {
                textBoxCharSent.Text = textBoxCharSent.Text.Remove(1, textBoxCharSent.Text.Length - 1);
            }
        }

        #endregion


        #region Connect with PLC

        private void buttonConnectWithPlc_Click(object sender, EventArgs e)
        {
            // auxiliary boolean variables
            // if all are true then connection can be established
            bool bIP = true, bRack = true, bSlot = true;

            CpuType type;
            // reading chosen type of PLC
            if (comboBoxPlcType.SelectedItem != null)   // if type of PLC has been selected
            {
                type = (CpuType)comboBoxPlcType.SelectedItem;   // save chosen type to variable
            }
            else
            {
                // if type of PLC has been selected
                comboBoxPlcType.SelectedItem = S7.Net.CpuType.S71200;   // Select PLC S71200
                type = (CpuType)comboBoxPlcType.SelectedItem;           // save chosen type to variable
            }

            string ipNumber = "";    // stores combined IP number
            // checking if IP number has been typed wrongly
            if (textBoxIpFirst.Text == "" || textBoxIpSecond.Text == "" || textBoxIpThird.Text == "" || textBoxIpFourth.Text == "")
            {
                bIP = false;
            }
            else  // if IP has been typed correctly 
            {
                ipNumber = textBoxIpFirst.Text + "." + textBoxIpSecond.Text + "." + textBoxIpThird.Text + "." + textBoxIpFourth.Text;
                bIP = true;
            }

            // if rack number has not been typed correctly
            int number;
            bool result = Int32.TryParse(textBoxRack.Text, out number);
            if (textBoxRack.Text == "" || result == false || number < 0)
            {
                bRack = false;
            }

            // if rack number has not been typed correctly
            result = Int32.TryParse(textBoxSlot.Text, out number);
            if (textBoxSlot.Text == "" || result == false || number < 0)
            {
                bSlot = false;
            }

            // if everything is OK
            if (bIP && bRack && bSlot)
            {
                // initialize Plc variable
                Global.MainPlc = new Plc(type, ipNumber, Int16.Parse(textBoxRack.Text), Int16.Parse(textBoxSlot.Text));

                ErrorCode _error = Global.MainPlc.Open();  // open connection with physical PLC

                if (_error == 0)    // enum ErrorCode == 0 means connection has been established
                {
                    // create and show a form saying that the connection has been established succesfully
                    var form = new popupPlcConnection("Conncetion with PLC established succesfully", "", true);
                    form.Show();
                }
                else
                {
                    // create and show a form saying that the connection hasn't been established
                    var form = new popupPlcConnection("Conncetion with PLC hasn't been established", "Check for errors in connection or typed parameters!", false);
                    form.Show();
                }

                // CLOSE CONNECTION
                // OBSOLETE IN THIS PART OF CODE
                //plc.Close();
            }
            else    // if a piece of data has been typed wrong
            {
                // Create message
                string msgHeader = "Wrong input values!";
                string msgBody = "";
                if (bIP == false) msgBody += "Assigned IP number is wrong!\n";
                if (bRack == false) msgBody += "Assigned rack number is wrong!\n";
                if (bSlot == false) msgBody += "Assigned slot number is wrong!";

                // create and show a form saying that the connection hasn't been established
                // because sth went wrong
                var form = new popupPlcConnection(msgHeader, msgBody, false);
                form.Show();
            }

        }

        #endregion


        #region Sending data to PLC

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            if (Global.MainPlc != null)
            {
                if (Global.MainPlc.IsConnected)
                {
                    byte[] sendData = PrepareDataToSend();
                    ErrorCode _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 30, 0, sendData);     // send data

                    if (_error == ErrorCode.NoError)
                    {
                        var form = new popupPlcConnection("Data sent succesfully", "", true);
                        form.Show();
                    }
                    else
                    {
                        var form = new popupPlcConnection("Data haven't been sent", $"Encountered difficulty:\n{_error}", false);
                        form.Show();
                    }
                }
            }
            else
            {
                var form = new popupPlcConnection("Data haven't been sent", "PLC isn't connected!", false);
                form.Show();
            }
        }


        private void buttonSendString_Click(object sender, EventArgs e)
        {
           
            string _str = textBoxOutputString.Text;
            byte[] _bytes = S7.Net.Types.String.ToByteArray(_str);  // data 
            byte max_len = (byte)100;
            byte actual_len = (byte)_str.Length;

            List<byte> Message = new List<byte>();
            Message.Add(max_len);
            Message.Add(actual_len);
            Message.AddRange(_bytes);

            if (Global.MainPlc != null)
            {
                if (Global.MainPlc.IsConnected)
                {
                    ErrorCode _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 30, 14, Message.ToArray());     // send data
                    
                    if (_error == ErrorCode.NoError)
                    {
                        var form = new popupPlcConnection("Data sent succesfully", "", true);
                        form.Show();
                    }
                    else
                    {
                        var form = new popupPlcConnection("Data haven't been sent", $"Encountered difficulty:\n{_error}", false);
                        form.Show();
                    }
                }
            }
            else
            {
                var form = new popupPlcConnection("Data haven't been sent", $"PLC isn't connected!", false);
                form.Show();
            }
        }


        private byte[] PrepareDataToSend()
        {
            byte[] sendData = new byte[8];

            if (global_lifebit == "no_data" || global_lifebit == "False")
            {
                sendData[0] = 1;
            }
            else if (global_lifebit == "True")
            {
                sendData[0] = 0;
            }

            /// preparing integer variables
            // preparing x variable
            short x;
            bool b_x = Int16.TryParse(textBoxX.Text, out x);
            if (b_x == false)
            {
                x = 0;
            }
            // converting integer to byte[] array and reversing order (S7 uses different notation)
            byte[] xB = BitConverter.GetBytes(x);
            Array.Reverse(xB);
            sendData[2] = xB[0];
            sendData[3] = xB[1];

            // preparing y variable
            short y;
            bool b_y = Int16.TryParse(textBoxY.Text, out y);
            if (b_y == false)
            {
                y = 0;
            }
            // converting integer to byte[] array and reversing order (S7 uses different notation)
            byte[] yB = BitConverter.GetBytes(y);
            Array.Reverse(yB);
            sendData[4] = yB[0];
            sendData[5] = yB[1];

            /// preparing char variable
            char _char;
            if (textBoxCharSent.Text.Length != 0)
            {
                _char = textBoxCharSent.Text[0];
            }
            else
            {
                _char = ' ';
            }
            sendData[6] = (byte)_char;
            sendData[7] = (byte)' ';

            return sendData;
        }

        #endregion


        #region Rcv Data

        private void RcvDataFromPlc()
        {

            if (Global.MainPlc != null)
            { 
                if (Global.MainPlc.IsConnected)
                { 

                    /// <summary>
                    /// Method "ReadBytes" is used to read data from memory of the PLC
                    /// </summary>
                    /// <param name="dataType"> specifies where the read data is stored (DB, Memory, Inputs, Outputsm etc  </param>
                    /// <param name="db"> address of the datatype, eg. if we reaed from DB45 then db = 45 </param>
                    /// <param name="startByteAdr"> address of first byte that is to be read </param>
                    /// <param name="count"> amount of read bytes </param>
                    byte[] rcvData = Global.MainPlc.ReadBytes(DataType.DataBlock, 30, 8, 6);     // read data and save them to a global variable "data" 

                    if (rcvData != null)
                    {
                        // saving boolean data
                        bool bit = BitConverter.ToBoolean(rcvData, 0);
                        if (bit == false)
                        {
                            global_lifebit = "True";
                        }
                        else
                        {
                            global_lifebit = "False";
                        }

                        // saving integer values
                        byte[] iData = { 1, 2 };
                        iData[0] = rcvData[3];
                        iData[1] = rcvData[2];
                        short z = BitConverter.ToInt16(iData, 0);
                        global_z = z.ToString();

                        // saving char values
                        char c = BitConverter.ToChar(rcvData, 4);
                        global_char = c.ToString();
                    }
                    else
                    {
                        global_lifebit = "no_data";
                        global_z = "no_data";
                        global_char = "no_ data";
                    }
                }
            }
        }

        private void buttonRcvData_Click(object sender, EventArgs e)
        {
            RcvDataFromPlc();
            labelCharRcvdFill.Text = global_char;
            labelZFill.Text = global_z;
            labelLifebitFill.Text = global_lifebit;
        }


        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
