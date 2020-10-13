using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // dragging form

// TODO:
// drag from label
// fix cursor on top left label
// 

namespace XML_Reader_GUI
{
    public partial class FormMainMenu : Form
    {
        
        #region Mouse Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelSideMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
        


        private Button currentButton;
       
        public FormMainMenu()
        {
            InitializeComponent();
        }

       
        #region Structures

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(152, 255, 255);
            public static Color color2 = Color.FromArgb(102, 255, 255);
            public static Color color3 = Color.FromArgb(51, 255, 255);
            public static Color color4 = Color.FromArgb(0, 255, 255);
            public static Color color5 = Color.FromArgb(0, 204, 204);
            public static Color color6 = Color.FromArgb(0, 153, 153);
        }

        private struct labelHeader
        {
            private static string string0 = "Main Menu";
            private static string string1 = "File Info";
            private static string string2 = "Segment Data";
            private static string string3 = "Posinit Points";
            private static string string4 = "Symbolic Points";
            private static string string5 = "Symbolic Points Groups";
            private static string string6 = "Zones";
        }

        #endregion


        #region Activate/Desactivate Buttons Methods

        /// <summary>
        /// Activate button highlighting and place buttonLeftBorderPanel
        /// </summary>
        /// <param name="senderButton"></param>
        /// <param name="panelColor"></param>
        private void ActivateButton(object senderButton, Color panelColor)
        {
            DisableButton();

            if (senderButton != null) // if a button has been pressed
            {
                currentButton = (Button)senderButton;   //saving sender button data to current button
                
                // changing attributes of clicked button
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
                currentButton.ForeColor = panelColor;

                // changing attriutes of left border panel
                buttonLeftBorderPanel.BackColor = panelColor;
                buttonLeftBorderPanel.Location = new Point(0, currentButton.Location.Y);
                buttonLeftBorderPanel.Visible = true;

                // change text in header label
                setHeadaer();
            }
        }

        /// <summary>
        /// Desactivate previously highlighted buttons
        /// </summary>
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(36, 34, 35);
                currentButton.ForeColor = Color.White;
                buttonLeftBorderPanel.Visible = false;

                currentButton = null;
            }
        }

        private void setHeadaer()
        {
            if(currentButton != null)
            {
                labelTop.Text = currentButton.Text;
            }
        }

        private void resetHeader()
        {
            labelTop.Text = "Main Screen";
        }


        #endregion


        #region On-Click Metohds

        private void buttonFileInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void buttonSegmentData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void buttonPosinitPoints_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void buttonSymbolicPoints_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void buttonSymbolicPointsGroups_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void buttonZones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void labelTopLeft_Click(object sender, EventArgs e)
        {
            DisableButton();
            resetHeader();
        }

        #endregion


    }
}
