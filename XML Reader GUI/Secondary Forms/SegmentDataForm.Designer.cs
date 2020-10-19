using System.Drawing;

namespace XML_Reader_GUI.Secondary_Forms
{
    partial class SegmentDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSegmentsHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButtonSegments = new FontAwesome.Sharp.IconButton();
            this.labelSegments = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PivotStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PivotEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segOverlapCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSegmentsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSegmentsHeader
            // 
            this.panelSegmentsHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSegmentsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelSegmentsHeader.Controls.Add(this.dataGridView1);
            this.panelSegmentsHeader.Controls.Add(this.iconButtonSegments);
            this.panelSegmentsHeader.Controls.Add(this.labelSegments);
            this.panelSegmentsHeader.Location = new System.Drawing.Point(8, 12);
            this.panelSegmentsHeader.Name = "panelSegmentsHeader";
            this.panelSegmentsHeader.Size = new System.Drawing.Size(784, 370);
            this.panelSegmentsHeader.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.Level,
            this.WaitArea,
            this.PivotStart,
            this.PivotEnd,
            this.ptsCount,
            this.segOverlapCount});
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 332);
            this.dataGridView1.TabIndex = 2;
            // 
            // iconButtonSegments
            // 
            this.iconButtonSegments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.iconButtonSegments.FlatAppearance.BorderSize = 2;
            this.iconButtonSegments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSegments.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSegments.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonSegments.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.iconButtonSegments.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonSegments.IconSize = 36;
            this.iconButtonSegments.Location = new System.Drawing.Point(746, 0);
            this.iconButtonSegments.Name = "iconButtonSegments";
            this.iconButtonSegments.Rotation = 0D;
            this.iconButtonSegments.Size = new System.Drawing.Size(38, 35);
            this.iconButtonSegments.TabIndex = 1;
            this.iconButtonSegments.UseVisualStyleBackColor = false;
            this.iconButtonSegments.Click += new System.EventHandler(this.iconButtonSegmentData_Click);
            // 
            // labelSegments
            // 
            this.labelSegments.Location = new System.Drawing.Point(0, 0);
            this.labelSegments.Name = "labelSegments";
            this.labelSegments.Size = new System.Drawing.Size(749, 35);
            this.labelSegments.TabIndex = 1;
            this.labelSegments.Text = "Segments";
            this.labelSegments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle57;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Status
            // 
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Status.DefaultCellStyle = dataGridViewCellStyle58;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Level
            // 
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Level.DefaultCellStyle = dataGridViewCellStyle59;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // WaitArea
            // 
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WaitArea.DefaultCellStyle = dataGridViewCellStyle60;
            this.WaitArea.HeaderText = "WaitArea";
            this.WaitArea.Name = "WaitArea";
            // 
            // PivotStart
            // 
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PivotStart.DefaultCellStyle = dataGridViewCellStyle61;
            this.PivotStart.HeaderText = "PivotStart";
            this.PivotStart.Name = "PivotStart";
            // 
            // PivotEnd
            // 
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PivotEnd.DefaultCellStyle = dataGridViewCellStyle62;
            this.PivotEnd.HeaderText = "PivotEnd";
            this.PivotEnd.Name = "PivotEnd";
            // 
            // ptsCount
            // 
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptsCount.DefaultCellStyle = dataGridViewCellStyle63;
            this.ptsCount.HeaderText = "ptsCount";
            this.ptsCount.Name = "ptsCount";
            // 
            // segOverlapCount
            // 
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.segOverlapCount.DefaultCellStyle = dataGridViewCellStyle64;
            this.segOverlapCount.HeaderText = "segOverlapCount";
            this.segOverlapCount.Name = "segOverlapCount";
            // 
            // SegmentDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 410);
            this.Controls.Add(this.panelSegmentsHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SegmentDataForm";
            this.Text = "FileInfo";
            this.panelSegmentsHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSegmentsHeader;
        private System.Windows.Forms.Label labelSegments;
        private FontAwesome.Sharp.IconButton iconButtonSegments;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PivotStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PivotEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn segOverlapCount;
    }
}