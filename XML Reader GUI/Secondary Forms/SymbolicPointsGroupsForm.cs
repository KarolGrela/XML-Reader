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

namespace XML_Reader_GUI.Secondary_Forms
{
    public partial class SymbolicPointsGroupsForm : Form
    {
        private XMLReader reader;
        public SymbolicPointsGroupsForm(XMLReader xmlFile)
        {
            InitializeComponent();
            reader = xmlFile;
        }
    }
    
}
