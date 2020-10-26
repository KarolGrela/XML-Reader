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

namespace XML_Reader_GUI
{
    public partial class popupExceptionForm : Form
    {
        public popupExceptionForm()
        {
            InitializeComponent();      // initialize form

            this.DoubleBuffered = true; // prevent from graphics flicker

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;
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
            this.Close();       // close this form, not whole process
        }

        #endregion
    }
}
