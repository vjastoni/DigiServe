
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailAddFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.EmailAdd_txtbx = new System.Windows.Forms.TextBox();
            this.Subtmitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerCode = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address :";
            // 
            // EmailAdd_txtbx
            // 
            this.EmailAdd_txtbx.Location = new System.Drawing.Point(119, 20);
            this.EmailAdd_txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailAdd_txtbx.Name = "EmailAdd_txtbx";
            this.EmailAdd_txtbx.Size = new System.Drawing.Size(198, 23);
            this.EmailAdd_txtbx.TabIndex = 1;
            // 
            // Subtmitbtn
            // 
            this.Subtmitbtn.BackColor = System.Drawing.Color.Gold;
            this.Subtmitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtmitbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtmitbtn.Location = new System.Drawing.Point(235, 61);
            this.Subtmitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subtmitbtn.Name = "Subtmitbtn";
            this.Subtmitbtn.Size = new System.Drawing.Size(82, 22);
            this.Subtmitbtn.TabIndex = 2;
            this.Subtmitbtn.Text = "Submit";
            this.Subtmitbtn.UseVisualStyleBackColor = false;
            this.Subtmitbtn.Click += new System.EventHandler(this.Subtmitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify Code: ";
            // 
            // txtVerCode
            // 
            this.txtVerCode.Location = new System.Drawing.Point(119, 98);
            this.txtVerCode.Name = "txtVerCode";
            this.txtVerCode.Size = new System.Drawing.Size(198, 23);
            this.txtVerCode.TabIndex = 4;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Gold;
            this.btnVerify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerify.Location = new System.Drawing.Point(235, 127);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(82, 23);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // EmailAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(341, 161);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtVerCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subtmitbtn);
            this.Controls.Add(this.EmailAdd_txtbx);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 200);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerCode;
        private System.Windows.Forms.Button btnVerify;
    }
}