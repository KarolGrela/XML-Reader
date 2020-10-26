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
using FontAwesome.Sharp;
using S7.Net;
using XML_Reader_GUI.popups;

namespace XML_Reader_GUI.Secondary_Forms
{
    public partial class SymbolicPointsForm : Form
    {
        private XMLReader reader;
        //private Plc plc;

        /// <summary>
        /// variables created to control buttons
        /// </summary>
        private IconButton currentButton;   // variable of currently active button
        private Color activeColor;          // color of active buttons
        private Color passiveColor;         // color of desactivated buttons

        public SymbolicPointsForm(XMLReader xmlFile)
        {
            InitializeComponent();  // initialize child form
            this.AutoScroll = true;

            //plc = mainPlc;
            reader = xmlFile;       // save data from XML file to local variable
            activeColor = Color.FromArgb(0, 255, 255);    // color of button while active
            passiveColor = Color.DimGray;                   // color of button while desactivated/unused
            panelSymbolicPointsHeader.Height = 35;                // hiding the panel


            if (reader != null)   // if xml has been read and XMLReader variable has been passed to local copy
            {
                // create row for each segment
                for (int i = 0; i < reader.symbolicPoints.symbolic_points_list.Count; i++)
                {
                    // segment data prepared for display
                    string icon_type = reader.symbolicPoints.symbolic_points_list[i].Icon_type;
                    string name = reader.symbolicPoints.symbolic_points_list[i].Name;
                    string id = reader.symbolicPoints.symbolic_points_list[i].Id;
                    string x = reader.symbolicPoints.symbolic_points_list[i].X;
                    string y = reader.symbolicPoints.symbolic_points_list[i].Y;
                    string h = reader.symbolicPoints.symbolic_points_list[i].H;
                    string draw_x = reader.symbolicPoints.symbolic_points_list[i].Drawx;
                    string draw_y = reader.symbolicPoints.symbolic_points_list[i].Drawy;
                    int s_l_c = reader.symbolicPoints.symbolic_points_list[i].segment_links.Count;

                    // add row to data grid
                    dataGridView1.Rows.Add(
                        new object[]
                        {
                            icon_type, name, id, x, y, h, draw_x, draw_y, s_l_c
                        }   );
                }
            }
        }


        #region Buttons on-click methods

        /// <summary>
        /// Segment data on click method
        /// </summary>
        /// <param name="sender"> clicked button </param>
        /// <param name="e"></param>
        private void iconButtonSymbolicPoints_Click(object sender, EventArgs e)
        {
            if ((IconButton)sender == currentButton)
            {
                panelSymbolicPointsHeader.Height = 35;
                DesactivateButton();
            }
            else
            {
                panelSymbolicPointsHeader.Height = 370;
                ActivateButton(sender);
            }
        }


        private void buttonSendToPlc_Click(object sender, EventArgs e)
        {
            if (reader != null && Global.MainPlc != null)
            {
                if (reader.symbolicPoints.symbolic_points_list.Count() == 0)
                {
                    var form = new popupPlcConnection("XML File has no symbolic points", "", false);
                    form.Show();
                }
                else
                {
                    // send amount of symbolic points
                    short count = (short)reader.symbolicPoints.symbolic_points_list.Count();
                    // converting integer to byte[] array and reversing order (S7 uses different notation)
                    byte[] _byte = BitConverter.GetBytes(count);
                    Array.Reverse(_byte);
                    ErrorCode _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 31, 0, _byte);     // send data
                    if(_error == ErrorCode.NoError)
                    {
                        int DBindex = 2;
                        bool break_loop = false;
                        for (int i = 0; i < reader.symbolicPoints.symbolic_points_list.Count(); i++)
                        {
                            ErrorCode err1 = prepareData(reader.symbolicPoints.symbolic_points_list[i].Icon_type, DBindex);
                            ErrorCode err2 = prepareData(reader.symbolicPoints.symbolic_points_list[i].Id, DBindex + 10);
                            DBindex += 20;

                            if(err1 != ErrorCode.NoError || err2 != ErrorCode.NoError)
                            {
                                break_loop = true;
                                break;
                            }
                        }

                        if(break_loop)
                        {
                            var form = new popupPlcConnection("Error occured while sending data", $"{(reader.symbolicPoints.symbolic_points_list.Count()-2)/20} of {reader.symbolicPoints.symbolic_points_list.Count()} Symbolic Points have been sent", false);
                            form.Show();
                        }
                        else
                        {
                            var form = new popupPlcConnection("Data sent succesfully", "", true);
                            form.Show();
                        }

                    }
                    else
                    {
                        var form = new popupPlcConnection("Data haven't been sent", $"Encountered difficulty:\n{_error}", false);
                        form.Show();
                    }

                }
            }
            else if (reader == null)
            {
                var form = new popupPlcConnection("An XML file hasn't been uploaded", "Uplad an XML File", false);
                form.Show();
            }
            else if (Global.MainPlc == null)
            {
                var form = new popupPlcConnection("PLC isn't connected", "", false);
                form.Show();
            }
        }

        #endregion



        #region Slide Button Methods

        /// <summary>
        /// Activate Button
        /// </summary>
        /// <param name="senderButton">  </param>
        private void ActivateButton(object senderButton)
        {
            currentButton = (IconButton)senderButton;
            currentButton.ForeColor = activeColor;
            currentButton.IconColor = activeColor;
        }

        /// <summary>
        /// Desactivate currently active button
        /// </summary>
        private void DesactivateButton()
        {
            currentButton.ForeColor = passiveColor;
            currentButton.IconColor = passiveColor;
            currentButton = null;
        }







        #endregion


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
                _error = Global.MainPlc.WriteBytes(DataType.DataBlock, 31, rcv_byte, Message.ToArray());     // send data
            }

            return _error;
        }

    }





}
