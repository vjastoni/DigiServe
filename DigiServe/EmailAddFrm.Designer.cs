﻿
namespace DigiServe
{
    partial class EmailAddFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailAdd_txtbx = new System.Windows.Forms.TextBox();
            this.Subtmitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address :";
            // 
            // EmailAdd_txtbx
            // 
            this.EmailAdd_txtbx.Location = new System.Drawing.Point(136, 26);
            this.EmailAdd_txtbx.Name = "EmailAdd_txtbx";
            this.EmailAdd_txtbx.Size = new System.Drawing.Size(226, 27);
            this.EmailAdd_txtbx.TabIndex = 1;
            // 
            // Subtmitbtn
            // 
            this.Subtmitbtn.BackColor = System.Drawing.Color.Gold;
            this.Subtmitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtmitbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtmitbtn.Location = new System.Drawing.Point(268, 80);
            this.Subtmitbtn.Name = "Subtmitbtn";
            this.Subtmitbtn.Size = new System.Drawing.Size(94, 29);
            this.Subtmitbtn.TabIndex = 2;
            this.Subtmitbtn.Text = "Submit";
            this.Subtmitbtn.UseVisualStyleBackColor = false;
            this.Subtmitbtn.Click += new System.EventHandler(this.Subtmitbtn_Click);
            // 
            // EmailAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(388, 133);
            this.Controls.Add(this.Subtmitbtn);
            this.Controls.Add(this.EmailAdd_txtbx);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 180);
            this.MinimizeBox = false;
            this.Name = "EmailAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailAdd_txtbx;
        private System.Windows.Forms.Button Subtmitbtn;
    }
}