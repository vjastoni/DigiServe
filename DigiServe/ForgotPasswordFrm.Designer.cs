
namespace DigiServe
{
    partial class Forgot_password_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_password_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPass_txtbx = new System.Windows.Forms.TextBox();
            this.verifyNewPass_txtbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verify Password :";
            // 
            // newPass_txtbx
            // 
            this.newPass_txtbx.Location = new System.Drawing.Point(164, 25);
            this.newPass_txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPass_txtbx.Name = "newPass_txtbx";
            this.newPass_txtbx.Size = new System.Drawing.Size(168, 23);
            this.newPass_txtbx.TabIndex = 3;
            this.newPass_txtbx.UseSystemPasswordChar = true;
            // 
            // verifyNewPass_txtbox
            // 
            this.verifyNewPass_txtbox.Location = new System.Drawing.Point(164, 59);
            this.verifyNewPass_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyNewPass_txtbox.Name = "verifyNewPass_txtbox";
            this.verifyNewPass_txtbox.Size = new System.Drawing.Size(168, 23);
            this.verifyNewPass_txtbox.TabIndex = 4;
            this.verifyNewPass_txtbox.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(212, 93);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 18);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.Gold;
            this.Submit_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Submit_btn.Location = new System.Drawing.Point(250, 115);
            this.Submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(82, 22);
            this.Submit_btn.TabIndex = 7;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Forgot_password_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(374, 164);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.verifyNewPass_txtbox);
            this.Controls.Add(this.newPass_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 209);
            this.MinimizeBox = false;
            this.Name = "Forgot_password_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Forgot_password_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPass_txtbx;
        private System.Windows.Forms.TextBox verifyNewPass_txtbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Submit_btn;
    }
}