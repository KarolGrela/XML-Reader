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
        private Plc plc; // = new Plc(CpuType.S71500, "192.168.0.2", 0, 1);

        private XMLReader reader;

        public SendDataForm(XMLReader xmlFile)
        {
            InitializeComponent();
            reader = xmlFile;

            
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


        #endregion



        #region Buttons

        private void buttonConnectWithPlc_Click(object sender, EventArgs e)
        {
            // auxiliary boolean variables
            // if all are true then connection can be established
            bool bIP = true, bRack = true, bSlot = true;

            // reading chosen type of PLC
            CpuType type = (CpuType)comboBoxPlcType.SelectedItem;   

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
            if(bIP && bRack && bSlot)
            {
                // initialize Plc variable
                plc = new Plc(type, ipNumber, Int16.Parse(textBoxRack.Text), Int16.Parse(textBoxSlot.Text));

                ErrorCode _error = plc.Open();  // open connection with physical PLC

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
                plc.Close();
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
    }
}
