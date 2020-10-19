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
    public partial class SymbolicPointsForm : Form
    {
        private XMLReader reader;

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
            
            reader = xmlFile;       // save data from XML file to local variable
            activeColor = Color.FromArgb(152, 255, 255);    // color of button while active
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

        #endregion



        #region Buttons Methods

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

  
    }





}
