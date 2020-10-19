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
    public partial class FileInfoForm : Form
    {
        private XMLReader reader;
        public FileInfoForm(XMLReader xmlFile)
        {
            InitializeComponent();
            reader = xmlFile;

            if (reader != null)
            {
                labelProductionAreaFill.Text = reader.fileInfo.Production_area;
                labelMachineTypeFill.Text = reader.fileInfo.Machine_type;
                labelMachineTypeIDFill.Text = reader.fileInfo.Machine_type_id;
                labelVersionFill.Text = reader.fileInfo.Version;
                labelEnvironmentVersionFill.Text = reader.fileInfo.Environment_version;
                labelTimestampFill.Text = reader.fileInfo.Timestamp;
            }
            
            //xmlFile.
        }

    }
}
