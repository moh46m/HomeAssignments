namespace HA2_Airlinebooking
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
            this.lblTickets = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.rdoFirst = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoBusiness = new System.Windows.Forms.RadioButton();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPersonal.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.grpExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(-2, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1075, 79);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Airline Ticket Booking System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPersonal
            // 
            this.grpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.grpPersonal.Controls.Add(this.lblName);
            this.grpPersonal.Controls.Add(this.txtName);
            this.grpPersonal.Controls.Add(this.lblAge);
            this.grpPersonal.Controls.Add(this.txtAge);
            this.grpPersonal.Controls.Add(this.lblTickets);
            this.grpPersonal.Controls.Add(this.txtTickets);
            this.grpPersonal.Controls.Add(this.lblBaggage);
            this.grpPersonal.Controls.Add(this.txtBaggage);
            this.grpPersonal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grpPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpPersonal.Location = new System.Drawing.Point(34, 90);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(554, 235);
            this.grpPersonal.TabIndex = 21;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(53, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(230, 36);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Passenger Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(289, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 37);
            this.txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAge.Location = new System.Drawing.Point(78, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(205, 36);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Passenger Age :";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAge.Location = new System.Drawing.Point(289, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(241, 37);
            this.txtAge.TabIndex = 5;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTickets.Location = new System.Drawing.Point(29, 139);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(254, 36);
            this.lblTickets.TabIndex = 6;
            this.lblTickets.Text = "Number of Tickets :";
            this.lblTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTickets.Location = new System.Drawing.Point(289, 137);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(241, 37);
            this.txtTickets.TabIndex = 7;
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.lblBaggage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBaggage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBaggage.Location = new System.Drawing.Point(5, 187);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(278, 36);
            this.lblBaggage.TabIndex = 8;
            this.lblBaggage.Text = "Baggage weight(kg) :";
            this.lblBaggage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBaggage
            // 
            this.txtBaggage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBaggage.Location = new System.Drawing.Point(289, 186);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(241, 37);
            this.txtBaggage.TabIndex = 9;
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.rdoFirst);
            this.grpClass.Controls.Add(this.rdoNormal);
            this.grpClass.Controls.Add(this.rdoBusiness);
            this.grpClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpClass.Location = new System.Drawing.Point(12, 353);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(588, 92);
            this.grpClass.TabIndex = 22;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Travel Class";
            // 
            // rdoFirst
            // 
            this.rdoFirst.AutoSize = true;
            this.rdoFirst.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoFirst.Location = new System.Drawing.Point(15, 38);
            this.rdoFirst.Name = "rdoFirst";
            this.rdoFirst.Size = new System.Drawing.Size(154, 40);
            this.rdoFirst.TabIndex = 11;
            this.rdoFirst.Text = "first Class";
            this.rdoFirst.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoNormal.Location = new System.Drawing.Point(175, 38);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(198, 40);
            this.rdoNormal.TabIndex = 12;
            this.rdoNormal.Text = "Normal Class";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoBusiness
            // 
            this.rdoBusiness.AutoSize = true;
            this.rdoBusiness.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.rdoBusiness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoBusiness.Location = new System.Drawing.Point(373, 38);
            this.rdoBusiness.Name = "rdoBusiness";
            this.rdoBusiness.Size = new System.Drawing.Size(209, 40);
            this.rdoBusiness.TabIndex = 13;
            this.rdoBusiness.Text = "Business Class";
            this.rdoBusiness.UseVisualStyleBackColor = true;
            // 
            // grpExtra
            // 
            this.grpExtra.Controls.Add(this.chkInsurance);
            this.grpExtra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpExtra.Location = new System.Drawing.Point(34, 451);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(530, 80);
            this.grpExtra.TabIndex = 23;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Aditional Options";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.chkInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkInsurance.Location = new System.Drawing.Point(15, 38);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(486, 40);
            this.chkInsurance.TabIndex = 15;
            this.chkInsurance.Text = "Add Travel insurance ($25 Per ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDetails.Location = new System.Drawing.Point(606, 90);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(455, 470);
            this.txtDetails.TabIndex = 24;
            this.txtDetails.Text = "Airline Booking Details";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalculate.Location = new System.Drawing.Point(58, 591);
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
            this.btnClear.Location = new System.Drawing.Point(248, 591);
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
            this.btnExit.Location = new System.Drawing.Point(438, 591);
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
            this.ClientSize = new System.Drawing.Size(1063, 657);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
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
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.RadioButton rdoFirst;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoBusiness;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

