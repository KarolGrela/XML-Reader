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

namespace XML_Reader_GUI.Secondary_Forms
{
    public partial class FileInfoForm : Form
    {
        private XMLReader reader;   // local copy of data from the XML
        public FileInfoForm(XMLReader xmlFile)
        {
            InitializeComponent();

            reader = xmlFile;   // copy data to local instance of XMLReader

            if (reader != null) // XML file isn't empty, display data on the form
            {
                labelProductionAreaFill.Text = reader.fileInfo.Production_area;
                labelMachineTypeFill.Text = reader.fileInfo.Machine_type;
                labelMachineTypeIDFill.Text = reader.fileInfo.Machine_type_id;
                labelVersionFill.Text = reader.fileInfo.Version;
                labelEnvironmentVersionFill.Text = reader.fileInfo.Environment_version;
                labelTimestampFill.Text = reader.fileInfo.Timestamp;
            }
        }


        #region Send to PLC

        private void buttonSendString_Click(object sender, EventArgs e)
        {
            if(reader != null)  // XML file isn't empty
            {
                // send data to PLC
                ErrorCode _e1 = prepareData(reader.fileInfo.Production_area, 270);
                ErrorCode _e2 = prepareData(reader.fileInfo.Machine_type, 526);
                ErrorCode _e3 = prepareData(reader.fileInfo.Machine_type_id, 782);
                ErrorCode _e4 = prepareData(reader.fileInfo.Version, 1038);
                ErrorCode _e5 = prepareData(reader.fileInfo.Environment_version, 1294);
                ErrorCode _e6 = prepareData(reader.fileInfo.Timestamp, 1550);

                // data sent succesfully
                if (_e1 == ErrorCode.NoError && _e2 == ErrorCode.NoError && _e3 == ErrorCode.NoError &&
                    _e4 == ErrorCode.NoError && _e5 == ErrorCode.NoError && _e6 == ErrorCode.NoError)
                {
                    var form = new popupPlcConnection("Data sent succesfully", "", true);
                    form.Show();
                }
                // an error ocurred while sending any if the string
                else
                {
                    var form = new popupPlcConnection("Error occured while sending data","", false);
                    form.Show();
                }
            }
            // XML file is empty or hasn't been read - send empty strings
            else
            {
                ErrorCode _e1 = prepareData("", 270);
                ErrorCode _e2 = prepareData("", 526);
                ErrorCode _e3 = prepareData("", 782);
                ErrorCode _e4 = prepareData("", 1038);
                ErrorCode _e5 = prepareData("", 1294);
                ErrorCode _e6 = prepareData("", 1550);

                // data sent succesfully
                if (_e1 == ErrorCode.NoError && _e2 == ErrorCode.NoError && _e3 == ErrorCode.NoError &&
                    _e4 == ErrorCode.NoError && _e5 == ErrorCode.NoError && _e6 == ErrorCode.NoError)
                {
                    var form = new popupPlcConnection("Data sent succesfully", "", true);
                    form.Show();
                }
                // an error ocurred while sending any if the string
                else
                {
                    var form = new popupPlcConnection("Error occured while sending data", "Check conncetion with the PLC", false);
                    form.Show();
                }
            }   
        }

        /// <summary>
        /// Save strings to byte[] arrays and send them to passed address
        /// </summary>
        /// <param name="_str"> send data as string </param>
        /// <param name="rcv_byte"> address (offset) of the variable in the PLC </param>
        /// <returns> ErrorCode variable, returned by Plc.WriteBytes() method </returns>
        private ErrorCode prepareData(string _str, int rcv_byte)
        {
            byte[] _bytes = S7.Net.Types.String.ToByteArray(_str);  // string converted to byte[] array 
            // max. length of string and its actual length - numbers read by PLC as first two chars of string
            byte max_len = (byte)100;                               
            byte actual_len = (byte)_str.Length;

            // list of byte variables - prepare message for PLC
            List<byte> Message = new List<byte>();
            Message.Add(max_len);
            Message.Add(actual_len);
            Message.AddRange(_bytes);

            ErrorCode _error = ErrorCode.ConnectionError;   // initialization of returned variable

            if (Global.MainPlc != null)                     // Plc variable is initialized
            {
                _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 30, rcv_byte, Message.ToArray());     // send data
            }

            // return information about status of sent message
            return _error;
        }

        #endregion


    }

}
