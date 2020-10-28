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
using XMLReaderClassLibrary;
using System.Security.Cryptography;
using System.Diagnostics.Tracing;
using XML_Reader_GUI.Secondary_Forms;
using XML_Reader_GUI.popups;
using S7.Net;


namespace XML_Reader_GUI
{
    public partial class mainMenuForm : Form
    {
        private Button currentButton;
        private Form currentChildForm;

        private XMLReader reader;

        public mainMenuForm()
        {
            InitializeComponent();

            // prevents icon flittering
            this.DoubleBuffered = true;

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;

            // setting minimal size of the form
            this.MinimumSize = new Size(1055, 615);

            // prevents maximized window from hiding task bar
            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            public static Color color7 = Color.FromArgb(39, 37, 38);
            public static Color color8 = Color.FromArgb(184, 40, 91);
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
                buttonLeftBorderPanel.BringToFront();
                // change text in header label
                setHeader();
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

        /// <summary>
        /// Open new form inside of the main form
        /// </summary>
        /// <param name="childForm"> Template of new form </param>
        private void OpenChildForm(Form childForm)
        {
            if (childForm != currentChildForm)
            {
                if (currentChildForm != null) currentChildForm.Close();

                currentChildForm = childForm;                       // saving a reference to the child form inside of the main form
                childForm.TopLevel = false;                         // enables child form to be docked to panel "panelDesktop"
                childForm.FormBorderStyle = FormBorderStyle.None;   // delete edge of the form
                childForm.Dock = DockStyle.Fill;                    // fill panel
                panelDesktop.Controls.Add(childForm);               // dock child form to "panelDesktop"
                panelDesktop.Tag = childForm;                       
                childForm.BringToFront();
                childForm.Show();
            }
        }

        /// <summary>
        /// Setting text in panel to one corresponding with an active button
        /// </summary>
        private void setHeader()
        {
            if (currentButton != null)
            {
                labelTop.Text = currentButton.Text;
            }
        }

        /// <summary>
        /// Setting text in panel to "Main Menu"
        /// </summary>
        private void resetHeader()
        {
            labelTop.Text = "Main Screen";
        }

        private void changeIndicatorPanelColor(Color color)
        {
            panelIndicator.BackColor = color;
        }

        #endregion


        #region Side Menu On-Click Metohds

        private void buttonFileInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            changeIndicatorPanelColor(RGBColors.color1);
            OpenChildForm(new FileInfoForm(reader));
        }

        private void buttonSegmentData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            changeIndicatorPanelColor(RGBColors.color2);
            OpenChildForm(new SegmentDataForm(reader));
        }

        private void buttonPosinitPoints_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            changeIndicatorPanelColor(RGBColors.color3);
            OpenChildForm(new PosinitPointsForm(reader));
        }

        private void buttonSymbolicPoints_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            changeIndicatorPanelColor(RGBColors.color4);
            OpenChildForm(new SymbolicPointsForm(reader));
        }

        private void buttonSymbolicPointsGroups_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            changeIndicatorPanelColor(RGBColors.color5);
            OpenChildForm(new SymbolicPointsGroupsForm(reader));
        }

        private void buttonZones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            changeIndicatorPanelColor(RGBColors.color6);
            OpenChildForm(new ZonesForm(reader));
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            changeIndicatorPanelColor(RGBColors.color8);
            OpenChildForm(new SendDataForm(reader));
        }

        private void labelTopLeft_Click(object sender, EventArgs e)
        {
            DisableButton();
            resetHeader();
            changeIndicatorPanelColor(RGBColors.color7);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
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
            iconButtonExit.IconColor = Color.IndianRed;
            iconButtonExit.ForeColor = Color.IndianRed;
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
            iconButtonMinimize.IconColor = Color.IndianRed;
            iconButtonMinimize.ForeColor = Color.IndianRed;
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
            try
            {
                reader = new XMLReader(path);
            }
            catch (Exception ex)
            {
                CallPopup(ex.Message, ex.StackTrace);
            }
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
            if (textBoxPath.Text.EndsWith(".xml"))
            {
                ReadXMLFile(textBoxPath.Text);
            }
            else if (textBoxPath.Text == "")
            {
                CallPopup("No file has been chosen!", "Choose a file!");
            }
            else
            {
                CallPopup("Chosen file is of wrong type!", "Choose a file of a proper type");
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


        #region Exceptions and errors

        private void CallPopup(string header, string text)
        {
            var popup = new popupFormReadFromFile(header, text);
            popup.Show();
        }

        #endregion


    }
}
