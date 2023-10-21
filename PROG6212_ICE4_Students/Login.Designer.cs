namespace PROG_ICE4_Students
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Login = new Label();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txb_Email = new TextBox();
            txb_Password = new TextBox();
            bt_Login = new Button();
            bt_Back = new Button();
            bt_Show = new Button();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Location = new Point(230, 43);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(37, 15);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Login";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(141, 114);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 1;
            lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(131, 161);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(253, 111);
            txb_Email.Name = "txb_Email";
            txb_Email.PlaceholderText = "Email";
            txb_Email.Size = new Size(100, 23);
            txb_Email.TabIndex = 3;
            // 
            // txb_Password
            // 
            txb_Password.Location = new Point(253, 158);
            txb_Password.Name = "txb_Password";
            txb_Password.PasswordChar = '*';
            txb_Password.PlaceholderText = "Password";
            txb_Password.Size = new Size(100, 23);
            txb_Password.TabIndex = 4;
            // 
            // bt_Login
            // 
            bt_Login.Location = new Point(218, 219);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(75, 23);
            bt_Login.TabIndex = 5;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            bt_Login.Click += bt_Login_Click;
            // 
            // bt_Back
            // 
            bt_Back.Location = new Point(12, 12);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(75, 23);
            bt_Back.TabIndex = 6;
            bt_Back.Text = "Back";
            bt_Back.UseVisualStyleBackColor = true;
            bt_Back.Click += bt_Back_Click;
            // 
            // bt_Show
            // 
            bt_Show.Location = new Point(374, 158);
            bt_Show.Name = "bt_Show";
            bt_Show.Size = new Size(75, 23);
            bt_Show.TabIndex = 7;
            bt_Show.Text = "Show";
            bt_Show.UseVisualStyleBackColor = true;
            bt_Show.Click += bt_Show_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(bt_Show);
            Controls.Add(bt_Back);
            Controls.Add(bt_Login);
            Controls.Add(txb_Password);
            Controls.Add(txb_Email);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Login);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txb_Email;
        private TextBox txb_Password;
        private Button bt_Login;
        private Button bt_Back;
        private Button bt_Show;
    }
}