using S7.Net;
using System.IO;

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
            this.labelSentData = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelCharSent = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxCharSent = new System.Windows.Forms.TextBox();
            this.labelRcvData = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelZFill = new System.Windows.Forms.Label();
            this.labelCharRcvd = new System.Windows.Forms.Label();
            this.labelCharRcvdFill = new System.Windows.Forms.Label();
            this.labelLifebitFill = new System.Windows.Forms.Label();
            this.labelLifebit = new System.Windows.Forms.Label();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.panelIpNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPlcType
            // 
            this.comboBoxPlcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.comboBoxPlcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPlcType.ForeColor = System.Drawing.Color.White;
            this.comboBoxPlcType.FormattingEnabled = true;
            this.comboBoxPlcType.Items.AddRange(new object[] {
            S7.Net.CpuType.S7200,
            S7.Net.CpuType.S7300,
            S7.Net.CpuType.S7400,
            S7.Net.CpuType.S71200,
            S7.Net.CpuType.S71500});
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
            this.textBoxIpFourth.TabIndex = 22;
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
            this.textBoxIpSecond.TabIndex = 13;
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
            this.buttonConnectWithPlc.Location = new System.Drawing.Point(38, 179);
            this.buttonConnectWithPlc.Name = "buttonConnectWithPlc";
            this.buttonConnectWithPlc.Size = new System.Drawing.Size(155, 59);
            this.buttonConnectWithPlc.TabIndex = 21;
            this.buttonConnectWithPlc.Text = "Connect With PLC";
            this.buttonConnectWithPlc.UseVisualStyleBackColor = false;
            this.buttonConnectWithPlc.Click += new System.EventHandler(this.buttonConnectWithPlc_Click);
            // 
            // labelSentData
            // 
            this.labelSentData.AutoSize = true;
            this.labelSentData.Location = new System.Drawing.Point(441, 42);
            this.labelSentData.Name = "labelSentData";
            this.labelSentData.Size = new System.Drawing.Size(77, 20);
            this.labelSentData.TabIndex = 22;
            this.labelSentData.Text = "Sent Data:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(441, 76);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(34, 20);
            this.labelX.TabIndex = 23;
            this.labelX.Text = "x = ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(441, 108);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(34, 20);
            this.labelY.TabIndex = 24;
            this.labelY.Text = "y = ";
            // 
            // labelCharSent
            // 
            this.labelCharSent.AutoSize = true;
            this.labelCharSent.Location = new System.Drawing.Point(441, 143);
            this.labelCharSent.Name = "labelCharSent";
            this.labelCharSent.Size = new System.Drawing.Size(55, 20);
            this.labelCharSent.TabIndex = 25;
            this.labelCharSent.Text = "char = ";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.ForeColor = System.Drawing.Color.White;
            this.textBoxX.Location = new System.Drawing.Point(481, 76);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 20);
            this.textBoxX.TabIndex = 26;
            this.textBoxX.LostFocus += new System.EventHandler(this.textBoxX_LostFocus);
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY.ForeColor = System.Drawing.Color.White;
            this.textBoxY.Location = new System.Drawing.Point(481, 108);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 20);
            this.textBoxY.TabIndex = 27;
            this.textBoxY.LostFocus += new System.EventHandler(this.textBoxY_LostFocus);
            // 
            // textBoxCharSent
            // 
            this.textBoxCharSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxCharSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCharSent.ForeColor = System.Drawing.Color.White;
            this.textBoxCharSent.Location = new System.Drawing.Point(502, 143);
            this.textBoxCharSent.Name = "textBoxCharSent";
            this.textBoxCharSent.Size = new System.Drawing.Size(32, 20);
            this.textBoxCharSent.TabIndex = 28;
            this.textBoxCharSent.LostFocus += new System.EventHandler(this.textBoxCharSent_LostFocus);
            // 
            // labelRcvData
            // 
            this.labelRcvData.AutoSize = true;
            this.labelRcvData.Location = new System.Drawing.Point(623, 42);
            this.labelRcvData.Name = "labelRcvData";
            this.labelRcvData.Size = new System.Drawing.Size(108, 20);
            this.labelRcvData.TabIndex = 29;
            this.labelRcvData.Text = "Received Data:";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(623, 108);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(84, 20);
            this.labelZ.TabIndex = 30;
            this.labelZ.Text = "z = x + y = ";
            // 
            // labelZFill
            // 
            this.labelZFill.AutoSize = true;
            this.labelZFill.Location = new System.Drawing.Point(703, 108);
            this.labelZFill.Name = "labelZFill";
            this.labelZFill.Size = new System.Drawing.Size(62, 20);
            this.labelZFill.TabIndex = 31;
            this.labelZFill.Text = "no_data";
            // 
            // labelCharRcvd
            // 
            this.labelCharRcvd.AutoSize = true;
            this.labelCharRcvd.Location = new System.Drawing.Point(623, 143);
            this.labelCharRcvd.Name = "labelCharRcvd";
            this.labelCharRcvd.Size = new System.Drawing.Size(55, 20);
            this.labelCharRcvd.TabIndex = 32;
            this.labelCharRcvd.Text = "char = ";
            // 
            // labelCharRcvdFill
            // 
            this.labelCharRcvdFill.AutoSize = true;
            this.labelCharRcvdFill.Location = new System.Drawing.Point(675, 143);
            this.labelCharRcvdFill.Name = "labelCharRcvdFill";
            this.labelCharRcvdFill.Size = new System.Drawing.Size(62, 20);
            this.labelCharRcvdFill.TabIndex = 33;
            this.labelCharRcvdFill.Text = "no_data";
            // 
            // labelLifebitFill
            // 
            this.labelLifebitFill.AutoSize = true;
            this.labelLifebitFill.Location = new System.Drawing.Point(683, 76);
            this.labelLifebitFill.Name = "labelLifebitFill";
            this.labelLifebitFill.Size = new System.Drawing.Size(62, 20);
            this.labelLifebitFill.TabIndex = 35;
            this.labelLifebitFill.Text = "no_data";
            // 
            // labelLifebit
            // 
            this.labelLifebit.AutoSize = true;
            this.labelLifebit.Location = new System.Drawing.Point(623, 76);
            this.labelLifebit.Name = "labelLifebit";
            this.labelLifebit.Size = new System.Drawing.Size(54, 20);
            this.labelLifebit.TabIndex = 34;
            this.labelLifebit.Text = "Lifebit:";
            // 
            // buttonSendData
            // 
            this.buttonSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonSendData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSendData.FlatAppearance.BorderSize = 0;
            this.buttonSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendData.ForeColor = System.Drawing.Color.White;
            this.buttonSendData.Location = new System.Drawing.Point(445, 179);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(89, 41);
            this.buttonSendData.TabIndex = 36;
            this.buttonSendData.Text = "Send Data";
            this.buttonSendData.UseVisualStyleBackColor = false;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // SendDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.labelLifebitFill);
            this.Controls.Add(this.labelLifebit);
            this.Controls.Add(this.labelCharRcvdFill);
            this.Controls.Add(this.labelCharRcvd);
            this.Controls.Add(this.labelZFill);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelRcvData);
            this.Controls.Add(this.textBoxCharSent);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelCharSent);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelSentData);
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
        private System.Windows.Forms.Label labelSentData;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelCharSent;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxCharSent;
        private System.Windows.Forms.Label labelRcvData;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelZFill;
        private System.Windows.Forms.Label labelCharRcvd;
        private System.Windows.Forms.Label labelCharRcvdFill;
        private System.Windows.Forms.Label labelLifebitFill;
        private System.Windows.Forms.Label labelLifebit;
        private System.Windows.Forms.Button buttonSendData;
    }
}