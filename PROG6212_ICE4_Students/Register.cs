using Microsoft.Data.SqlClient;
using PROG6212_ICE4_Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_ICE4_Students
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Validation v = new();
            if (v.Validate(txb_Firstname.Text, txb_Surname.Text, DateOnly.FromDateTime(dtp_DOB.Value), txb_Email.Text.ToLower(), null))
            {
                SqlConnection sqlConnection = new(Connection.Conn);
                sqlConnection.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txb_Password.Text);

                string query = $"Insert into Administrator Values(" +
                    $"'{txb_Firstname.Text}', " +
                    $"'{txb_Surname.Text}', " +
                    $"'{dtp_DOB.Text}', " +
                    $"'{txb_Email.Text.ToLower()}', " +
                    $"'{hashedPassword}');";

                SqlCommand command = new(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Success");

                txb_Firstname.Clear();
                txb_Surname.Clear();
                txb_Email.Clear();
                txb_Password.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect date values!");
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Home h = new();
            h.Show();
            this.Close();
        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            if (txb_Password.PasswordChar == '*')
                txb_Password.PasswordChar = '\0';
            else
                txb_Password.PasswordChar = '*';
        }
    }
}
