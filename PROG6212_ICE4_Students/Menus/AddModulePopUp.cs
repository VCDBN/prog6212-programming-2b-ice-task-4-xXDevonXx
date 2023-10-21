using Microsoft.Data.SqlClient;
using PROG_ICE4_Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG6212_ICE4_Students.Menus
{
    public partial class AddModulePopUp : Form
    {
        public AddModulePopUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_AddModule_Click(object sender, EventArgs e)
        {
            if (txb_Code.Text.Length > 0 && txb_Code.Text.Length <= 20 && txb_Name.Text.Length > 0 && txb_Name.Text.Length <= 50)
            {
                SqlConnection sqlConnection = new(Connection.Conn);
                sqlConnection.Open();

                string query = $"Insert into Module Values(" +
                    $"'{txb_Code.Text}', " +
                    $"'{txb_Name.Text}');";

                SqlCommand command = new(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid data values!");
            }
        }
    }
}
