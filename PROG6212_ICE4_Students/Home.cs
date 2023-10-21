using PROG_ICE4_Students;

namespace PROG6212_ICE4_Students
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_Login_Click_1(object sender, EventArgs e)
        {
            Login l = new();
            l.Show();
            this.Hide();
        }

        private void bt_Register_Click_1(object sender, EventArgs e)
        {
            Register r = new();
            r.Show();
            this.Hide();
        }
    }
}