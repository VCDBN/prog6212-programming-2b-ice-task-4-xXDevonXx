using Microsoft.Data.SqlClient;
using PROG_ICE4_Students;
using System.Data;

namespace PROG6212_ICE4_Students.Menus
{
    public partial class DatabaseManagement : Form
    {
        public DatabaseManagement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            GetStudents();
            GetModules();
            GetAssignment();
            Permissions();
            rbt_Code.Checked = true;
        }

        private void Permissions()
        {
            dgv_Students.AllowUserToResizeColumns = false;
            dgv_Students.AllowUserToResizeRows = false;
            dgv_Modules.AllowUserToResizeColumns = false;
            dgv_Modules.AllowUserToResizeRows = false;
            dgv_Assignment.AllowUserToResizeColumns = false;
            dgv_Assignment.AllowUserToResizeRows = false;
        }

        private void GetStudents()
        {
            using (SqlConnection sqlConnection = new(Connection.Conn))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Student;";

                // Create a SqlDataAdapter to fetch data
                SqlDataAdapter adapter = new(query, sqlConnection);

                // Create a DataTable to store the results
                DataTable studentDataTable = new();

                // Fill the DataTable with data from the query
                adapter.Fill(studentDataTable);

                // Set the DataGridView's DataSource to the DataTable
                dgv_Students.DataSource = studentDataTable;

                sqlConnection.Close();
            }
        }

        private void GetModules()
        {
            using (SqlConnection sqlConnection = new(Connection.Conn))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Module;";

                // Create a SqlDataAdapter to fetch data
                SqlDataAdapter adapter = new(query, sqlConnection);

                // Create a DataTable to store the results
                DataTable moduleDataTable = new();

                // Fill the DataTable with data from the query
                adapter.Fill(moduleDataTable);

                // Set the DataGridView's DataSource to the DataTable
                dgv_Modules.DataSource = moduleDataTable;

                sqlConnection.Close();
            }
        }

        private void GetAssignment()
        {
            using (SqlConnection sqlConnection = new(Connection.Conn))
            {
                sqlConnection.Open();
                string query = "SELECT a.smID, s.Firstname, s.Surname, m.Code, a.Mark FROM StudentModule a JOIN Student s ON a.sID = s.sID JOIN Module m ON a.mID = m.mID;";

                // Create a SqlDataAdapter to fetch data
                SqlDataAdapter adapter = new(query, sqlConnection);

                // Create a DataTable to store the results
                DataTable assignmentDataTable = new();

                // Fill the DataTable with data from the query
                adapter.Fill(assignmentDataTable);

                // Set the DataGridView's DataSource to the DataTable
                dgv_Assignment.DataSource = assignmentDataTable;

                sqlConnection.Close();
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Menu m = new();
            m.Show();
            this.Close();
        }

        private void bt_AddModule_Click(object sender, EventArgs e)
        {
            AddModulePopUp ampu = new();
            ampu.FormClosed += (s, ea) =>
            {
                // When the AddModulePopUp form is closed, update the modules in dgv_Modules
                GetModules();
            };
            ampu.Show();
        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text.Length > 0 && int.TryParse(txb_Search.Text, out int result))
            {
                using (SqlConnection sqlConnection = new(Connection.Conn))
                {
                    sqlConnection.Open();
                    string query = $"SELECT * FROM Student WHERE sID = '{txb_Search.Text}';";

                    // Create a SqlDataAdapter to fetch data
                    SqlDataAdapter adapter = new(query, sqlConnection);

                    // Create a DataTable to store the results
                    DataTable studentDataTable = new();

                    // Fill the DataTable with data from the query
                    adapter.Fill(studentDataTable);

                    // Set the DataGridView's DataSource to the DataTable
                    dgv_Students.DataSource = studentDataTable;

                    sqlConnection.Close();
                }
            }
            else
            {
                GetStudents();
            }
        }

        private void bt_AssignMark_Click(object sender, EventArgs e)
        {
            if (dgv_Assignment.SelectedRows.Count > 0) //checks if a row is selected
            {
                if (txb_AssignMark.Text.Length > 0 && int.TryParse(txb_AssignMark.Text, out _))
                {
                    SqlConnection sqlConnection = new(Connection.Conn);
                    sqlConnection.Open();

                    string query = $"UPDATE StudentModule SET Mark = '{txb_AssignMark.Text}' WHERE smID = {dgv_Assignment.CurrentRow.Cells[0].Value};";

                    SqlCommand command = new(query, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    GetAssignment();
                }
                else
                {
                    MessageBox.Show("Enter a valid mark");
                }
            }
            else
            {
                MessageBox.Show("Selct a row!");
            }
        }

        private void txb_SearchAssignment_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchAssignment.Text.Length > 0 && int.TryParse(txb_SearchAssignment.Text, out _))
            {
                using (SqlConnection sqlConnection = new(Connection.Conn))
                {
                    sqlConnection.Open();
                    string query = $"SELECT a.smID, s.Firstname, s.Surname, m.Code, a.Mark FROM StudentModule a JOIN Student s ON a.sID = s.sID JOIN Module m ON a.mID = m.mID WHERE a.sID = '{txb_SearchAssignment.Text}';";

                    // Create a SqlDataAdapter to fetch data
                    SqlDataAdapter adapter = new(query, sqlConnection);

                    // Create a DataTable to store the results
                    DataTable studentDataTable = new();

                    // Fill the DataTable with data from the query
                    adapter.Fill(studentDataTable);

                    // Set the DataGridView's DataSource to the DataTable
                    dgv_Assignment.DataSource = studentDataTable;

                    sqlConnection.Close();
                }
            }
            else
            {
                GetAssignment();
            }
        }

        private void bt_EditModule_Click(object sender, EventArgs e)
        {
            if (dgv_Modules.SelectedRows.Count > 0) //checks if a row is selected
            {
                if (txb_EditModule.Text.Length > 0)
                {

                    string attribute = rbt_Code.Checked ? "Code" : "Name";
                    SqlConnection sqlConnection = new(Connection.Conn);
                    sqlConnection.Open();

                    string query = $"UPDATE Module SET {attribute} = '{txb_EditModule.Text}' WHERE mID = {dgv_Modules.CurrentRow.Cells[0].Value};";

                    SqlCommand command = new(query, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    GetModules();
                }
                else
                {
                    MessageBox.Show("Invalid edit!");
                }
            }
            else
            {
                MessageBox.Show("Selct a row!");
            }
        }

        private void bt_DeleteModule_Click(object sender, EventArgs e)
        {
            if (dgv_Modules.SelectedRows.Count > 0) //checks if a row is selected
            {
                try
                {
                    SqlConnection sqlConnection = new(Connection.Conn);
                    sqlConnection.Open();

                    string query = $"DELETE FROM Module WHERE mID = {dgv_Modules.CurrentRow.Cells[0].Value};";

                    SqlCommand command = new(query, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    GetModules();
                }
                catch
                {
                    MessageBox.Show("Module cannot be deleted!");
                }
            }
            else
            {
                MessageBox.Show("Selct a row!");
            }
        }
    }
}
