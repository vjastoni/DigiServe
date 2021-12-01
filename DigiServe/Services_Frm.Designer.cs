
namespace DigiServe
{
    partial class Services_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services_Frm));
            this.lblServices1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServices1
            // 
            this.lblServices1.AutoSize = true;
            this.lblServices1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lblServices1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServices1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServices1.Location = new System.Drawing.Point(23, 15);
            this.lblServices1.Name = "lblServices1";
            this.lblServices1.Size = new System.Drawing.Size(337, 23);
            this.lblServices1.TabIndex = 3;
            this.lblServices1.Text = "Are you sure you want to log out ?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.Yes_btn);
            this.panel2.Controls.Add(this.no_btn);
            this.panel2.Controls.Add(this.lblServices1);
            this.panel2.Location = new System.Drawing.Point(14, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 171);
            this.panel2.TabIndex = 1;
            // 
            // Yes_btn
            // 
            this.Yes_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes_btn.ForeColor = System.Drawing.Color.White;
            this.Yes_btn.Location = new System.Drawing.Point(46, 106);
            this.Yes_btn.Name = "Yes_btn";
            this.Yes_btn.Size = new System.Drawing.Size(94, 29);
            this.Yes_btn.TabIndex = 6;
            this.Yes_btn.Text = "Yes";
            this.Yes_btn.UseVisualStyleBackColor = true;
            this.Yes_btn.Click += new System.EventHandler(this.Yes_btn_Click);
            this.Yes_btn.MouseLeave += new System.EventHandler(this.Yes_btn_MouseLeave);
            this.Yes_btn.MouseHover += new System.EventHandler(this.Yes_btn_MouseHover);
            // 
            // no_btn
            // 
            this.no_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.no_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.no_btn.ForeColor = System.Drawing.Color.White;
            this.no_btn.Location = new System.Drawing.Point(256, 106);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(94, 29);
            this.no_btn.TabIndex = 5;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            this.no_btn.MouseLeave += new System.EventHandler(this.no_btn_MouseLeave);
            this.no_btn.MouseHover += new System.EventHandler(this.no_btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 211);
            this.panel1.TabIndex = 0;
            // 
            // Services_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(206)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(449, 238);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 285);
            this.MinimizeBox = false;
            this.Name = "Services_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log out";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblServices1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Yes_btn;
    }
}