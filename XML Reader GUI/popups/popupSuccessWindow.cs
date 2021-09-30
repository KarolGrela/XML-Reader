using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;   // dragging form
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Reader_GUI
{
    public partial class popupSuccessWindow : Form
    {
        public popupSuccessWindow(string header, string message, string stack)
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;

            // text fields
            this.labelTop.Text = header;
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



    }
}
