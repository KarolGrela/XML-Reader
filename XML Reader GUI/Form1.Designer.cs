namespace XML_Reader_GUI
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonLeftBorderPanel = new System.Windows.Forms.Panel();
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.buttonZones = new System.Windows.Forms.Button();
            this.buttonFileInfo = new System.Windows.Forms.Button();
            this.buttonSymbolicPointsGroups = new System.Windows.Forms.Button();
            this.buttonSymbolicPoints = new System.Windows.Forms.Button();
            this.buttonPosinitPoints = new System.Windows.Forms.Button();
            this.buttonSegmentData = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.buttonLeftBorderPanel);
            this.panelSideMenu.Controls.Add(this.labelTopLeft);
            this.panelSideMenu.Controls.Add(this.buttonZones);
            this.panelSideMenu.Controls.Add(this.buttonFileInfo);
            this.panelSideMenu.Controls.Add(this.buttonSymbolicPointsGroups);
            this.panelSideMenu.Controls.Add(this.buttonSymbolicPoints);
            this.panelSideMenu.Controls.Add(this.buttonPosinitPoints);
            this.panelSideMenu.Controls.Add(this.buttonSegmentData);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(271, 622);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseMove);
            // 
            // buttonLeftBorderPanel
            // 
            this.buttonLeftBorderPanel.BackColor = System.Drawing.Color.White;
            this.buttonLeftBorderPanel.Location = new System.Drawing.Point(0, 95);
            this.buttonLeftBorderPanel.Name = "buttonLeftBorderPanel";
            this.buttonLeftBorderPanel.Size = new System.Drawing.Size(10, 70);
            this.buttonLeftBorderPanel.TabIndex = 2;
            this.buttonLeftBorderPanel.Visible = false;
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.Cursor = System.Windows.Forms.Cursors.No;
            this.labelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTopLeft.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(271, 92);
            this.labelTopLeft.TabIndex = 9;
            this.labelTopLeft.Text = "XML Reader GUI";
            this.labelTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopLeft.Click += new System.EventHandler(this.labelTopLeft_Click);
            // 
            // buttonZones
            // 
            this.buttonZones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonZones.FlatAppearance.BorderSize = 0;
            this.buttonZones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZones.Location = new System.Drawing.Point(0, 445);
            this.buttonZones.Name = "buttonZones";
            this.buttonZones.Size = new System.Drawing.Size(271, 70);
            this.buttonZones.TabIndex = 8;
            this.buttonZones.Text = "Zones";
            this.buttonZones.UseVisualStyleBackColor = false;
            this.buttonZones.Click += new System.EventHandler(this.buttonZones_Click);
            // 
            // buttonFileInfo
            // 
            this.buttonFileInfo.FlatAppearance.BorderSize = 0;
            this.buttonFileInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileInfo.Location = new System.Drawing.Point(0, 95);
            this.buttonFileInfo.Name = "buttonFileInfo";
            this.buttonFileInfo.Size = new System.Drawing.Size(271, 70);
            this.buttonFileInfo.TabIndex = 6;
            this.buttonFileInfo.Text = "File Info";
            this.buttonFileInfo.UseVisualStyleBackColor = true;
            this.buttonFileInfo.Click += new System.EventHandler(this.buttonFileInfo_Click);
            // 
            // buttonSymbolicPointsGroups
            // 
            this.buttonSymbolicPointsGroups.FlatAppearance.BorderSize = 0;
            this.buttonSymbolicPointsGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSymbolicPointsGroups.Location = new System.Drawing.Point(0, 375);
            this.buttonSymbolicPointsGroups.Name = "buttonSymbolicPointsGroups";
            this.buttonSymbolicPointsGroups.Size = new System.Drawing.Size(271, 70);
            this.buttonSymbolicPointsGroups.TabIndex = 7;
            this.buttonSymbolicPointsGroups.Text = "Symbolic Points Groups";
            this.buttonSymbolicPointsGroups.UseVisualStyleBackColor = true;
            this.buttonSymbolicPointsGroups.Click += new System.EventHandler(this.buttonSymbolicPointsGroups_Click);
            // 
            // buttonSymbolicPoints
            // 
            this.buttonSymbolicPoints.FlatAppearance.BorderSize = 0;
            this.buttonSymbolicPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSymbolicPoints.Location = new System.Drawing.Point(0, 305);
            this.buttonSymbolicPoints.Name = "buttonSymbolicPoints";
            this.buttonSymbolicPoints.Size = new System.Drawing.Size(271, 70);
            this.buttonSymbolicPoints.TabIndex = 7;
            this.buttonSymbolicPoints.Text = "Symbolic Points";
            this.buttonSymbolicPoints.UseVisualStyleBackColor = true;
            this.buttonSymbolicPoints.Click += new System.EventHandler(this.buttonSymbolicPoints_Click);
            // 
            // buttonPosinitPoints
            // 
            this.buttonPosinitPoints.FlatAppearance.BorderSize = 0;
            this.buttonPosinitPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosinitPoints.Location = new System.Drawing.Point(0, 235);
            this.buttonPosinitPoints.Name = "buttonPosinitPoints";
            this.buttonPosinitPoints.Size = new System.Drawing.Size(271, 70);
            this.buttonPosinitPoints.TabIndex = 7;
            this.buttonPosinitPoints.Text = "Posinit Points";
            this.buttonPosinitPoints.UseVisualStyleBackColor = true;
            this.buttonPosinitPoints.Click += new System.EventHandler(this.buttonPosinitPoints_Click);
            // 
            // buttonSegmentData
            // 
            this.buttonSegmentData.FlatAppearance.BorderSize = 0;
            this.buttonSegmentData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSegmentData.Location = new System.Drawing.Point(0, 165);
            this.buttonSegmentData.Name = "buttonSegmentData";
            this.buttonSegmentData.Size = new System.Drawing.Size(271, 70);
            this.buttonSegmentData.TabIndex = 7;
            this.buttonSegmentData.Text = "Segment Data";
            this.buttonSegmentData.UseVisualStyleBackColor = true;
            this.buttonSegmentData.Click += new System.EventHandler(this.buttonSegmentData_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(271, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(916, 35);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(881, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTop.Location = new System.Drawing.Point(271, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(881, 35);
            this.labelTop.TabIndex = 3;
            this.labelTop.Text = "Main Screen";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMainMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1187, 622);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFileInfo;
        private System.Windows.Forms.Button buttonZones;
        private System.Windows.Forms.Button buttonSymbolicPointsGroups;
        private System.Windows.Forms.Button buttonSymbolicPoints;
        private System.Windows.Forms.Button buttonPosinitPoints;
        private System.Windows.Forms.Button buttonSegmentData;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Panel buttonLeftBorderPanel;
        private System.Windows.Forms.Label labelTop;
    }
}

