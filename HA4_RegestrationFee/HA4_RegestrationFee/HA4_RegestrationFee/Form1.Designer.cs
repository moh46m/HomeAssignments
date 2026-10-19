namespace HA4_RegestrationFee
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutName = new System.Windows.Forms.Label();
            this.lblOutId = new System.Windows.Forms.Label();
            this.lblOutCourses = new System.Windows.Forms.Label();
            this.lblOutYear = new System.Windows.Forms.Label();
            this.lblOutTransport = new System.Windows.Forms.Label();
            this.lblOutDiscount = new System.Windows.Forms.Label();
            this.lblOutTuition = new System.Windows.Forms.Label();
            this.lblOutFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(270, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 42);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Regitration Fee System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStudentName.Location = new System.Drawing.Point(108, 77);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(280, 38);
            this.lblStudentName.TabIndex = 23;
            this.lblStudentName.Text = "Enter Student Name :";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtName.Location = new System.Drawing.Point(420, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 45);
            this.txtName.TabIndex = 24;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStudentId.Location = new System.Drawing.Point(159, 127);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(229, 38);
            this.lblStudentId.TabIndex = 25;
            this.lblStudentId.Text = "Enter Student Id :";
            this.lblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtId.Location = new System.Drawing.Point(420, 127);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(330, 45);
            this.txtId.TabIndex = 26;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourses.Location = new System.Drawing.Point(44, 177);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(344, 38);
            this.lblCourses.TabIndex = 27;
            this.lblCourses.Text = "Enter Number of Courses :";
            this.lblCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourses
            // 
            this.txtCourses.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCourses.Location = new System.Drawing.Point(420, 177);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(330, 45);
            this.txtCourses.TabIndex = 28;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLevel.Location = new System.Drawing.Point(145, 227);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(243, 38);
            this.lblLevel.TabIndex = 29;
            this.lblLevel.Text = "Enter Study Level :";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLevel.Location = new System.Drawing.Point(420, 227);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(330, 45);
            this.txtLevel.TabIndex = 30;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTransport.Location = new System.Drawing.Point(194, 280);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(194, 38);
            this.lblTransport.TabIndex = 31;
            this.lblTransport.Text = "Transport fee :";
            this.lblTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTransport.Location = new System.Drawing.Point(420, 277);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(330, 45);
            this.txtTransport.TabIndex = 32;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.Location = new System.Drawing.Point(120, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 50);
            this.btnCalculate.TabIndex = 33;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(335, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 50);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(550, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutName
            // 
            this.lblOutName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutName.Location = new System.Drawing.Point(120, 407);
            this.lblOutName.Name = "lblOutName";
            this.lblOutName.Size = new System.Drawing.Size(310, 40);
            this.lblOutName.TabIndex = 36;
            this.lblOutName.Text = "Name :";
            this.lblOutName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutId
            // 
            this.lblOutId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutId.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutId.Location = new System.Drawing.Point(120, 455);
            this.lblOutId.Name = "lblOutId";
            this.lblOutId.Size = new System.Drawing.Size(310, 40);
            this.lblOutId.TabIndex = 37;
            this.lblOutId.Text = "Id :";
            this.lblOutId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutCourses
            // 
            this.lblOutCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutCourses.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutCourses.Location = new System.Drawing.Point(120, 503);
            this.lblOutCourses.Name = "lblOutCourses";
            this.lblOutCourses.Size = new System.Drawing.Size(310, 40);
            this.lblOutCourses.TabIndex = 38;
            this.lblOutCourses.Text = "Number Courses :";
            this.lblOutCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutYear
            // 
            this.lblOutYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutYear.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutYear.Location = new System.Drawing.Point(120, 551);
            this.lblOutYear.Name = "lblOutYear";
            this.lblOutYear.Size = new System.Drawing.Size(310, 40);
            this.lblOutYear.TabIndex = 39;
            this.lblOutYear.Text = "Study year :";
            this.lblOutYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutTransport
            // 
            this.lblOutTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTransport.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutTransport.Location = new System.Drawing.Point(440, 407);
            this.lblOutTransport.Name = "lblOutTransport";
            this.lblOutTransport.Size = new System.Drawing.Size(310, 40);
            this.lblOutTransport.TabIndex = 40;
            this.lblOutTransport.Text = "Transport Fee :";
            this.lblOutTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutDiscount
            // 
            this.lblOutDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutDiscount.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutDiscount.Location = new System.Drawing.Point(440, 455);
            this.lblOutDiscount.Name = "lblOutDiscount";
            this.lblOutDiscount.Size = new System.Drawing.Size(310, 40);
            this.lblOutDiscount.TabIndex = 41;
            this.lblOutDiscount.Text = "Discount :";
            this.lblOutDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutTuition
            // 
            this.lblOutTuition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTuition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutTuition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutTuition.Location = new System.Drawing.Point(440, 503);
            this.lblOutTuition.Name = "lblOutTuition";
            this.lblOutTuition.Size = new System.Drawing.Size(310, 40);
            this.lblOutTuition.TabIndex = 42;
            this.lblOutTuition.Text = "Tution fee :";
            this.lblOutTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutFinal
            // 
            this.lblOutFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblOutFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutFinal.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblOutFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOutFinal.Location = new System.Drawing.Point(440, 551);
            this.lblOutFinal.Name = "lblOutFinal";
            this.lblOutFinal.Size = new System.Drawing.Size(310, 40);
            this.lblOutFinal.TabIndex = 43;
            this.lblOutFinal.Text = "Final Amount :";
            this.lblOutFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 641);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.txtCourses);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutName);
            this.Controls.Add(this.lblOutId);
            this.Controls.Add(this.lblOutCourses);
            this.Controls.Add(this.lblOutYear);
            this.Controls.Add(this.lblOutTransport);
            this.Controls.Add(this.lblOutDiscount);
            this.Controls.Add(this.lblOutTuition);
            this.Controls.Add(this.lblOutFinal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.TextBox txtCourses;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutName;
        private System.Windows.Forms.Label lblOutId;
        private System.Windows.Forms.Label lblOutCourses;
        private System.Windows.Forms.Label lblOutYear;
        private System.Windows.Forms.Label lblOutTransport;
        private System.Windows.Forms.Label lblOutDiscount;
        private System.Windows.Forms.Label lblOutTuition;
        private System.Windows.Forms.Label lblOutFinal;
    }
}

