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
        private XMLReader reader;
        //private Plc plc;
        public FileInfoForm(XMLReader xmlFile)
        {
            InitializeComponent();
            reader = xmlFile;
            //plc = mainPlc;

            if (reader != null)
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
            // zmień na ify
            if(reader != null)
            {
                ErrorCode _e1 = prepareData(reader.fileInfo.Production_area, 270);
                ErrorCode _e2 = prepareData(reader.fileInfo.Machine_type, 526);
                ErrorCode _e3 = prepareData(reader.fileInfo.Machine_type_id, 782);
                ErrorCode _e4 = prepareData(reader.fileInfo.Version, 1038);
                ErrorCode _e5 = prepareData(reader.fileInfo.Environment_version, 1294);
                ErrorCode _e6 = prepareData(reader.fileInfo.Timestamp, 1550);

                if (_e1 == ErrorCode.NoError && _e2 == ErrorCode.NoError && _e3 == ErrorCode.NoError &&
                    _e4 == ErrorCode.NoError && _e5 == ErrorCode.NoError && _e6 == ErrorCode.NoError)
                {
                    var form = new popupPlcConnection("Data sent succesfully", "", true);
                    form.Show();
                }
                else
                {
                    var form = new popupPlcConnection("Error occured while sending data","", false);
                    form.Show();
                }
            }
            else
            {
                ErrorCode _e1 = prepareData("", 270);
                ErrorCode _e2 = prepareData("", 526);
                ErrorCode _e3 = prepareData("", 782);
                ErrorCode _e4 = prepareData("", 1038);
                ErrorCode _e5 = prepareData("", 1294);
                ErrorCode _e6 = prepareData("", 1550);

                if (_e1 == ErrorCode.NoError && _e2 == ErrorCode.NoError && _e3 == ErrorCode.NoError &&
                    _e4 == ErrorCode.NoError && _e5 == ErrorCode.NoError && _e6 == ErrorCode.NoError)
                {
                    var form = new popupPlcConnection("Data sent succesfully", "", true);
                    form.Show();
                }
                else
                {
                    var form = new popupPlcConnection("Error occured while sending data", "Check conncetion with the PLC", false);
                    form.Show();
                }
            }   
        }

        private ErrorCode prepareData(string _str, int rcv_byte)
        {
            byte[] _bytes = S7.Net.Types.String.ToByteArray(_str);  // data 
            byte max_len = (byte)100;
            byte actual_len = (byte)_str.Length;

            List<byte> Message = new List<byte>();
            Message.Add(max_len);
            Message.Add(actual_len);
            Message.AddRange(_bytes);

            ErrorCode _error = ErrorCode.ConnectionError;

            if (Global.MainPlc != null)
            {
                _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 30, rcv_byte, Message.ToArray());     // send data
            }

            return _error;
        }

        #endregion


    }

}
