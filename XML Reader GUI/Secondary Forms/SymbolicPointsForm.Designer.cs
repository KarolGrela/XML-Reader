namespace XML_Reader_GUI.Secondary_Forms
{
    partial class SymbolicPointsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSymbolicPointsHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButtonSymbolicPoints = new FontAwesome.Sharp.IconButton();
            this.labelSymbolicPoints = new System.Windows.Forms.Label();
            this.buttonSendToPlc = new System.Windows.Forms.Button();
            this.IconType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draw_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draw_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segLinksCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSymbolicPointsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSymbolicPointsHeader
            // 
            this.panelSymbolicPointsHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSymbolicPointsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelSymbolicPointsHeader.Controls.Add(this.dataGridView1);
            this.panelSymbolicPointsHeader.Controls.Add(this.iconButtonSymbolicPoints);
            this.panelSymbolicPointsHeader.Controls.Add(this.labelSymbolicPoints);
            this.panelSymbolicPointsHeader.Location = new System.Drawing.Point(12, 12);
            this.panelSymbolicPointsHeader.Name = "panelSymbolicPointsHeader";
            this.panelSymbolicPointsHeader.Size = new System.Drawing.Size(784, 370);
            this.panelSymbolicPointsHeader.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconType,
            this.NameSp,
            this.ID,
            this.X,
            this.Y,
            this.H,
            this.Draw_x,
            this.Draw_y,
            this.segLinksCount});
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // iconButtonSymbolicPoints
            // 
            this.iconButtonSymbolicPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.iconButtonSymbolicPoints.FlatAppearance.BorderSize = 2;
            this.iconButtonSymbolicPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSymbolicPoints.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSymbolicPoints.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonSymbolicPoints.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.iconButtonSymbolicPoints.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonSymbolicPoints.IconSize = 36;
            this.iconButtonSymbolicPoints.Location = new System.Drawing.Point(746, 0);
            this.iconButtonSymbolicPoints.Name = "iconButtonSymbolicPoints";
            this.iconButtonSymbolicPoints.Rotation = 0D;
            this.iconButtonSymbolicPoints.Size = new System.Drawing.Size(38, 35);
            this.iconButtonSymbolicPoints.TabIndex = 1;
            this.iconButtonSymbolicPoints.UseVisualStyleBackColor = false;
            this.iconButtonSymbolicPoints.Click += new System.EventHandler(this.iconButtonSymbolicPoints_Click);
            // 
            // labelSymbolicPoints
            // 
            this.labelSymbolicPoints.Location = new System.Drawing.Point(0, 0);
            this.labelSymbolicPoints.Name = "labelSymbolicPoints";
            this.labelSymbolicPoints.Size = new System.Drawing.Size(749, 35);
            this.labelSymbolicPoints.TabIndex = 1;
            this.labelSymbolicPoints.Text = "SymbolicPoints";
            this.labelSymbolicPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSendToPlc
            // 
            this.buttonSendToPlc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendToPlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonSendToPlc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSendToPlc.FlatAppearance.BorderSize = 0;
            this.buttonSendToPlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendToPlc.ForeColor = System.Drawing.Color.White;
            this.buttonSendToPlc.Location = new System.Drawing.Point(606, 397);
            this.buttonSendToPlc.Name = "buttonSendToPlc";
            this.buttonSendToPlc.Size = new System.Drawing.Size(190, 30);
            this.buttonSendToPlc.TabIndex = 22;
            this.buttonSendToPlc.Text = "Send to PLC";
            this.buttonSendToPlc.UseVisualStyleBackColor = false;
            this.buttonSendToPlc.Click += new System.EventHandler(this.buttonSendToPlc_Click);
            // 
            // IconType
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IconType.DefaultCellStyle = dataGridViewCellStyle1;
            this.IconType.HeaderText = "IconType";
            this.IconType.Name = "IconType";
            // 
            // NameSp
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameSp.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameSp.HeaderText = "Name";
            this.NameSp.Name = "NameSp";
            // 
            // ID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // X
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.X.DefaultCellStyle = dataGridViewCellStyle4;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Y.DefaultCellStyle = dataGridViewCellStyle5;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // H
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.H.DefaultCellStyle = dataGridViewCellStyle6;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // Draw_x
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Draw_x.DefaultCellStyle = dataGridViewCellStyle7;
            this.Draw_x.HeaderText = "Draw_x";
            this.Draw_x.Name = "Draw_x";
            // 
            // Draw_y
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Draw_y.DefaultCellStyle = dataGridViewCellStyle8;
            this.Draw_y.HeaderText = "Draw_y";
            this.Draw_y.Name = "Draw_y";
            // 
            // segLinksCount
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.segLinksCount.DefaultCellStyle = dataGridViewCellStyle9;
            this.segLinksCount.HeaderText = "segLinksCount";
            this.segLinksCount.Name = "segLinksCount";
            // 
            // SymbolicPointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 410);
            this.Controls.Add(this.buttonSendToPlc);
            this.Controls.Add(this.panelSymbolicPointsHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SymbolicPointsForm";
            this.panelSymbolicPointsHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSymbolicPointsHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonSymbolicPoints;
        private System.Windows.Forms.Label labelSymbolicPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPName;
        private System.Windows.Forms.Button buttonSendToPlc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IconType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn segLinksCount;
    }
}