namespace PROG6212_ICE4_Students.Menus
{
    partial class DatabaseManagement
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
            tabController = new TabControl();
            tab_Students = new TabPage();
            txb_Search = new TextBox();
            dgv_Students = new DataGridView();
            tab_Modules = new TabPage();
            txb_EditModule = new TextBox();
            rbt_Name = new RadioButton();
            rbt_Code = new RadioButton();
            bt_DeleteModule = new Button();
            bt_EditModule = new Button();
            bt_AddModule = new Button();
            dgv_Modules = new DataGridView();
            tab_Assignment = new TabPage();
            txb_AssignMark = new TextBox();
            txb_SearchAssignment = new TextBox();
            bt_AssignMark = new Button();
            dgv_Assignment = new DataGridView();
            bt_Back = new Button();
            lbl_Database = new Label();
            tabController.SuspendLayout();
            tab_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            tab_Modules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Modules).BeginInit();
            tab_Assignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Assignment).BeginInit();
            SuspendLayout();
            // 
            // tabController
            // 
            tabController.Controls.Add(tab_Students);
            tabController.Controls.Add(tab_Modules);
            tabController.Controls.Add(tab_Assignment);
            tabController.Location = new Point(1, 47);
            tabController.Name = "tabController";
            tabController.SelectedIndex = 0;
            tabController.Size = new Size(581, 302);
            tabController.TabIndex = 0;
            // 
            // tab_Students
            // 
            tab_Students.Controls.Add(txb_Search);
            tab_Students.Controls.Add(dgv_Students);
            tab_Students.Location = new Point(4, 24);
            tab_Students.Name = "tab_Students";
            tab_Students.Padding = new Padding(3);
            tab_Students.Size = new Size(573, 274);
            tab_Students.TabIndex = 0;
            tab_Students.Text = "Students";
            tab_Students.UseVisualStyleBackColor = true;
            // 
            // txb_Search
            // 
            txb_Search.Location = new Point(16, 22);
            txb_Search.Name = "txb_Search";
            txb_Search.PlaceholderText = "Search Student ID";
            txb_Search.Size = new Size(107, 23);
            txb_Search.TabIndex = 1;
            txb_Search.TextChanged += txb_Search_TextChanged;
            // 
            // dgv_Students
            // 
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Students.Location = new Point(16, 51);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.RowTemplate.Height = 25;
            dgv_Students.Size = new Size(541, 208);
            dgv_Students.TabIndex = 0;
            // 
            // tab_Modules
            // 
            tab_Modules.Controls.Add(txb_EditModule);
            tab_Modules.Controls.Add(rbt_Name);
            tab_Modules.Controls.Add(rbt_Code);
            tab_Modules.Controls.Add(bt_DeleteModule);
            tab_Modules.Controls.Add(bt_EditModule);
            tab_Modules.Controls.Add(bt_AddModule);
            tab_Modules.Controls.Add(dgv_Modules);
            tab_Modules.Location = new Point(4, 24);
            tab_Modules.Name = "tab_Modules";
            tab_Modules.Padding = new Padding(3);
            tab_Modules.Size = new Size(573, 274);
            tab_Modules.TabIndex = 1;
            tab_Modules.Text = "Modules";
            tab_Modules.UseVisualStyleBackColor = true;
            // 
            // txb_EditModule
            // 
            txb_EditModule.Location = new Point(398, 168);
            txb_EditModule.Name = "txb_EditModule";
            txb_EditModule.PlaceholderText = "Code/Name";
            txb_EditModule.Size = new Size(115, 23);
            txb_EditModule.TabIndex = 6;
            // 
            // rbt_Name
            // 
            rbt_Name.AutoSize = true;
            rbt_Name.Location = new Point(482, 134);
            rbt_Name.Name = "rbt_Name";
            rbt_Name.Size = new Size(57, 19);
            rbt_Name.TabIndex = 5;
            rbt_Name.TabStop = true;
            rbt_Name.Text = "Name";
            rbt_Name.UseVisualStyleBackColor = true;
            // 
            // rbt_Code
            // 
            rbt_Code.AutoSize = true;
            rbt_Code.Location = new Point(382, 134);
            rbt_Code.Name = "rbt_Code";
            rbt_Code.Size = new Size(53, 19);
            rbt_Code.TabIndex = 4;
            rbt_Code.TabStop = true;
            rbt_Code.Text = "Code";
            rbt_Code.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteModule
            // 
            bt_DeleteModule.Location = new Point(398, 76);
            bt_DeleteModule.Name = "bt_DeleteModule";
            bt_DeleteModule.Size = new Size(115, 23);
            bt_DeleteModule.TabIndex = 3;
            bt_DeleteModule.Text = "Delete Module";
            bt_DeleteModule.UseVisualStyleBackColor = true;
            bt_DeleteModule.Click += bt_DeleteModule_Click;
            // 
            // bt_EditModule
            // 
            bt_EditModule.Location = new Point(398, 207);
            bt_EditModule.Name = "bt_EditModule";
            bt_EditModule.Size = new Size(115, 23);
            bt_EditModule.TabIndex = 2;
            bt_EditModule.Text = "Edit Module";
            bt_EditModule.UseVisualStyleBackColor = true;
            bt_EditModule.Click += bt_EditModule_Click;
            // 
            // bt_AddModule
            // 
            bt_AddModule.Location = new Point(398, 33);
            bt_AddModule.Name = "bt_AddModule";
            bt_AddModule.Size = new Size(115, 23);
            bt_AddModule.TabIndex = 1;
            bt_AddModule.Text = "Add Module";
            bt_AddModule.UseVisualStyleBackColor = true;
            bt_AddModule.Click += bt_AddModule_Click;
            // 
            // dgv_Modules
            // 
            dgv_Modules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Modules.Location = new Point(16, 18);
            dgv_Modules.Name = "dgv_Modules";
            dgv_Modules.RowTemplate.Height = 25;
            dgv_Modules.Size = new Size(344, 238);
            dgv_Modules.TabIndex = 0;
            // 
            // tab_Assignment
            // 
            tab_Assignment.Controls.Add(txb_AssignMark);
            tab_Assignment.Controls.Add(txb_SearchAssignment);
            tab_Assignment.Controls.Add(bt_AssignMark);
            tab_Assignment.Controls.Add(dgv_Assignment);
            tab_Assignment.Location = new Point(4, 24);
            tab_Assignment.Name = "tab_Assignment";
            tab_Assignment.Padding = new Padding(3);
            tab_Assignment.Size = new Size(573, 274);
            tab_Assignment.TabIndex = 2;
            tab_Assignment.Text = "Assignment";
            tab_Assignment.UseVisualStyleBackColor = true;
            // 
            // txb_AssignMark
            // 
            txb_AssignMark.Location = new Point(340, 19);
            txb_AssignMark.Name = "txb_AssignMark";
            txb_AssignMark.PlaceholderText = "Enter Mark (%)";
            txb_AssignMark.Size = new Size(100, 23);
            txb_AssignMark.TabIndex = 5;
            // 
            // txb_SearchAssignment
            // 
            txb_SearchAssignment.Location = new Point(25, 19);
            txb_SearchAssignment.Name = "txb_SearchAssignment";
            txb_SearchAssignment.PlaceholderText = "Search Student ID";
            txb_SearchAssignment.Size = new Size(126, 23);
            txb_SearchAssignment.TabIndex = 4;
            txb_SearchAssignment.TextChanged += txb_SearchAssignment_TextChanged;
            // 
            // bt_AssignMark
            // 
            bt_AssignMark.Location = new Point(458, 19);
            bt_AssignMark.Name = "bt_AssignMark";
            bt_AssignMark.Size = new Size(99, 23);
            bt_AssignMark.TabIndex = 3;
            bt_AssignMark.Text = "Assign Mark";
            bt_AssignMark.UseVisualStyleBackColor = true;
            bt_AssignMark.Click += bt_AssignMark_Click;
            // 
            // dgv_Assignment
            // 
            dgv_Assignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Assignment.Location = new Point(7, 61);
            dgv_Assignment.Name = "dgv_Assignment";
            dgv_Assignment.RowTemplate.Height = 25;
            dgv_Assignment.Size = new Size(550, 198);
            dgv_Assignment.TabIndex = 0;
            // 
            // bt_Back
            // 
            bt_Back.Location = new Point(12, 12);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(75, 23);
            bt_Back.TabIndex = 1;
            bt_Back.Text = "Back";
            bt_Back.UseVisualStyleBackColor = true;
            bt_Back.Click += bt_Back_Click;
            // 
            // lbl_Database
            // 
            lbl_Database.AutoSize = true;
            lbl_Database.Location = new Point(259, 20);
            lbl_Database.Name = "lbl_Database";
            lbl_Database.Size = new Size(55, 15);
            lbl_Database.TabIndex = 2;
            lbl_Database.Text = "Database";
            // 
            // DatabaseManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(lbl_Database);
            Controls.Add(bt_Back);
            Controls.Add(tabController);
            Name = "DatabaseManagement";
            Text = "DatabaseManagement";
            tabController.ResumeLayout(false);
            tab_Students.ResumeLayout(false);
            tab_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            tab_Modules.ResumeLayout(false);
            tab_Modules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Modules).EndInit();
            tab_Assignment.ResumeLayout(false);
            tab_Assignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Assignment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabController;
        private TabPage tab_Students;
        private DataGridView dgv_Students;
        private TabPage tab_Modules;
        private DataGridView dgv_Modules;
        private Button bt_Back;
        private Button bt_AddModule;
        private Button bt_DeleteModule;
        private Button bt_EditModule;
        private Label lbl_Database;
        private TextBox txb_Search;
        private TabPage tab_Assignment;
        private DataGridView dgv_Assignment;
        private Button bt_AssignMark;
        private TextBox txb_SearchAssignment;
        private TextBox txb_AssignMark;
        private RadioButton rbt_Name;
        private RadioButton rbt_Code;
        private TextBox txb_EditModule;
    }
}