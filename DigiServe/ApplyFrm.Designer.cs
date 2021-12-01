
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cdCourse = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAboutDigi = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigiServe.Properties.Resources.DigiServe1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtMobileNo);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Controls.Add(this.cbTime);
            this.panel1.Controls.Add(this.cbProfessor);
            this.panel1.Controls.Add(this.cbSubject);
            this.panel1.Controls.Add(this.cdCourse);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(43, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 377);
            this.panel1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(206)))), ((int)(((byte)(79)))));
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(662, 276);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 40);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(640, 206);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(200, 23);
            this.txtMobileNo.TabIndex = 13;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(638, 78);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 23);
            this.DatePicker.TabIndex = 12;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "9 am",
            "10 pm"});
            this.cbTime.Location = new System.Drawing.Point(638, 147);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(202, 23);
            this.cbTime.TabIndex = 11;
            // 
            // cbProfessor
            // 
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Items.AddRange(new object[] {
            "MR. A",
            "MS. B",
            "MS. C"});
            this.cbProfessor.Location = new System.Drawing.Point(280, 276);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(202, 23);
            this.cbProfessor.TabIndex = 10;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "MATH",
            "ENGLISH",
            "SCIENCE"});
            this.cbSubject.Location = new System.Drawing.Point(280, 208);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(202, 23);
            this.cbSubject.TabIndex = 9;
            // 
            // cdCourse
            // 
            this.cdCourse.FormattingEnabled = true;
            this.cdCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSTM"});
            this.cdCourse.Location = new System.Drawing.Point(280, 144);
            this.cdCourse.Name = "cdCourse";
            this.cdCourse.Size = new System.Drawing.Size(202, 23);
            this.cdCourse.TabIndex = 8;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbDepartment.Location = new System.Drawing.Point(280, 81);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(202, 23);
            this.cbDepartment.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(521, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mobile No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(521, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DigiServe.Properties.Resources.design11;
            this.pictureBox3.Location = new System.Drawing.Point(603, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(436, 315);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DigiServe.Properties.Resources.Design2;
            this.pictureBox4.Location = new System.Drawing.Point(-9, -17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(174, 141);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
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
            this.lblAboutDigi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutDigi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAboutDigi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAboutDigi.Location = new System.Drawing.Point(831, 76);
            this.lblAboutDigi.Name = "lblAboutDigi";
            this.lblAboutDigi.Size = new System.Drawing.Size(159, 22);
            this.lblAboutDigi.TabIndex = 3;
            this.lblAboutDigi.Text = "About DigiServe";
            this.lblAboutDigi.Click += new System.EventHandler(this.lblAboutDigi_Click);
            this.lblAboutDigi.MouseLeave += new System.EventHandler(this.lblAboutDigi_MouseLeave);
            this.lblAboutDigi.MouseHover += new System.EventHandler(this.lblAboutDigi_MouseHover);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServices.Location = new System.Drawing.Point(475, 76);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(89, 22);
            this.lblServices.TabIndex = 4;
            this.lblServices.Text = "Services";
            this.lblServices.Click += new System.EventHandler(this.lblServices_Click);
            this.lblServices.MouseLeave += new System.EventHandler(this.lblServices_MouseLeave);
            this.lblServices.MouseHover += new System.EventHandler(this.lblServices_MouseHover);
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReservation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReservation.Location = new System.Drawing.Point(280, 76);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(119, 22);
            this.lblReservation.TabIndex = 5;
            this.lblReservation.Text = "Reservation";
            this.lblReservation.Click += new System.EventHandler(this.lblReservation_Click);
            this.lblReservation.MouseLeave += new System.EventHandler(this.lblReservation_MouseLeave);
            this.lblReservation.MouseHover += new System.EventHandler(this.lblReservation_MouseHover);
            // 
            // lblRecord
            // 
            this.lblRecord.Location = new System.Drawing.Point(-4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(100, 23);
            this.lblRecord.TabIndex = 8;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecords.Location = new System.Drawing.Point(667, 76);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 22);
            this.lblRecords.TabIndex = 9;
            this.lblRecords.Text = "Records";
            this.lblRecords.Click += new System.EventHandler(this.lblRecords_Click);
            this.lblRecords.MouseLeave += new System.EventHandler(this.lblRecords_MouseLeave);
            this.lblRecords.MouseHover += new System.EventHandler(this.lblRecords_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(24, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 421);
            this.panel2.TabIndex = 10;
            // 
            // ApplyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(206)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1040, 652);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblAboutDigi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyFrm";
            this.Text = "Apply";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAboutDigi;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cdCourse;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
    }
}