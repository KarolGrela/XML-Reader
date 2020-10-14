using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace XMLReader_Console_App
{
    /*
     * 
     * **********   ALL FIELDS REPRESENTING TEXT IN NODES ARE OF TYPE STRING FOR A FOLLOWING REASON:                                        **********       
     * **********   ALL DATA READ FROM XML FILES ARE SAVED STRING AND IT IS EASIER TO READ DATA AS STRING AND THEN CONVERT THEM IF NEEDED   **********  
     * **********   PLEASE DON'T CHANGE THIS STANDARD                                                                                       **********     
     * 
     */

    /// <summary>
    /// class containng List of Segments[class] and methods used to work on the list
    /// and methods allowing for adding/accesing them
    /// </summary>
    class SegmentData
    {
        #region Fields
        public List<Segment> Segments;      // list of segments       
        #endregion

        #region Constructors
        public SegmentData()
        {
            Segments = new List<Segment>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// add new segment to the list
        /// </summary>
        /// <param name="segment"> segment that will be added to the lsit </param>
        public void AddSegment(Segment segment)
        {
            Segment s1 = new Segment();
            s1 = segment;
            Segments.Add(segment);
        }
        

        /// <summary>
        /// return length of list
        /// </summary>
        /// <returns> length of list </returns>
        public int GetLen()
        {
            return Segments.Count;
        }

        /// <summary>
        /// return copy of segment
        /// </summary>
        /// <param name="index"> index of node that will be returned </param>
        /// <returns> node of index </returns>
        public Segment GetSegment(int index)
        {
            return Segments[index];
        }

        /// <summary>
        /// function saving copy of list Class.Segments to parameter copy 
        /// </summary>
        /// <param name="copy"> copy of list Class.Segments </param>
        public void GetList(List<Segment> copy)
        {
            copy.Clear();                                   // remove all elements from the list
            for (int i = 0; i < Segments.Count; i++)        // add copy of segments to the list
            {                
                copy.Add(Segments[i]);                      
            }
        }

        /// <summary>
        /// Fills string dataString with data
        /// </summary>
        /// <returns> dataString </returns>
        public string DisplayData()
        {
            string dataString = "";
            dataString += $"Segment Data (contains {Segments.Count} segments)\n";
            for (int i = 0; i < Segments.Count; i++)
            {
                // segment data
                dataString += $"    Segment {i + 1}\n";

                dataString += $"    id {Segments[i].Id}\n";
                dataString += $"    status {Segments[i].Status}\n";
                dataString += $"    level {Segments[i].Level}\n";
                dataString += $"    wait_area {Segments[i].Wait_area}\n";
                dataString += $"    pivot_start {Segments[i].Pivot_start}\n";
                dataString += $"    pivot_end {Segments[i].Pivot_end}\n";

                // pts
                dataString += $"    pts (contains {Segments[i].pts.Count} sp)\n";
                for (int j = 0; j < Segments[i].pts.Count; j++)
                {
                    dataString += $"    sp {j + 1}\n";

                    dataString += $"        x {Segments[i].pts[j].X}\n";
                    dataString += $"        y {Segments[i].pts[j].Y}\n";
                    dataString += $"        s {Segments[i].pts[j].S}\n";
                    dataString += $"        t {Segments[i].pts[j].T}\n";
                    dataString += $"        actuator {Segments[i].pts[j].Actuator}\n";
                    dataString += $"        strict_actuator {Segments[i].pts[j].Strict_actuator}\n";
                    dataString += $"        p1 {Segments[i].pts[j].P1}\n";
                    dataString += $"        p2 {Segments[i].pts[j].P2}\n";
                    dataString += $"    /sp\n";
                }
                dataString += $"    /pts\n";

                // start_links
                dataString += $"    start_links (contains {Segments[i].start_links.Count} seg_id)\n";
                for (int j = 0; j < Segments[i].start_links.Count; j++)
                {
                    dataString += $"        start_links {Segments[i].start_links[j]}\n";
                }
                dataString += $"    /start_links\n";

                // end_links
                dataString += $"    end_links (contains {Segments[i].end_links.Count} seg_id)\n";
                for (int j = 0; j < Segments[i].end_links.Count; j++)
                {
                    dataString += $"        end_links {Segments[i].end_links[j]}\n";
                }
                dataString += $"    /end_links\n";

                // seg_overlap
                dataString += $"    Seg_overlap (contains {Segments[i].seg_overlap.Count} seg)\n";
                for (int j = 0; j < Segments[i].seg_overlap.Count; j++)
                {
                    dataString += $"    seg {j + 1}\n";
                    dataString += $"        machine_type_id {Segments[i].seg_overlap[j].Machine_type_id}\n";
                    dataString += $"        id {Segments[i].seg_overlap[j].Id}\n";
                    dataString += $"        overlap_modes {Segments[i].seg_overlap[j].Overlap_modes}\n";
                    dataString += $"    /seg\n";
                }
                dataString += $"    /seg_overlap\n";

                dataString += $"    /Segment\n\n";
            }
            dataString += "/Segment Data";

            return dataString;
        }
        #endregion 

    }

    /// <summary>
    /// Class storing all data from children nodes of <segment>
    /// Consists of:
    ///     its own data (#region Segment data (strings))
    ///     pts (list of sp[class])
    ///     start_links (list of seg_id[string])
    ///     end_links (list of seg_if[string])
    ///     seg_overlap (list of seg[class])
    /// </summary>
    class Segment
    {
        #region Segment data (string)
        private string id;
        private string status;
        private string level;
        private string wait_area;
        private string pivot_start;
        private string pivot_end;

        public string Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string Level { get => level; set => level = value; }
        public string Wait_area { get => wait_area; set => wait_area = value; }
        public string Pivot_start { get => pivot_start; set => pivot_start = value; }
        public string Pivot_end { get => pivot_end; set => pivot_end = value; }
        #endregion

        #region Segments data in lists of type
        public List<Sp> pts;
        public List<string> start_links;
        public List<string> end_links;
        public List<Seg> seg_overlap;
        #endregion

        #region Constructors
        public Segment()
        {
            pts = new List<Sp>();
            start_links = new List<string>();
            end_links = new List<string>();
            seg_overlap = new List<Seg>();
        }
        #endregion
    }

    /// <summary>
    /// Class storing text from <sp> children nodes
    /// </summary>
    class Sp
    {
        #region Children nodes of <sp>
        private string x;
        private string y;
        private string s;
        private string t;
        private string actuator;
        private string strict_actuator;
        private string p1;
        private string p2;

        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
        public string S { get => s; set => s = value; }
        public string T { get => t; set => t = value; }
        public string Actuator { get => actuator; set => actuator = value; }
        public string Strict_actuator { get => strict_actuator; set => strict_actuator = value; }
        public string P1 { get => p1; set => p1 = value; }
        public string P2 { get => p2; set => p2 = value; }
        #endregion
    }


    class Seg
    {
        private string machine_type_id;
        private string id;
        private string overlap_modes;

        public string Machine_type_id { get => machine_type_id; set => machine_type_id = value; }
        public string Id { get => id; set => id = value; }
        public string Overlap_modes { get => overlap_modes; set => overlap_modes = value; }
    }
}
