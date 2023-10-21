namespace PROG_ICE4_Students.Menus
{
    partial class RegisterStudent
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
            lbl_RegisterStudent = new Label();
            lbl_Firstname = new Label();
            lbl_Surname = new Label();
            lbl_Contact = new Label();
            lbl_DOB = new Label();
            txb_Firstname = new TextBox();
            txb_Surname = new TextBox();
            dtp_DOB = new DateTimePicker();
            txb_Contact = new TextBox();
            bt_Register = new Button();
            bt_Back = new Button();
            clb_Modules = new CheckedListBox();
            lbl_Modules = new Label();
            SuspendLayout();
            // 
            // lbl_RegisterStudent
            // 
            lbl_RegisterStudent.AutoSize = true;
            lbl_RegisterStudent.Location = new Point(192, 34);
            lbl_RegisterStudent.Name = "lbl_RegisterStudent";
            lbl_RegisterStudent.Size = new Size(93, 15);
            lbl_RegisterStudent.TabIndex = 0;
            lbl_RegisterStudent.Text = "Register Student";
            // 
            // lbl_Firstname
            // 
            lbl_Firstname.AutoSize = true;
            lbl_Firstname.Location = new Point(111, 79);
            lbl_Firstname.Name = "lbl_Firstname";
            lbl_Firstname.Size = new Size(59, 15);
            lbl_Firstname.TabIndex = 1;
            lbl_Firstname.Text = "Firstname";
            // 
            // lbl_Surname
            // 
            lbl_Surname.AutoSize = true;
            lbl_Surname.Location = new Point(116, 117);
            lbl_Surname.Name = "lbl_Surname";
            lbl_Surname.Size = new Size(54, 15);
            lbl_Surname.TabIndex = 2;
            lbl_Surname.Text = "Surname";
            // 
            // lbl_Contact
            // 
            lbl_Contact.AutoSize = true;
            lbl_Contact.Location = new Point(116, 192);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new Size(49, 15);
            lbl_Contact.TabIndex = 3;
            lbl_Contact.Text = "Contact";
            // 
            // lbl_DOB
            // 
            lbl_DOB.AutoSize = true;
            lbl_DOB.Location = new Point(128, 152);
            lbl_DOB.Name = "lbl_DOB";
            lbl_DOB.Size = new Size(31, 15);
            lbl_DOB.TabIndex = 4;
            lbl_DOB.Text = "DOB";
            // 
            // txb_Firstname
            // 
            txb_Firstname.Location = new Point(207, 76);
            txb_Firstname.Name = "txb_Firstname";
            txb_Firstname.PlaceholderText = "Firstname";
            txb_Firstname.Size = new Size(100, 23);
            txb_Firstname.TabIndex = 5;
            // 
            // txb_Surname
            // 
            txb_Surname.Location = new Point(207, 117);
            txb_Surname.Name = "txb_Surname";
            txb_Surname.PlaceholderText = "Surname";
            txb_Surname.Size = new Size(100, 23);
            txb_Surname.TabIndex = 6;
            // 
            // dtp_DOB
            // 
            dtp_DOB.Location = new Point(207, 152);
            dtp_DOB.Name = "dtp_DOB";
            dtp_DOB.Size = new Size(200, 23);
            dtp_DOB.TabIndex = 7;
            // 
            // txb_Contact
            // 
            txb_Contact.Location = new Point(207, 189);
            txb_Contact.Name = "txb_Contact";
            txb_Contact.PlaceholderText = "000 000 0000";
            txb_Contact.Size = new Size(100, 23);
            txb_Contact.TabIndex = 8;
            txb_Contact.TextChanged += txb_Contact_TextChanged;
            // 
            // bt_Register
            // 
            bt_Register.Location = new Point(207, 251);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(75, 23);
            bt_Register.TabIndex = 9;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = true;
            bt_Register.Click += bt_Register_Click;
            // 
            // bt_Back
            // 
            bt_Back.Location = new Point(12, 12);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(75, 23);
            bt_Back.TabIndex = 10;
            bt_Back.Text = "Back";
            bt_Back.UseVisualStyleBackColor = true;
            bt_Back.Click += bt_Back_Click;
            // 
            // clb_Modules
            // 
            clb_Modules.FormattingEnabled = true;
            clb_Modules.Location = new Point(27, 223);
            clb_Modules.Name = "clb_Modules";
            clb_Modules.Size = new Size(120, 76);
            clb_Modules.TabIndex = 11;
            // 
            // lbl_Modules
            // 
            lbl_Modules.AutoSize = true;
            lbl_Modules.Location = new Point(37, 198);
            lbl_Modules.Name = "lbl_Modules";
            lbl_Modules.Size = new Size(53, 15);
            lbl_Modules.TabIndex = 12;
            lbl_Modules.Text = "Modules";
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(lbl_Modules);
            Controls.Add(clb_Modules);
            Controls.Add(bt_Back);
            Controls.Add(bt_Register);
            Controls.Add(txb_Contact);
            Controls.Add(dtp_DOB);
            Controls.Add(txb_Surname);
            Controls.Add(txb_Firstname);
            Controls.Add(lbl_DOB);
            Controls.Add(lbl_Contact);
            Controls.Add(lbl_Surname);
            Controls.Add(lbl_Firstname);
            Controls.Add(lbl_RegisterStudent);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_RegisterStudent;
        private Label lbl_Firstname;
        private Label lbl_Surname;
        private Label lbl_Contact;
        private Label lbl_DOB;
        private TextBox txb_Firstname;
        private TextBox txb_Surname;
        private DateTimePicker dtp_DOB;
        private TextBox txb_Contact;
        private Button bt_Register;
        private Button bt_Back;
        private CheckedListBox clb_Modules;
        private Label lbl_Modules;
    }
}