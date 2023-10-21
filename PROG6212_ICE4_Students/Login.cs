using Microsoft.Data.SqlClient;
using PROG6212_ICE4_Students;

namespace PROG_ICE4_Students
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new(Connection.Conn);
            sqlConnection.Open();
            string query = $"Select Password From Administrator Where Email = '{txb_Email.Text.ToLower()}'";
            SqlCommand command = new(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (BCrypt.Net.BCrypt.Verify(txb_Password.Text, reader["Password"].ToString()))
                {
                    MessageBox.Show("Success stuff");
                    Menu m = new();
                    m.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong stuff");
                }
            }
            else
            {
                MessageBox.Show("Wrong stuff");
            }
            sqlConnection.Close();
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
