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

namespace PROG_ICE4_Students.Menus
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            SqlConnection sqlConnection = new(Connection.Conn);
            sqlConnection.Open();

            string query = "Select * FROM Module;";

            SqlCommand command = new(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            clb_Modules.Items.Clear();

            while (reader.Read())
            {
                clb_Modules.Items.Add(reader["Code"].ToString() ?? "Nothing");
            }

            reader.Close();
            sqlConnection.Close();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Validation v = new();
            if (v.Validate(txb_Firstname.Text, txb_Surname.Text, DateOnly.FromDateTime(dtp_DOB.Value), null, txb_Contact.Text))
            {
                if (clb_Modules.CheckedItems.Count > 0)
                {
                    SqlConnection sqlConnection = new(Connection.Conn);
                    sqlConnection.Open();

                    string studentQuery = $"Insert into Student Values(" +
                        $"'{txb_Firstname.Text.Trim()}', " +
                        $"'{txb_Surname.Text.Trim()}', " +
                        $"'{dtp_DOB.Text}', " +
                        $"'{txb_Contact.Text.Replace(" ", "").Trim()}');";

                    SqlCommand studentCommand = new(studentQuery, sqlConnection);
                    studentCommand.ExecuteNonQuery();

                    string tempQuery_sID = $"SELECT sID FROM Student WHERE Firstname = '{txb_Firstname.Text.Trim()}' AND Surname = '{txb_Surname.Text.Trim()}' AND Contact = '{txb_Contact.Text.Replace(" ", "").Trim()}'";
                    string moduleQuery;

                    foreach (var module in clb_Modules.CheckedItems)
                    {
                        string tempQuery_mID = $"SELECT mID FROM Module WHERE Code = '{module}'";
                        moduleQuery = $"INSERT INTO StudentModule(sID, mID) VALUES(({tempQuery_sID}), ({tempQuery_mID}));";

                        SqlCommand moduleCommand = new(moduleQuery, sqlConnection);
                        moduleCommand.ExecuteNonQuery();
                    }

                    sqlConnection.Close();
                    MessageBox.Show("Success");

                    txb_Firstname.Clear();
                    txb_Surname.Clear();
                    txb_Contact.Clear();
                }
                else
                {
                    MessageBox.Show("Select a module!");
                }
            }
            else
            {
                MessageBox.Show("Invalid data values!");
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Menu m = new();
            m.Show();
            this.Close();
        }

        private void txb_Contact_TextChanged(object sender, EventArgs e)
        {
            string input = txb_Contact.Text.Replace(" ", ""); // Remove existing spaces
            string formattedNumber = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 == 0 && i > 0 && i <= 6)
                {
                    formattedNumber += " ";
                }
                formattedNumber += input[i];
            }

            txb_Contact.Text = formattedNumber;
            txb_Contact.SelectionStart = txb_Contact.Text.Length; // Set the cursor position to the end

        }
    }
}
