using S7.Net;

namespace XML_Reader_GUI.Secondary_Forms
{
    partial class SendDataForm
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
            this.comboBoxPlcType = new System.Windows.Forms.ComboBox();
            this.labelPlcType = new System.Windows.Forms.Label();
            this.labelPlcIpNumber = new System.Windows.Forms.Label();
            this.labelRack = new System.Windows.Forms.Label();
            this.labelSlot = new System.Windows.Forms.Label();
            this.textBoxIpFirst = new System.Windows.Forms.TextBox();
            this.panelIpNumber = new System.Windows.Forms.Panel();
            this.textBoxIpFourth = new System.Windows.Forms.TextBox();
            this.textBoxIpThird = new System.Windows.Forms.TextBox();
            this.labelDot3 = new System.Windows.Forms.Label();
            this.labelDot2 = new System.Windows.Forms.Label();
            this.textBoxIpSecond = new System.Windows.Forms.TextBox();
            this.labelDot1 = new System.Windows.Forms.Label();
            this.textBoxRack = new System.Windows.Forms.TextBox();
            this.textBoxSlot = new System.Windows.Forms.TextBox();
            this.buttonConnectWithPlc = new System.Windows.Forms.Button();
            this.panelIpNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPlcType
            // 
            this.comboBoxPlcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.comboBoxPlcType.DataSource = new S7.Net.CpuType[] {
        S7.Net.CpuType.S7200,
        S7.Net.CpuType.S7300,
        S7.Net.CpuType.S7400,
        S7.Net.CpuType.S71200,
        S7.Net.CpuType.S71500};
            this.comboBoxPlcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPlcType.ForeColor = System.Drawing.Color.White;
            this.comboBoxPlcType.FormattingEnabled = true;
            /*this.comboBoxPlcType.Items.AddRange(new object[] {
            S7.Net.CpuType.S7200,
            S7.Net.CpuType.S7300,
            S7.Net.CpuType.S7400,
            S7.Net.CpuType.S71200,
            S7.Net.CpuType.S71500});*/
            this.comboBoxPlcType.Location = new System.Drawing.Point(108, 39);
            this.comboBoxPlcType.Name = "comboBoxPlcType";
            this.comboBoxPlcType.Size = new System.Drawing.Size(238, 28);
            this.comboBoxPlcType.TabIndex = 0;
            // 
            // labelPlcType
            // 
            this.labelPlcType.AutoSize = true;
            this.labelPlcType.Location = new System.Drawing.Point(34, 42);
            this.labelPlcType.Name = "labelPlcType";
            this.labelPlcType.Size = new System.Drawing.Size(68, 20);
            this.labelPlcType.TabIndex = 1;
            this.labelPlcType.Text = "PLC type:";
            // 
            // labelPlcIpNumber
            // 
            this.labelPlcIpNumber.AutoSize = true;
            this.labelPlcIpNumber.Location = new System.Drawing.Point(34, 76);
            this.labelPlcIpNumber.Name = "labelPlcIpNumber";
            this.labelPlcIpNumber.Size = new System.Drawing.Size(106, 20);
            this.labelPlcIpNumber.TabIndex = 2;
            this.labelPlcIpNumber.Text = "PLC IP number:";
            // 
            // labelRack
            // 
            this.labelRack.AutoSize = true;
            this.labelRack.Location = new System.Drawing.Point(34, 108);
            this.labelRack.Name = "labelRack";
            this.labelRack.Size = new System.Drawing.Size(43, 20);
            this.labelRack.TabIndex = 5;
            this.labelRack.Text = "Rack:";
            // 
            // labelSlot
            // 
            this.labelSlot.AutoSize = true;
            this.labelSlot.Location = new System.Drawing.Point(34, 143);
            this.labelSlot.Name = "labelSlot";
            this.labelSlot.Size = new System.Drawing.Size(38, 20);
            this.labelSlot.TabIndex = 7;
            this.labelSlot.Text = "Slot:";
            // 
            // textBoxIpFirst
            // 
            this.textBoxIpFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIpFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxIpFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIpFirst.ForeColor = System.Drawing.Color.White;
            this.textBoxIpFirst.Location = new System.Drawing.Point(0, 0);
            this.textBoxIpFirst.Name = "textBoxIpFirst";
            this.textBoxIpFirst.Size = new System.Drawing.Size(40, 20);
            this.textBoxIpFirst.TabIndex = 11;
            this.textBoxIpFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIpFirst.LostFocus += new System.EventHandler(this.textBoxIpFirst_LostFocus);
            // 
            // panelIpNumber
            // 
            this.panelIpNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panelIpNumber.Controls.Add(this.textBoxIpFourth);
            this.panelIpNumber.Controls.Add(this.textBoxIpThird);
            this.panelIpNumber.Controls.Add(this.labelDot3);
            this.panelIpNumber.Controls.Add(this.labelDot2);
            this.panelIpNumber.Controls.Add(this.textBoxIpSecond);
            this.panelIpNumber.Controls.Add(this.textBoxIpFirst);
            this.panelIpNumber.Controls.Add(this.labelDot1);
            this.panelIpNumber.Location = new System.Drawing.Point(146, 76);
            this.panelIpNumber.Name = "panelIpNumber";
            this.panelIpNumber.Size = new System.Drawing.Size(200, 20);
            this.panelIpNumber.TabIndex = 12;
            // 
            // textBoxIpFourth
            // 
            this.textBoxIpFourth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIpFourth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxIpFourth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIpFourth.ForeColor = System.Drawing.Color.White;
            this.textBoxIpFourth.Location = new System.Drawing.Point(156, 0);
            this.textBoxIpFourth.Name = "textBoxIpFourth";
            this.textBoxIpFourth.Size = new System.Drawing.Size(40, 20);
            this.textBoxIpFourth.TabIndex = 13;
            this.textBoxIpFourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIpFourth.LostFocus += new System.EventHandler(this.textBoxIpFourth_LostFocus);
            // 
            // textBoxIpThird
            // 
            this.textBoxIpThird.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIpThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxIpThird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIpThird.ForeColor = System.Drawing.Color.White;
            this.textBoxIpThird.Location = new System.Drawing.Point(104, 0);
            this.textBoxIpThird.Name = "textBoxIpThird";
            this.textBoxIpThird.Size = new System.Drawing.Size(40, 20);
            this.textBoxIpThird.TabIndex = 18;
            this.textBoxIpThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIpThird.LostFocus += new System.EventHandler(this.textBoxIpThird_LostFocus);
            // 
            // labelDot3
            // 
            this.labelDot3.AutoSize = true;
            this.labelDot3.Location = new System.Drawing.Point(144, 0);
            this.labelDot3.Name = "labelDot3";
            this.labelDot3.Size = new System.Drawing.Size(12, 20);
            this.labelDot3.TabIndex = 17;
            this.labelDot3.Text = ".";
            // 
            // labelDot2
            // 
            this.labelDot2.AutoSize = true;
            this.labelDot2.Location = new System.Drawing.Point(92, 0);
            this.labelDot2.Name = "labelDot2";
            this.labelDot2.Size = new System.Drawing.Size(12, 20);
            this.labelDot2.TabIndex = 13;
            this.labelDot2.Text = ".";
            // 
            // textBoxIpSecond
            // 
            this.textBoxIpSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIpSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxIpSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIpSecond.ForeColor = System.Drawing.Color.White;
            this.textBoxIpSecond.Location = new System.Drawing.Point(52, 0);
            this.textBoxIpSecond.Name = "textBoxIpSecond";
            this.textBoxIpSecond.Size = new System.Drawing.Size(40, 20);
            this.textBoxIpSecond.TabIndex = 18;
            this.textBoxIpSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIpSecond.LostFocus += new System.EventHandler(this.textBoxIpSecond_LostFocus);
            // 
            // labelDot1
            // 
            this.labelDot1.AutoSize = true;
            this.labelDot1.Location = new System.Drawing.Point(40, 0);
            this.labelDot1.Name = "labelDot1";
            this.labelDot1.Size = new System.Drawing.Size(12, 20);
            this.labelDot1.TabIndex = 15;
            this.labelDot1.Text = ".";
            // 
            // textBoxRack
            // 
            this.textBoxRack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxRack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRack.ForeColor = System.Drawing.Color.White;
            this.textBoxRack.Location = new System.Drawing.Point(83, 108);
            this.textBoxRack.Name = "textBoxRack";
            this.textBoxRack.Size = new System.Drawing.Size(32, 20);
            this.textBoxRack.TabIndex = 19;
            this.textBoxRack.LostFocus += new System.EventHandler(this.textBoxRack_LostFocus);
            // 
            // textBoxSlot
            // 
            this.textBoxSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSlot.ForeColor = System.Drawing.Color.White;
            this.textBoxSlot.Location = new System.Drawing.Point(83, 143);
            this.textBoxSlot.Name = "textBoxSlot";
            this.textBoxSlot.Size = new System.Drawing.Size(32, 20);
            this.textBoxSlot.TabIndex = 20;
            this.textBoxSlot.LostFocus += new System.EventHandler(this.textBoxSlot_LostFocus);
            // 
            // buttonConnectWithPlc
            // 
            this.buttonConnectWithPlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonConnectWithPlc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonConnectWithPlc.FlatAppearance.BorderSize = 0;
            this.buttonConnectWithPlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectWithPlc.ForeColor = System.Drawing.Color.White;
            this.buttonConnectWithPlc.Location = new System.Drawing.Point(147, 108);
            this.buttonConnectWithPlc.Name = "buttonConnectWithPlc";
            this.buttonConnectWithPlc.Size = new System.Drawing.Size(155, 59);
            this.buttonConnectWithPlc.TabIndex = 21;
            this.buttonConnectWithPlc.Text = "Connect With PLC";
            this.buttonConnectWithPlc.UseVisualStyleBackColor = false;
            this.buttonConnectWithPlc.Click += new System.EventHandler(this.buttonConnectWithPlc_Click);
            // 
            // SendDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 410);
            this.Controls.Add(this.buttonConnectWithPlc);
            this.Controls.Add(this.textBoxSlot);
            this.Controls.Add(this.textBoxRack);
            this.Controls.Add(this.panelIpNumber);
            this.Controls.Add(this.labelSlot);
            this.Controls.Add(this.labelRack);
            this.Controls.Add(this.labelPlcIpNumber);
            this.Controls.Add(this.labelPlcType);
            this.Controls.Add(this.comboBoxPlcType);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SendDataForm";
            this.Text = this.Name;
            this.panelIpNumber.ResumeLayout(false);
            this.panelIpNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlcType;
        private System.Windows.Forms.Label labelPlcType;
        private System.Windows.Forms.Label labelPlcIpNumber;
        private System.Windows.Forms.Label labelRack;
        private System.Windows.Forms.Label labelSlot;
        private System.Windows.Forms.TextBox textBoxIpFirst;
        private System.Windows.Forms.Panel panelIpNumber;
        private System.Windows.Forms.Label labelDot2;
        private System.Windows.Forms.Label labelDot3;
        private System.Windows.Forms.Label labelDot1;
        private System.Windows.Forms.TextBox textBoxIpFourth;
        private System.Windows.Forms.TextBox textBoxIpThird;
        private System.Windows.Forms.TextBox textBoxIpSecond;
        private System.Windows.Forms.TextBox textBoxRack;
        private System.Windows.Forms.TextBox textBoxSlot;
        private System.Windows.Forms.Button buttonConnectWithPlc;
    }
}