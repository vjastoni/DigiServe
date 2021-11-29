
namespace DigiServe
{
    partial class ApplyFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtSched = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAboutDigi = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.lblScholar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigiServe.Properties.Resources.DigiServe1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtDateTime);
            this.panel1.Controls.Add(this.txtSched);
            this.panel1.Controls.Add(this.txtRequest);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMobileNumber);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(43, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 377);
            this.panel1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gold;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(676, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 36);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(650, 162);
            this.txtDateTime.Multiline = true;
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(186, 26);
            this.txtDateTime.TabIndex = 16;
            // 
            // txtSched
            // 
            this.txtSched.Location = new System.Drawing.Point(650, 106);
            this.txtSched.Multiline = true;
            this.txtSched.Name = "txtSched";
            this.txtSched.Size = new System.Drawing.Size(186, 26);
            this.txtSched.TabIndex = 15;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(650, 51);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(186, 26);
            this.txtRequest.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(520, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date/Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(520, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sched/Pick Up:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(520, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Request:";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(156, 216);
            this.txtMobileNumber.Multiline = true;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(211, 26);
            this.txtMobileNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 162);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(156, 106);
            this.txtLname.Multiline = true;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(211, 26);
            this.txtLname.TabIndex = 6;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(156, 51);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(211, 26);
            this.txtFname.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(50, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(49, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mobile No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(50, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DigiServe.Properties.Resources.Screen_Shot_2021_11_24_at_11_32_24_AM;
            this.pictureBox2.Location = new System.Drawing.Point(231, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(834, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblAboutDigi
            // 
            this.lblAboutDigi.AutoSize = true;
            this.lblAboutDigi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblAboutDigi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAboutDigi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAboutDigi.Location = new System.Drawing.Point(263, 75);
            this.lblAboutDigi.Name = "lblAboutDigi";
            this.lblAboutDigi.Size = new System.Drawing.Size(159, 22);
            this.lblAboutDigi.TabIndex = 3;
            this.lblAboutDigi.Text = "About DigiServe";
            this.lblAboutDigi.Click += new System.EventHandler(this.lblAboutDigi_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblServices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServices.Location = new System.Drawing.Point(449, 75);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(89, 22);
            this.lblServices.TabIndex = 4;
            this.lblServices.Text = "Services";
            this.lblServices.Click += new System.EventHandler(this.lblServices_Click);
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblReservation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReservation.Location = new System.Drawing.Point(563, 75);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(119, 22);
            this.lblReservation.TabIndex = 5;
            this.lblReservation.Text = "Reservation";
            this.lblReservation.Click += new System.EventHandler(this.lblReservation_Click);
            // 
            // lblScholar
            // 
            this.lblScholar.AutoSize = true;
            this.lblScholar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblScholar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScholar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScholar.Location = new System.Drawing.Point(709, 75);
            this.lblScholar.Name = "lblScholar";
            this.lblScholar.Size = new System.Drawing.Size(128, 22);
            this.lblScholar.TabIndex = 6;
            this.lblScholar.Text = "Scholarships";
            this.lblScholar.Click += new System.EventHandler(this.lblScholar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(385, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reservation for tuition fee payment ";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(156, 277);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 23);
            this.cmbGender.TabIndex = 18;
            // 
            // ApplyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(206)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1040, 652);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblScholar);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblAboutDigi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ApplyFrm";
            this.Text = "Apply";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAboutDigi;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Label lblScholar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtSched;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}