namespace HA1_Roombookin
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHigh = new System.Windows.Forms.RadioButton();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPersonal.SuspendLayout();
            this.grpRoom.SuspendLayout();
            this.grpExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(-1, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1019, 78);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Hotel Room Booking System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPersonal
            // 
            this.grpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.grpPersonal.Controls.Add(this.lblName);
            this.grpPersonal.Controls.Add(this.txtName);
            this.grpPersonal.Controls.Add(this.lblAge);
            this.grpPersonal.Controls.Add(this.txtAge);
            this.grpPersonal.Controls.Add(this.lblNights);
            this.grpPersonal.Controls.Add(this.txtNights);
            this.grpPersonal.Controls.Add(this.lblGuests);
            this.grpPersonal.Controls.Add(this.txtGuests);
            this.grpPersonal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grpPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpPersonal.Location = new System.Drawing.Point(12, 79);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(563, 235);
            this.grpPersonal.TabIndex = 21;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(82, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 38);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Guest Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(272, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 37);
            this.txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAge.Location = new System.Drawing.Point(108, 87);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(168, 38);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Guest Age :";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAge.Location = new System.Drawing.Point(272, 88);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 37);
            this.txtAge.TabIndex = 5;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblNights.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNights.Location = new System.Drawing.Point(4, 131);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(272, 38);
            this.lblNights.TabIndex = 6;
            this.lblNights.Text = "Number of Nights :";
            this.lblNights.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNights.Location = new System.Drawing.Point(272, 131);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(282, 37);
            this.txtNights.TabIndex = 7;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuests.Location = new System.Drawing.Point(6, 178);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(260, 38);
            this.lblGuests.TabIndex = 8;
            this.lblGuests.Text = "Number of Guest :";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGuests
            // 
            this.txtGuests.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGuests.Location = new System.Drawing.Point(272, 179);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(282, 37);
            this.txtGuests.TabIndex = 9;
            // 
            // grpRoom
            // 
            this.grpRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.grpRoom.Controls.Add(this.rdoStandard);
            this.grpRoom.Controls.Add(this.rdoNormal);
            this.grpRoom.Controls.Add(this.rdoHigh);
            this.grpRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpRoom.Location = new System.Drawing.Point(16, 339);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(550, 80);
            this.grpRoom.TabIndex = 22;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Room Type";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.rdoStandard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoStandard.Location = new System.Drawing.Point(9, 34);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(150, 40);
            this.rdoStandard.TabIndex = 11;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.rdoNormal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoNormal.Location = new System.Drawing.Point(198, 34);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(132, 40);
            this.rdoNormal.TabIndex = 12;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHigh
            // 
            this.rdoHigh.AutoSize = true;
            this.rdoHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.rdoHigh.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoHigh.Location = new System.Drawing.Point(362, 34);
            this.rdoHigh.Name = "rdoHigh";
            this.rdoHigh.Size = new System.Drawing.Size(109, 40);
            this.rdoHigh.TabIndex = 13;
            this.rdoHigh.Text = "Hight";
            this.rdoHigh.UseVisualStyleBackColor = true;
            // 
            // grpExtra
            // 
            this.grpExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.grpExtra.Controls.Add(this.chkBreakfast);
            this.grpExtra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpExtra.Location = new System.Drawing.Point(16, 448);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(550, 80);
            this.grpExtra.TabIndex = 23;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Aditional Options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.chkBreakfast.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.chkBreakfast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBreakfast.Location = new System.Drawing.Point(15, 38);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(468, 40);
            this.chkBreakfast.TabIndex = 15;
            this.chkBreakfast.Text = "BreakFast (10 Per Guest per nights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDetails.Location = new System.Drawing.Point(581, 79);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(455, 485);
            this.txtDetails.TabIndex = 24;
            this.txtDetails.Text = "Booking details";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalculate.Location = new System.Drawing.Point(116, 570);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 50);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(306, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(496, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1020, 627);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.grpExtra.ResumeLayout(false);
            this.grpExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoHigh;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

