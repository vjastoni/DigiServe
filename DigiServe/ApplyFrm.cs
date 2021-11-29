using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DigiServe
{
    public partial class ApplyFrm : Form
    {
        public ApplyFrm()
        {
            InitializeComponent();
        }

        private void lblAboutDigi_Click(object sender, EventArgs e)
        {
            // open about digiserve form
            ADS_Frm ads = new ADS_Frm();
            ads.ShowDialog();
        }

        private void lblServices_Click(object sender, EventArgs e)
        {
            // open Services form
            Services_Frm serv = new Services_Frm();
            serv.ShowDialog();
        }

        private void lblReservation_Click(object sender, EventArgs e)
        {
            
        }

        private void lblRecord_Click(object sender, EventArgs e)
        {
            // open record form
            Records rec = new Records();
            rec.ShowDialog();  
        }

        private void lblAboutDigi_MouseHover(object sender, EventArgs e)
        {
            // AboutDigi pop up effect
            float UpSize;
            UpSize = lblAboutDigi.Font.Size;
            UpSize = 16.0F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, UpSize, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = Color.Gold;
        }

        private void lblAboutDigi_MouseLeave(object sender, EventArgs e)
        {
            // About Digi Default format
            float downSizeA;
            downSizeA = lblAboutDigi.Font.Size;
            downSizeA = 14.25F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, downSizeA, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = SystemColors.ControlLightLight;
        }

        private void lblServices_MouseHover(object sender, EventArgs e)
        {
            // Services pop up effect
            float UpSize;
            UpSize = lblServices.Font.Size;
            UpSize = 16.0F;
            lblServices.Font = new Font(lblServices.Font.Name, UpSize, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = Color.Gold;
        }

        private void lblServices_MouseLeave(object sender, EventArgs e)
        {
            // Services Default format
            float downSizeS;
            downSizeS = lblServices.Font.Size;
            downSizeS = 14.25F;
            lblServices.Font = new Font(lblServices.Font.Name, downSizeS, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = Color.White;
        }

        private void lblReservation_MouseHover(object sender, EventArgs e)
        {
            // Reservation pop up effect
            float UpSize;
            UpSize = lblReservation.Font.Size;
            UpSize = 16.0F;
            lblReservation.Font = new Font(lblReservation.Font.Name, UpSize, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = Color.Gold;
        }

        private void lblReservation_MouseLeave(object sender, EventArgs e)
        {
            // Reservation Default format
            float downSizeR;
            downSizeR = lblReservation.Font.Size;
            downSizeR = 14.25F;
            lblReservation.Font = new Font(lblReservation.Font.Name, downSizeR, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = SystemColors.ControlLightLight;
        }
    }
}
