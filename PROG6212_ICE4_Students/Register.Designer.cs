namespace PROG_ICE4_Students
{
    partial class Register
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
            lbl_Register = new Label();
            lbl_Firstname = new Label();
            lbl_Surname = new Label();
            lbl_DOB = new Label();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txb_Password = new TextBox();
            txb_Email = new TextBox();
            dtp_DOB = new DateTimePicker();
            txb_Surname = new TextBox();
            txb_Firstname = new TextBox();
            bt_Register = new Button();
            bt_Back = new Button();
            bt_Show = new Button();
            SuspendLayout();
            // 
            // lbl_Register
            // 
            lbl_Register.AutoSize = true;
            lbl_Register.Location = new Point(240, 23);
            lbl_Register.Name = "lbl_Register";
            lbl_Register.Size = new Size(49, 15);
            lbl_Register.TabIndex = 0;
            lbl_Register.Text = "Register";
            // 
            // lbl_Firstname
            // 
            lbl_Firstname.AutoSize = true;
            lbl_Firstname.Location = new Point(107, 86);
            lbl_Firstname.Name = "lbl_Firstname";
            lbl_Firstname.Size = new Size(59, 15);
            lbl_Firstname.TabIndex = 1;
            lbl_Firstname.Text = "Firstname";
            // 
            // lbl_Surname
            // 
            lbl_Surname.AutoSize = true;
            lbl_Surname.Location = new Point(107, 137);
            lbl_Surname.Name = "lbl_Surname";
            lbl_Surname.Size = new Size(54, 15);
            lbl_Surname.TabIndex = 2;
            lbl_Surname.Text = "Surname";
            // 
            // lbl_DOB
            // 
            lbl_DOB.AutoSize = true;
            lbl_DOB.Location = new Point(116, 179);
            lbl_DOB.Name = "lbl_DOB";
            lbl_DOB.Size = new Size(31, 15);
            lbl_DOB.TabIndex = 3;
            lbl_DOB.Text = "DOB";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(116, 223);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(107, 265);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password";
            // 
            // txb_Password
            // 
            txb_Password.Location = new Point(206, 262);
            txb_Password.Name = "txb_Password";
            txb_Password.PasswordChar = '*';
            txb_Password.PlaceholderText = "Password";
            txb_Password.Size = new Size(100, 23);
            txb_Password.TabIndex = 6;
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(206, 220);
            txb_Email.Name = "txb_Email";
            txb_Email.PlaceholderText = "Email";
            txb_Email.Size = new Size(100, 23);
            txb_Email.TabIndex = 7;
            // 
            // dtp_DOB
            // 
            dtp_DOB.Location = new Point(206, 179);
            dtp_DOB.Name = "dtp_DOB";
            dtp_DOB.Size = new Size(200, 23);
            dtp_DOB.TabIndex = 8;
            // 
            // txb_Surname
            // 
            txb_Surname.Location = new Point(206, 134);
            txb_Surname.Name = "txb_Surname";
            txb_Surname.PlaceholderText = "Surname";
            txb_Surname.Size = new Size(100, 23);
            txb_Surname.TabIndex = 9;
            // 
            // txb_Firstname
            // 
            txb_Firstname.Location = new Point(206, 83);
            txb_Firstname.Name = "txb_Firstname";
            txb_Firstname.PlaceholderText = "Firstname";
            txb_Firstname.Size = new Size(100, 23);
            txb_Firstname.TabIndex = 10;
            // 
            // bt_Register
            // 
            bt_Register.Location = new Point(214, 317);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(75, 23);
            bt_Register.TabIndex = 11;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = true;
            bt_Register.Click += bt_Register_Click;
            // 
            // bt_Back
            // 
            bt_Back.Location = new Point(12, 12);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(75, 23);
            bt_Back.TabIndex = 12;
            bt_Back.Text = "Back";
            bt_Back.UseVisualStyleBackColor = true;
            bt_Back.Click += bt_Back_Click;
            // 
            // bt_Show
            // 
            bt_Show.Location = new Point(322, 262);
            bt_Show.Name = "bt_Show";
            bt_Show.Size = new Size(53, 23);
            bt_Show.TabIndex = 13;
            bt_Show.Text = "Show";
            bt_Show.UseVisualStyleBackColor = true;
            bt_Show.Click += bt_Show_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(bt_Show);
            Controls.Add(bt_Back);
            Controls.Add(bt_Register);
            Controls.Add(txb_Firstname);
            Controls.Add(txb_Surname);
            Controls.Add(dtp_DOB);
            Controls.Add(txb_Email);
            Controls.Add(txb_Password);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_DOB);
            Controls.Add(lbl_Surname);
            Controls.Add(lbl_Firstname);
            Controls.Add(lbl_Register);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Register;
        private Label lbl_Firstname;
        private Label lbl_Surname;
        private Label lbl_DOB;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txb_Password;
        private TextBox txb_Email;
        private DateTimePicker dtp_DOB;
        private TextBox txb_Surname;
        private TextBox txb_Firstname;
        private Button bt_Register;
        private Button bt_Back;
        private Button bt_Show;
    }
}