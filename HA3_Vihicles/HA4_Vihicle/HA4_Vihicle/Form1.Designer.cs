namespace HA4_Vihicle
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lbldays = new System.Windows.Forms.Label();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.lblexperience = new System.Windows.Forms.Label();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.grpInsurance = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            this.grpInsurance.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(940, 60);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Vehicle Rental Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.grpCustomer.Controls.Add(this.lblname);
            this.grpCustomer.Controls.Add(this.txtname);
            this.grpCustomer.Controls.Add(this.lblage);
            this.grpCustomer.Controls.Add(this.txtage);
            this.grpCustomer.Controls.Add(this.lbldays);
            this.grpCustomer.Controls.Add(this.txtdays);
            this.grpCustomer.Controls.Add(this.lblexperience);
            this.grpCustomer.Controls.Add(this.txtexperience);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.grpCustomer.Location = new System.Drawing.Point(41, 69);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(516, 210);
            this.grpCustomer.TabIndex = 22;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblname.Location = new System.Drawing.Point(8, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(230, 28);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Customer Name:";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtname.Location = new System.Drawing.Point(245, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(251, 37);
            this.txtname.TabIndex = 3;
            // 
            // lblage
            // 
            this.lblage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lblage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblage.Location = new System.Drawing.Point(8, 80);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(230, 28);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "Customer Age:";
            this.lblage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtage.Location = new System.Drawing.Point(245, 80);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(251, 37);
            this.txtage.TabIndex = 5;
            // 
            // lbldays
            // 
            this.lbldays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lbldays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbldays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldays.Location = new System.Drawing.Point(8, 125);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(230, 28);
            this.lbldays.TabIndex = 6;
            this.lbldays.Text = "Number of Rental Days:";
            this.lbldays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdays
            // 
            this.txtdays.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtdays.Location = new System.Drawing.Point(245, 125);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(251, 37);
            this.txtdays.TabIndex = 7;
            // 
            // lblexperience
            // 
            this.lblexperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lblexperience.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblexperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblexperience.Location = new System.Drawing.Point(8, 170);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(230, 28);
            this.lblexperience.TabIndex = 8;
            this.lblexperience.Text = "Years of Driving Experience:";
            this.lblexperience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtexperience
            // 
            this.txtexperience.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtexperience.Location = new System.Drawing.Point(245, 170);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(251, 37);
            this.txtexperience.TabIndex = 9;
            // 
            // grpVehicle
            // 
            this.grpVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.grpVehicle.Controls.Add(this.rdoeconomy);
            this.grpVehicle.Controls.Add(this.rdosuv);
            this.grpVehicle.Controls.Add(this.rdoluxury);
            this.grpVehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.grpVehicle.Location = new System.Drawing.Point(16, 289);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(629, 100);
            this.grpVehicle.TabIndex = 23;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Vehicle Type";
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.rdoeconomy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoeconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoeconomy.Location = new System.Drawing.Point(13, 45);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(222, 32);
            this.rdoeconomy.TabIndex = 11;
            this.rdoeconomy.Text = "Economy ($30/day)";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.rdosuv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdosuv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdosuv.Location = new System.Drawing.Point(242, 45);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(174, 32);
            this.rdosuv.TabIndex = 12;
            this.rdosuv.Text = "SUV ($50/day)";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.rdoluxury.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoluxury.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoluxury.Location = new System.Drawing.Point(422, 45);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(201, 32);
            this.rdoluxury.TabIndex = 13;
            this.rdoluxury.Text = "Luxury ($90/day)";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // grpInsurance
            // 
            this.grpInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.grpInsurance.Controls.Add(this.chkinsurance);
            this.grpInsurance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.grpInsurance.Location = new System.Drawing.Point(16, 399);
            this.grpInsurance.Name = "grpInsurance";
            this.grpInsurance.Size = new System.Drawing.Size(440, 80);
            this.grpInsurance.TabIndex = 24;
            this.grpInsurance.TabStop = false;
            this.grpInsurance.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.chkinsurance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chkinsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkinsurance.Location = new System.Drawing.Point(25, 38);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(334, 34);
            this.chkinsurance.TabIndex = 15;
            this.chkinsurance.Text = "Add Insurance ($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // grpResults
            // 
            this.grpResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.grpResults.Controls.Add(this.lstresults);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.grpResults.Location = new System.Drawing.Point(651, 69);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(483, 545);
            this.grpResults.TabIndex = 25;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Rental Information and Results";
            // 
            // lstresults
            // 
            this.lstresults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstresults.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstresults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstresults.ItemHeight = 23;
            this.lstresults.Location = new System.Drawing.Point(10, 28);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(460, 510);
            this.lstresults.TabIndex = 17;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.btncalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btncalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncalculate.Location = new System.Drawing.Point(102, 524);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(150, 52);
            this.btncalculate.TabIndex = 26;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclear.Location = new System.Drawing.Point(282, 524);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(150, 52);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnexit.Location = new System.Drawing.Point(462, 524);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 52);
            this.btnexit.TabIndex = 28;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1188, 629);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.grpInsurance);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpInsurance.ResumeLayout(false);
            this.grpInsurance.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.GroupBox grpInsurance;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.ListBox lstresults;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

