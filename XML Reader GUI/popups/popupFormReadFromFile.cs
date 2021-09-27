using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // enables dragging form

namespace XML_Reader_GUI.popups
{
    public partial class popupFormReadFromFile : Form
    {
        public popupFormReadFromFile(string message, string stack)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // display passed exception message
            this.labelMessage.Text = message;
            this.labelStackTrace.Text = stack;
        }


        #region Mouse Drag

        /// <summary>
        /// thid region is necessary, beacause after removing the control box the main form is immovable
        /// </summary>

        // necessary variables and dlls
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // methods enabling dragging form while clicking on:
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
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

        #endregion



   
    }
}
