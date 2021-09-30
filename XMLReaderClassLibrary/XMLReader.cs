using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.Xml;
using System.Xml.Linq;
using XMLReaderClassLibrary.DataStorage;
using System.Data.SqlTypes;



namespace XMLReaderClassLibrary
{
    public class XMLReader
    {

        #region Boolean fields

        /// <summary>
        /// Memory fields, allowing program to remember which part of file is being read
        /// </summary>

        private bool b_file_info;
        private bool b_segment_data;
        private bool b_posinit_points;
        private bool b_symbolic_points;
        private bool b_symbolic_point_groups;
        private bool b_zones;

        
        private string s_version;

        #endregion

        #region XML Files
        private XmlReader xmlFile;
        private string path;
        public string Path { get => path; set => path = value; }
        #endregion

        #region Data classes
        public FileInfo fileInfo;
        public PosinitPoints posinitPoints;
        public SegmentData segmentData;
        public SymbolicPointGroups symbolicPointGroups;
        public SymbolicPoints symbolicPoints;
        public Zones zones;
        public bool b_confirmation;

        // string with read data
        public string dataString;

        #endregion

        #region Constructor
        public XMLReader(string path)
        {
            // initialization of data storage class instances
            fileInfo = new FileInfo();
            posinitPoints = new PosinitPoints();
            segmentData = new SegmentData();
            symbolicPointGroups = new SymbolicPointGroups();
            symbolicPoints = new SymbolicPoints();
            zones = new Zones();


            // initialization of boolean fields
            b_file_info = false;
            b_segment_data = false;
            b_posinit_points = false;
            b_symbolic_points = false;
            b_symbolic_point_groups = false;
            b_zones = false;

            // reading verification
            b_confirmation = false;
            s_version = null;

            Path = path;                                // saving path to string
            xmlFile = XmlReader.Create(path);           // initialize XmlReader variable
            ReadFile();                                 // begin reading file

        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="path">  </param>
        /// <returns> true if function finished succesfully, false if excepction occured </returns>
        private bool ReadFile()
        {

            try
            {
                xmlFile.Read();
                s_version = xmlFile.GetAttribute("version");
                if(s_version != null)
                {
                    b_confirmation = true;
                }
            }
            catch (Exception ex)
            {
                xmlFile.Close();
                ArgumentException a_ex = new ArgumentException("XML File has wrong structure or is empty", ex);
                throw a_ex;

                //throw ex;
            }

            // Reading XML file
            while (xmlFile.Read())
            {

                SwitchBooleans(xmlFile.NodeType, xmlFile.Name);

                // calling functions reading xml file
                if (!(b_file_info || b_segment_data || b_posinit_points || b_symbolic_points || b_symbolic_point_groups || b_zones))
                {
                    // do nothing
                    // not necessary
                }
                else if (b_file_info)
                {
                    metFileInfo(xmlFile.NodeType, xmlFile.Name);
                }
                else if (b_segment_data)
                {
                    metSegmentData(xmlFile.NodeType, xmlFile.Name);
                }
                else if (b_posinit_points)
                {
                    metPosinit_point(xmlFile.NodeType, xmlFile.Name);
                }
                else if (b_symbolic_points)
                {
                    metSymbolic_points(xmlFile.NodeType, xmlFile.Name);
                }
                else if (b_symbolic_point_groups)
                {
                    metSymbolic_point_groups(xmlFile.NodeType, xmlFile.Name);
                }
                else if (b_zones)
                {
                    metZones(xmlFile.NodeType, xmlFile.Name);
                }

            }

            return true;
        }

        public string metCreateDataString()
        {
            dataString = "";
            //dataString += fileInfo.DisplayData();
            //dataString += segmentData.DisplayData();
            dataString += symbolicPoints.DisplayData();
            return dataString;
        }


        

        /// <summary>
        /// Switching logic of boolean fields
        /// </summary>
        /// <param name="type"> Type of currently read node </param>
        /// <param name="name"> Name of currently read node </param>
        private void SwitchBooleans(XmlNodeType type, string name)
        {
            /*
             * 
             * *****    SETTING IS DONE BEFORE RESETTING SINCE TRUE ON PREVIOUS STATE IS ONE OF CONDITIONS THAT HAVE TO BE MET FOR RESET TO WR   *****
             * 
             */

            // setting auxiliary bits
            if (type == XmlNodeType.Element && name == "file_info") b_file_info = true;                  // set if node is of type Element and has proper name node 
            if (type == XmlNodeType.Element && name == "segment_data" && b_file_info) b_segment_data = true;                  // set if node is of type Element and has proper name node and previous section is true
            if (name == "posinit_points" && b_segment_data) b_posinit_points = true;                // set if node is of type Element and has proper name node and previous section is true
            if (name == "symbolic_points" && b_posinit_points) b_symbolic_points = true;               // set if node is of type Element and has proper name node and previous section is true
            if (name == "symbolic_point_groups" && b_symbolic_points) b_symbolic_point_groups = true;         // set if node is of type Element and has proper name node and previous section is true
            if (name == "zones" && b_symbolic_point_groups) b_zones = true;                         // set if node is of type Element and has proper name node and previous section is true

            // resetting auxiliary bits
            if (b_segment_data) b_file_info = false;                 // reset if previous section is true
            if (b_posinit_points) b_segment_data = false;
            if (b_symbolic_points) b_posinit_points = false;               // reset if previous section is true
            if (b_symbolic_point_groups) b_symbolic_points = false;              // reset if previous section is true
            if (b_zones) b_symbolic_point_groups = false;        // reset if previous section is true
            if (type == XmlNodeType.EndElement && name == "segment_file_v2") b_zones = false;                        // reset if finishing reading the file

        }

        // reads file_info section
        // every cycle of this loop reads one line from XML
        private void metFileInfo(XmlNodeType type, string name)
        {
            // saving data from file to variables
            // if xmlFile is of type "Element" and of proper name, then:
            if (type == XmlNodeType.Element && name == "version") fileInfo.Version = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "production_area") fileInfo.Production_area = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "machine_type") fileInfo.Machine_type = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "status") fileInfo.Status = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "timestamp") fileInfo.Timestamp = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "SW") fileInfo.SW1 = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "user") fileInfo.User = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "env_version") fileInfo.Environment_version = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "machine_type_id") fileInfo.Machine_type_id = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "custom_prop_1_name") fileInfo.Custom_prop_1_name = xmlFile.ReadElementContentAsString();
            else if (type == XmlNodeType.Element && name == "custom_prop_2_name") fileInfo.Custom_prop_2_name = xmlFile.ReadElementContentAsString();
        }

        // reads segment_data section
        // every call of this method reads one segment
        private void metSegmentData(XmlNodeType type, string name)
        {
            Segment s1 = new Segment();     // variable storing data from currently read segment

            /*
             * Segment is devided to 5 data sets:
             * 1. segment data - 6 private strings
             * 2. pts - a list of instances of SP class
             * 3. start_links - list of strings
             * 4. end_links - list of strings
             * 5. seg_overlap - list of instances of seg class
             * In order for loop to function correctly boolean variables, determining type of currently read data, auxiliary variables are needed:
             */
            bool b_segment_data = false;      // currently reading segment_data etc.
            bool b_pts = false;
            bool b_start_links = false;
            bool b_end_links = false;
            bool b_seg_overlap = false;




            // loop reading one segment
            if (type == XmlNodeType.Element && name == "segment")
            {
                while (xmlFile.Read())
                {
                    // setting/resetting of boolean variables
                    if (((b_pts || b_start_links || b_end_links || b_seg_overlap) == false) && xmlFile.Name == "id")  // set segment_data
                    {
                        b_segment_data = true;
                    }
                    else if (b_segment_data && xmlFile.Name == "pts")                                              // reset segment data / set pts
                    {
                        b_segment_data = false;
                        b_pts = true;
                    }
                    else if (b_pts && xmlFile.Name == "start_links")                                               // reset pts / set start_links
                    {
                        b_pts = false;
                        b_start_links = true;
                    }
                    else if (b_start_links && xmlFile.Name == "end_links")                                         // reset start_links / set end_links
                    {
                        b_start_links = false;
                        b_end_links = true;
                    }
                    else if (b_end_links && xmlFile.Name == "seg_overlap")                                         // reset end_links / set seg_overlap
                    {
                        b_end_links = false;
                        b_seg_overlap = true;
                    }
                    else if (b_seg_overlap && xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "seg_overlap")     // reset seg_overlap
                    {
                        b_seg_overlap = false;
                    }

                    //Console.WriteLine($"{b_segment_data} {b_pts} {b_start_links} {b_end_links} {b_seg_overlap} {xmlFile.NodeType } {xmlFile.Name}");


                    // Saving data to the structure
                    if (b_segment_data)
                    {
                        // reading data
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "id") s1.Id = xmlFile.ReadElementContentAsString();
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "status") s1.Status = xmlFile.ReadElementContentAsString();
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "level") s1.Level = xmlFile.ReadElementContentAsString();
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "wait_area") s1.Wait_area = xmlFile.ReadElementContentAsString();
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "pivot_start") s1.Pivot_start = xmlFile.ReadElementContentAsString();
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "pivot_end") s1.Pivot_end = xmlFile.ReadElementContentAsString();
                    }

                    // saving instances of class sp to list called pts
                    else if (b_pts)
                    {
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "sp")    // reading one sp
                        {
                            Sp sp = new Sp();       // create instance of Sp class, filled in the following loop
                            while (xmlFile.Read())   // read data in one sp
                            {
                                // reading data
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "x") { sp.X = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "y") { sp.Y = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "s") { sp.S = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "t") { sp.T = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "actuator") { sp.Actuator = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "strict_actuator") { sp.Strict_actuator = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "p1") { sp.P1 = xmlFile.ReadElementContentAsString(); }
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "p2") { sp.P2 = xmlFile.ReadElementContentAsString(); }

                                // adding sp instance to the list and breaking the loop
                                if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "sp")
                                {
                                    s1.pts.Add(sp);
                                    break;
                                }
                            }
                        }
                    }

                    // fill list of string start_links with string seg_id
                    else if (b_start_links)
                    {
                        // next xmlFile.Name should be equal to "seg_id" 
                        // it is crucial to start and finish reading data in this loop on proper lines
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "start_links")
                        {
                            // loop reads all seg_id in start_links section
                            while (xmlFile.Read())
                            {
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "seg_id") s1.start_links.Add(xmlFile.ReadElementContentAsString()); // read and add element to list
                                if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "start_links") break;    // end of start_links list - break the loop
                            }
                        }
                    }

                    // fill list of string end_links with string seg_id
                    else if (b_end_links)
                    {
                        // next xmlFile.Name should be equal to "seg_id" 
                        // it is crucial to start and finish reading data in this loop on proper lines
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "end_links")
                        {
                            // loop reads all seg_id in end_links section
                            while (xmlFile.Read())
                            {
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "seg_id") s1.end_links.Add(xmlFile.ReadElementContentAsString()); // read and add element to list
                                if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "end_links") break;  // break the loop;
                            }
                        }
                    }

                    // add one seg to list seg_overlap
                    else if (b_seg_overlap)
                    {
                        // next xmlFile.Name should be equal to "machine_type_id" 
                        // it is crucial to start and finish reading data in this loop on proper lines
                        if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "seg")
                        {
                            Seg seg = new Seg();    // create new instance of Seg class, filled in the following loop
                                                    // loop filling one Seg instance
                            while (xmlFile.Read())
                            {
                                // read and save data
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "machine_type_id") seg.Machine_type_id = xmlFile.ReadElementContentAsString();
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "id") seg.Id = xmlFile.ReadElementContentAsString();
                                if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "overlap_modes") seg.Overlap_modes = xmlFile.ReadElementContentAsString();

                                // save seg to Segment and break loop
                                if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "seg")
                                {
                                    s1.seg_overlap.Add(seg);
                                    break;
                                }
                            }
                        }
                    }

                    // adding segment to the list and breaking the loop up -> segment finished
                    else if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "segment")
                    {
                        segmentData.AddSegment(s1);
                        break;
                    }
                }
            }
        }

        private void metPosinit_point(XmlNodeType type, string name)
        {
            // do nothing
            // we don't know what types of data are saved into this part of XML file
        }

        // reads symbolic_points section
        // every call of this method reads one symbolic_point
        private void metSymbolic_points(XmlNodeType type, string name)
        {
            SymbolicPoint symbolicPoint = new SymbolicPoint();
            if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "symbolic_point")
            {
                while (xmlFile.Read())       // loop reading string data
                {
                    // read and save data unbounded by classes
                    if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "icon_type") { symbolicPoint.Icon_type = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "name") { symbolicPoint.Name = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "id") { symbolicPoint.Id = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "x") { symbolicPoint.X = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "y") { symbolicPoint.Y = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "h") { symbolicPoint.H = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "level") { symbolicPoint.Level = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "opposite_h") { symbolicPoint.Opposite_h = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "drawx") { symbolicPoint.Drawx = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "drawy") { symbolicPoint.Drawy = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "decision_data") { symbolicPoint.Decision_data = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "stop") { symbolicPoint.Stop = xmlFile.ReadElementContentAsString(); }
                    else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "symboltype") { symbolicPoint.Symboltype = xmlFile.ReadElementContentAsString(); }


                    if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "seg")
                    {
                        SymP_Seg seg = new SymP_Seg();
                        while (xmlFile.Read())
                        {
                            // save data to seg
                            if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "machine_type_id") seg.Machine_type_id = xmlFile.ReadElementContentAsString();
                            else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "id") seg.Id = xmlFile.ReadElementContentAsString();
                            else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "point_index") seg.Point_index = xmlFile.ReadElementContentAsString();

                            // save data to list and break loop
                            if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "seg")
                            {
                                symbolicPoint.segment_links.Add(seg);
                                break;
                            }
                        }
                    }


                    if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "resources")
                    {
                        Resources res = new Resources();
                        while (xmlFile.Read())
                        {
                            if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "resource_type")
                                symbolicPoint.resources.Resource_type = xmlFile.ReadElementContentAsString();
                            else if (xmlFile.NodeType == XmlNodeType.Element && xmlFile.Name == "resource_quantity_all")
                                symbolicPoint.resources.Resource_quantity_all = xmlFile.ReadElementContentAsString();
                            else if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "resources") break;
                        }
                    }

                    if (xmlFile.NodeType == XmlNodeType.EndElement && xmlFile.Name == "symbolic_point")
                    {
                        symbolicPoints.symbolic_points_list.Add(symbolicPoint);
                        break;
                    }

                }
            }

        }

        private void metSymbolic_point_groups(XmlNodeType type, string name)
        {
            // do nothing
            // we don't know what types of data are saved into this part of XML file
        }

        private void metZones(XmlNodeType type, string name)
        {
            // do nothing
            // we don't know what types of data are saved into this part of XML file
        }



        #endregion


    }
}
