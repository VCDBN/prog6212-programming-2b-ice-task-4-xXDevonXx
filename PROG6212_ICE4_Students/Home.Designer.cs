namespace PROG6212_ICE4_Students
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_Login = new Button();
            lbl_Home = new Label();
            bt_Register = new Button();
            SuspendLayout();
            // 
            // bt_Login
            // 
            bt_Login.Location = new Point(211, 121);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(75, 23);
            bt_Login.TabIndex = 0;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            bt_Login.Click += bt_Login_Click_1;
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Location = new Point(225, 41);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(40, 15);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "Home";
            // 
            // bt_Register
            // 
            bt_Register.Location = new Point(211, 200);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(75, 23);
            bt_Register.TabIndex = 2;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = true;
            bt_Register.Click += bt_Register_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(bt_Register);
            Controls.Add(lbl_Home);
            Controls.Add(bt_Login);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_Login;
        private Label lbl_Home;
        private Button bt_Register;
    }
}