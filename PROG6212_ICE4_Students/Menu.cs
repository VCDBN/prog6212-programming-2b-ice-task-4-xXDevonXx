using PROG6212_ICE4_Students;
using PROG6212_ICE4_Students.Menus;

namespace PROG_ICE4_Students
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_RegisterStudent_Click(object sender, EventArgs e)
        {
            Menus.RegisterStudent rs = new();
            rs.Show();
            this.Hide();
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            Home h = new();
            h.Show();
            this.Close();
        }

        private void bt_Management_Click(object sender, EventArgs e)
        {
            DatabaseManagement dm = new();
            dm.Show();
            this.Hide();
        }
    }
}
