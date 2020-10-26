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

namespace XML_Reader_GUI.Secondary_Forms
{
    public partial class SegmentDataForm : Form
    {
        private XMLReader reader;           // local copy of XMLReader variable

        /// <summary>
        /// variables created to control buttons
        /// </summary>
        private IconButton currentButton;   // variable of currently active button
        private Color activeColor;          // color of active buttons
        private Color passiveColor;         // color of desactivated buttons

        public SegmentDataForm(XMLReader xmlFile)
        {
            InitializeComponent();  // initialize child form
            this.AutoScroll = true;

            reader = xmlFile;       // save data from XML file to local variable
            activeColor = Color.FromArgb(152, 255, 255);    // color of button while active
            passiveColor = Color.DimGray;                   // color of button while desactivated/unused
            panelSegmentsHeader.Height = 35;                // hiding the panel

            ///
            /// Saving data from "reader" variable to Data Grid
            ///
            if (reader!=null)   // if xml has been read and XMLReader variable has been passed to local copy
            {
                // create row for each segment
                for (int i = 0; i < reader.segmentData.Segments.Count; i++)
                {   
                    // segment data prepared for display
                    string id = reader.segmentData.Segments[i].Id;
                    string s = reader.segmentData.Segments[i].Status;
                    string l = reader.segmentData.Segments[i].Level;
                    string w_a = reader.segmentData.Segments[i].Wait_area;
                    string p_s = reader.segmentData.Segments[i].Pivot_start;
                    string p_e = reader.segmentData.Segments[i].Pivot_end;
                    int p_c = reader.segmentData.Segments[i].pts.Count;
                    int s_o_c = reader.segmentData.Segments[i].seg_overlap.Count;
                    // add row to data grid
                    dataGridView1.Rows.Add(                       
                        new object[]
                        {
                            id, s, l, w_a, p_s, p_e, p_c, s_o_c
                        } 
                        );
                }
            }
        }



        #region Buttons on-click methods

        /// <summary>
        /// Segment data on click method
        /// </summary>
        /// <param name="sender"> clicked button </param>
        /// <param name="e"></param>
        private void iconButtonSegmentData_Click(object sender, EventArgs e)
        {
            if((IconButton)sender == currentButton)
            { 
                DesactivateButton();
            }
            else 
            {              
                ActivateButton(sender);
            }
        }

        #endregion



        #region Buttons Methods

        /// <summary>
        /// Activate Button
        /// </summary>
        /// <param name="senderButton">  </param>
        private void ActivateButton(object senderButton)
        {
            panelSegmentsHeader.Height = 370;
            currentButton = (IconButton)senderButton;
            currentButton.ForeColor = activeColor;
            currentButton.IconColor = activeColor;
        }

        /// <summary>
        /// Desactivate currently active button
        /// </summary>
        private void DesactivateButton()
        {
            panelSegmentsHeader.Height = 35;
            currentButton.ForeColor = passiveColor;
            currentButton.IconColor = passiveColor;
            currentButton = null;
        }


        #endregion

    }


}
