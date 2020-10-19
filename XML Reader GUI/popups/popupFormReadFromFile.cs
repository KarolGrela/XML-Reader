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

namespace XML_Reader_GUI.popups
{
    public partial class popupFormReadFromFile : Form
    {
        public popupFormReadFromFile(string message, string stack)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;

            // display exception message
            this.labelMessage.Text = message;
            this.labelStackTrace.Text = stack;
        }


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

        private void labelTop_MouseMove(object sender, MouseEventArgs e)
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
            this.Close();
        }

        #endregion
    }
}
