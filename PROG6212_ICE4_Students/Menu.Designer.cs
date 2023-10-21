namespace PROG_ICE4_Students
{
    partial class Menu
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
            lbl_Menu = new Label();
            bt_RegisterStudent = new Button();
            bt_Management = new Button();
            bt_Home = new Button();
            SuspendLayout();
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.Location = new Point(229, 36);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(38, 15);
            lbl_Menu.TabIndex = 0;
            lbl_Menu.Text = "Menu";
            // 
            // bt_RegisterStudent
            // 
            bt_RegisterStudent.Location = new Point(170, 98);
            bt_RegisterStudent.Name = "bt_RegisterStudent";
            bt_RegisterStudent.Size = new Size(165, 23);
            bt_RegisterStudent.TabIndex = 1;
            bt_RegisterStudent.Text = "Register Student";
            bt_RegisterStudent.UseVisualStyleBackColor = true;
            bt_RegisterStudent.Click += bt_RegisterStudent_Click;
            // 
            // bt_Management
            // 
            bt_Management.Location = new Point(170, 146);
            bt_Management.Name = "bt_Management";
            bt_Management.Size = new Size(165, 23);
            bt_Management.TabIndex = 2;
            bt_Management.Text = "Management";
            bt_Management.UseVisualStyleBackColor = true;
            bt_Management.Click += bt_Management_Click;
            // 
            // bt_Home
            // 
            bt_Home.Location = new Point(12, 12);
            bt_Home.Name = "bt_Home";
            bt_Home.Size = new Size(75, 23);
            bt_Home.TabIndex = 4;
            bt_Home.Text = "Go Home";
            bt_Home.UseVisualStyleBackColor = true;
            bt_Home.Click += bt_Home_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(bt_Home);
            Controls.Add(bt_Management);
            Controls.Add(bt_RegisterStudent);
            Controls.Add(lbl_Menu);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Menu;
        private Button bt_RegisterStudent;
        private Button bt_Management;
        private Button bt_Home;
    }
}