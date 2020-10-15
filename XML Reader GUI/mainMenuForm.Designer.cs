namespace XML_Reader_GUI
{
    partial class mainMenuForm
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
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.labelTop = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelIndicator = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelMainScreen = new System.Windows.Forms.Label();
            this.buttonBrowseForFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonReadBrowsedFile = new System.Windows.Forms.Button();
            this.labelOR = new System.Windows.Forms.Label();
            this.buttonReadFileFromFolder = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.buttonLeftBorderPanel);
            this.panelSideMenu.Controls.Add(this.labelTopLeft);
            this.panelSideMenu.Controls.Add(this.buttonZones);
            this.panelSideMenu.Controls.Add(this.buttonFileInfo);
            this.panelSideMenu.Controls.Add(this.buttonSymbolicPointsGroups);
            this.panelSideMenu.Controls.Add(this.buttonSymbolicPoints);
            this.panelSideMenu.Controls.Add(this.buttonPosinitPoints);
            this.panelSideMenu.Controls.Add(this.buttonSegmentData);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(271, 544);
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
            this.labelTopLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTopLeft.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTopLeft.ForeColor = System.Drawing.Color.White;
            this.labelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(271, 92);
            this.labelTopLeft.TabIndex = 9;
            this.labelTopLeft.Text = "XML Reader GUI";
            this.labelTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopLeft.Click += new System.EventHandler(this.labelTopLeft_Click);
            this.labelTopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTopLeft_MouseMove);
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
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelTop.Controls.Add(this.iconButtonMinimize);
            this.panelTop.Controls.Add(this.iconButtonExit);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Location = new System.Drawing.Point(272, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(911, 35);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimize.IconSize = 16;
            this.iconButtonMinimize.Location = new System.Drawing.Point(837, 0);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Rotation = 0D;
            this.iconButtonMinimize.Size = new System.Drawing.Size(35, 35);
            this.iconButtonMinimize.TabIndex = 5;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            this.iconButtonMinimize.MouseEnter += new System.EventHandler(this.iconButtonMinimize_MouseEnter);
            this.iconButtonMinimize.MouseLeave += new System.EventHandler(this.iconButtonMinimize_MouseLeave);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconSize = 16;
            this.iconButtonExit.Location = new System.Drawing.Point(873, 0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(35, 35);
            this.iconButtonExit.TabIndex = 4;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            this.iconButtonExit.MouseEnter += new System.EventHandler(this.iconButtonExit_MouseEnter);
            this.iconButtonExit.MouseLeave += new System.EventHandler(this.iconButtonExit_MouseLeave);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTop.Location = new System.Drawing.Point(-1, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(832, 35);
            this.labelTop.TabIndex = 3;
            this.labelTop.Text = "Main Screen";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTop_MouseMove);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelIndicator
            // 
            this.panelIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelIndicator.Location = new System.Drawing.Point(272, 35);
            this.panelIndicator.Name = "panelIndicator";
            this.panelIndicator.Size = new System.Drawing.Size(911, 7);
            this.panelIndicator.TabIndex = 8;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelDesktop.Controls.Add(this.labelMainScreen);
            this.panelDesktop.Controls.Add(this.buttonBrowseForFile);
            this.panelDesktop.Controls.Add(this.textBoxPath);
            this.panelDesktop.Controls.Add(this.buttonReadBrowsedFile);
            this.panelDesktop.Controls.Add(this.labelOR);
            this.panelDesktop.Controls.Add(this.buttonReadFileFromFolder);
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(272, 41);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(911, 504);
            this.panelDesktop.TabIndex = 9;
            // 
            // labelMainScreen
            // 
            this.labelMainScreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMainScreen.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelMainScreen.Location = new System.Drawing.Point(284, 54);
            this.labelMainScreen.Name = "labelMainScreen";
            this.labelMainScreen.Size = new System.Drawing.Size(323, 30);
            this.labelMainScreen.TabIndex = 15;
            this.labelMainScreen.Text = "Read XML file from folder or path";
            // 
            // buttonBrowseForFile
            // 
            this.buttonBrowseForFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBrowseForFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonBrowseForFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBrowseForFile.FlatAppearance.BorderSize = 0;
            this.buttonBrowseForFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseForFile.Location = new System.Drawing.Point(718, 167);
            this.buttonBrowseForFile.Name = "buttonBrowseForFile";
            this.buttonBrowseForFile.Size = new System.Drawing.Size(169, 29);
            this.buttonBrowseForFile.TabIndex = 11;
            this.buttonBrowseForFile.Text = "Browse for XML file";
            this.buttonBrowseForFile.UseVisualStyleBackColor = false;
            this.buttonBrowseForFile.Click += new System.EventHandler(this.buttonBrowseForFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPath.ForeColor = System.Drawing.Color.White;
            this.textBoxPath.Location = new System.Drawing.Point(106, 171);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(577, 20);
            this.textBoxPath.TabIndex = 10;
            // 
            // buttonReadBrowsedFile
            // 
            this.buttonReadBrowsedFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReadBrowsedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonReadBrowsedFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReadBrowsedFile.FlatAppearance.BorderSize = 0;
            this.buttonReadBrowsedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadBrowsedFile.Location = new System.Drawing.Point(514, 216);
            this.buttonReadBrowsedFile.Name = "buttonReadBrowsedFile";
            this.buttonReadBrowsedFile.Size = new System.Drawing.Size(169, 27);
            this.buttonReadBrowsedFile.TabIndex = 12;
            this.buttonReadBrowsedFile.Text = "Read XML File";
            this.buttonReadBrowsedFile.UseVisualStyleBackColor = false;
            this.buttonReadBrowsedFile.Click += new System.EventHandler(this.buttonReadBrowsedFile_Click);
            // 
            // labelOR
            // 
            this.labelOR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOR.AutoSize = true;
            this.labelOR.BackColor = System.Drawing.Color.Transparent;
            this.labelOR.Location = new System.Drawing.Point(384, 266);
            this.labelOR.Name = "labelOR";
            this.labelOR.Size = new System.Drawing.Size(49, 20);
            this.labelOR.TabIndex = 14;
            this.labelOR.Text = "- OR -";
            // 
            // buttonReadFileFromFolder
            // 
            this.buttonReadFileFromFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReadFileFromFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonReadFileFromFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReadFileFromFolder.FlatAppearance.BorderSize = 0;
            this.buttonReadFileFromFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadFileFromFolder.Location = new System.Drawing.Point(307, 342);
            this.buttonReadFileFromFolder.Name = "buttonReadFileFromFolder";
            this.buttonReadFileFromFolder.Size = new System.Drawing.Size(222, 58);
            this.buttonReadFileFromFolder.TabIndex = 13;
            this.buttonReadFileFromFolder.Text = "Read XML File From Folder";
            this.buttonReadFileFromFolder.UseVisualStyleBackColor = false;
            this.buttonReadFileFromFolder.Click += new System.EventHandler(this.buttonReadFileFromFolder_Click);
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1183, 544);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelIndicator);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.panelSideMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTop;
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
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Panel panelIndicator;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelMainScreen;
        private System.Windows.Forms.Button buttonBrowseForFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonReadBrowsedFile;
        private System.Windows.Forms.Label labelOR;
        private System.Windows.Forms.Button buttonReadFileFromFolder;
    }
}

