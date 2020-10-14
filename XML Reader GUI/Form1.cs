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
using System.IO;
using System.Xml;

// TODO:
// browse for filepath
// childforms for each button
// decision

namespace XML_Reader_GUI
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        //private OpenFileDialog openFile;
       
        public FormMainMenu()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;

            // setting minimal size of the form
            this.MinimumSize = new Size(1055, 545);

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

        #endregion


        #region Side Menu Buttons Methods

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


        #region Side Menu On-Click Metohds

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

        private void labelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelTopLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion


        #region Top Right Corner Buttons

        // Close window button
        private void iconButtonExit_MouseEnter(object sender, System.EventArgs e)
        {
            iconButtonExit.IconColor = Color.FromArgb(229,204,255);
            iconButtonExit.ForeColor = Color.FromArgb(229, 204, 255);
        }

        private void iconButtonExit_MouseLeave(object sender, System.EventArgs e)
        {
            iconButtonExit.IconColor = Color.White;
            iconButtonExit.ForeColor = Color.White;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Window button
        private void iconButtonMinimize_MouseEnter(object sender, System.EventArgs e)
        {
            iconButtonMinimize.IconColor = Color.FromArgb(229, 204, 255);
            iconButtonMinimize.ForeColor = Color.FromArgb(229, 204, 255);
        }

        private void iconButtonMinimize_MouseLeave(object sender, System.EventArgs e)
        {
            iconButtonMinimize.IconColor = Color.White;
            iconButtonMinimize.ForeColor = Color.White;
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Reading from XML file

        /// <summary>
        /// Initialize logic reading an XML File from path
        /// and saving 
        /// </summary>
        /// <param name="path"> path of an XML file </param>
        private void ReadXMLFile(string path)
        {

        }

        private void buttonBrowseForFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";   // initial directory
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";  // file type filters

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBoxPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonReadBrowsedFile_Click(object sender, EventArgs e)
        {
            if(textBoxPath.Text.EndsWith(".xml"))
            {
                ReadXMLFile(textBoxPath.Text);
            }
            else
            {
                // do nothing
            }
        }

        private void buttonReadFileFromFolder_Click(object sender, EventArgs e)
        {
            // get path of the .exe file
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            
            // remove name of .exe file
            int toRemove = path.Length - 18;
            path = path.Remove(toRemove) + "_XML File";

            var files = Directory.EnumerateFiles(path);

            int count = 0;
            bool fileExists = false;
            foreach (string element in files)
            {
                if (element.EndsWith(".xml"))
                {
                    path = element;
                    fileExists = true;
                    break;
                }
                count++;             
            }

            if (fileExists) 
            {
                ReadXMLFile(path);
            }
            else
            {
                // do nothing
            }

        }

        

        #endregion


    }
}
