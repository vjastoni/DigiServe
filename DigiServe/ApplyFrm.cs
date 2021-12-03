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
            // open Services form // Logout Label
            Services_Frm serv = new Services_Frm();
            serv.ShowDialog();

            ApplyFrm frm = new ApplyFrm();
            frm.Dispose();
        }

        private void lblReservation_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("You are already in the Reservation menu");
        }

        private void lblRecords_Click(object sender, EventArgs e)
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

        private void lblRecords_MouseHover(object sender, EventArgs e)
        {
            // Records pop up effect
            float UpSize;
            UpSize = lblRecords.Font.Size;
            UpSize = 16.0F;
            lblRecords.Font = new Font(lblRecords.Font.Name, UpSize, lblRecords.Font.Style, lblRecords.Font.Unit);
            lblRecords.ForeColor = Color.Gold;
        }

        private void lblRecords_MouseLeave(object sender, EventArgs e)
        {
            // Resccords Default format
            float downSizeR;
            downSizeR = lblRecords.Font.Size;
            downSizeR = 14.25F;
            lblRecords.Font = new Font(lblRecords.Font.Name, downSizeR, lblRecords.Font.Style, lblRecords.Font.Unit);
            lblRecords.ForeColor = SystemColors.ControlLightLight;
        }

        public class RandomGenerator
        {
             
            private readonly Random _random = new Random();

               
            public int RandomNumber(int min, int max)
            {
                return _random.Next(min, max);
            }

              
            public string RandomString(int size, bool lowerCase = false)
            {
                var builder = new StringBuilder(size);

                
                char offset = lowerCase ? 'a' : 'A';
                const int lettersOffset = 26; 

                for (var i = 0; i < size; i++)
                {
                    var @char = (char)_random.Next(offset, offset + lettersOffset);
                    builder.Append(@char);
                }

                return lowerCase ? builder.ToString().ToLower() : builder.ToString();
            }

            public string RandomTicket()
            {
                var ticketBuilder = new StringBuilder();


                ticketBuilder.Append(RandomString(4, true));

                  
                ticketBuilder.Append(RandomNumber(1000, 9999));

               
                ticketBuilder.Append(RandomString(2));
                return ticketBuilder.ToString();
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RandomGenerator ticketgenerator = new RandomGenerator();
            
            string ticket = ticketgenerator.RandomTicket();  // Paki lagay nalng master :) lab u po <3

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Appointment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Appointment]
           ([Department]
           ,[Course]
           ,[Subject]
           ,[Professor]
           ,[Date]
           ,[Time]
           ,[MobileNo]
           ,[Ticket])
     VALUES
           ('" + cbDepartment.SelectedItem.ToString()+ "', '" + cdCourse.SelectedItem.ToString() + "', '" + cbSubject.SelectedItem.ToString() + "', '" + cbProfessor.SelectedItem.ToString() + "', '" + DatePicker.Value.ToShortDateString() + "', '" + cbTime.SelectedItem.ToString() + "', '" + txtMobileNo.Text + "','"+ticket+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submitted Successfully!" + "\nYour Ticket is: " + ticket, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
