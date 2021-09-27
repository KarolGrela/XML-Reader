namespace XML_Reader_GUI.popups
{
    partial class popupPlcConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popupPlcConnection));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.iconPictureBoxWarning = new FontAwesome.Sharp.IconPictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStackTrace = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(834, 35);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(0, 0);
            this.labelTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(834, 35);
            this.labelTop.TabIndex = 4;
            this.labelTop.Text = "Connection with PLC";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTop_MouseMove);
            // 
            // iconPictureBoxWarning
            // 
            this.iconPictureBoxWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.iconPictureBoxWarning.Cursor = System.Windows.Forms.Cursors.No;
            this.iconPictureBoxWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.iconPictureBoxWarning.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBoxWarning.IconColor = System.Drawing.Color.IndianRed;
            this.iconPictureBoxWarning.IconSize = 105;
            this.iconPictureBoxWarning.Location = new System.Drawing.Point(12, 43);
            this.iconPictureBoxWarning.Name = "iconPictureBoxWarning";
            this.iconPictureBoxWarning.Size = new System.Drawing.Size(110, 105);
            this.iconPictureBoxWarning.TabIndex = 3;
            this.iconPictureBoxWarning.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMessage.Location = new System.Drawing.Point(150, 60);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(542, 68);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "labelMessage";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStackTrace
            // 
            this.labelStackTrace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStackTrace.Location = new System.Drawing.Point(34, 151);
            this.labelStackTrace.Name = "labelStackTrace";
            this.labelStackTrace.Size = new System.Drawing.Size(766, 180);
            this.labelStackTrace.TabIndex = 5;
            this.labelStackTrace.Text = " ";
            this.labelStackTrace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popupPlcConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.labelStackTrace);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.iconPictureBoxWarning);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(850, 400);
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "popupPlcConnection";
            this.Text = "popupXMLReadException";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxWarning;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelStackTrace;
    }
}