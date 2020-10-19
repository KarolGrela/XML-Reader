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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSymbolicPointsHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButtonSymbolicPoints = new FontAwesome.Sharp.IconButton();
            this.labelSymbolicPoints = new System.Windows.Forms.Label();
            this.IconType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Name,
            this.ID,
            this.X,
            this.Y,
            this.H,
            this.Draw_x,
            this.Draw_y,
            this.segLinksCount});
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(4, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 332);
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
            // IconType
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IconType.DefaultCellStyle = dataGridViewCellStyle19;
            this.IconType.HeaderText = "IconType";
            this.IconType.Name = "IconType";
            // 
            // Name
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.DefaultCellStyle = dataGridViewCellStyle20;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // ID
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle21;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // X
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.X.DefaultCellStyle = dataGridViewCellStyle22;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Y.DefaultCellStyle = dataGridViewCellStyle23;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // H
            // 
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.H.DefaultCellStyle = dataGridViewCellStyle24;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // Draw_x
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Draw_x.DefaultCellStyle = dataGridViewCellStyle25;
            this.Draw_x.HeaderText = "Draw_x";
            this.Draw_x.Name = "Draw_x";
            // 
            // Draw_y
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Draw_y.DefaultCellStyle = dataGridViewCellStyle26;
            this.Draw_y.HeaderText = "Draw_y";
            this.Draw_y.Name = "Draw_y";
            // 
            // segLinksCount
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.segLinksCount.DefaultCellStyle = dataGridViewCellStyle27;
            this.segLinksCount.HeaderText = "segLinksCount";
            this.segLinksCount.Name = "segLinksCount";
            // 
            // SymbolicPointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 410);
            this.Controls.Add(this.panelSymbolicPointsHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            //this.Name = "SymbolicPointsForm";
            //this.Text = this.Name.ToString();
            this.panelSymbolicPointsHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSymbolicPointsHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonSymbolicPoints;
        private System.Windows.Forms.Label labelSymbolicPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn IconType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn segLinksCount;
    }
}