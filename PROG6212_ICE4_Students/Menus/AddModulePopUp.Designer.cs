namespace PROG6212_ICE4_Students.Menus
{
    partial class AddModulePopUp
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
            lbl_AddingModule = new Label();
            lbl_Code = new Label();
            lbl_Name = new Label();
            txb_Code = new TextBox();
            txb_Name = new TextBox();
            bt_AddModule = new Button();
            SuspendLayout();
            // 
            // lbl_AddingModule
            // 
            lbl_AddingModule.AutoSize = true;
            lbl_AddingModule.Location = new Point(167, 27);
            lbl_AddingModule.Name = "lbl_AddingModule";
            lbl_AddingModule.Size = new Size(90, 15);
            lbl_AddingModule.TabIndex = 0;
            lbl_AddingModule.Text = "Adding Module";
            // 
            // lbl_Code
            // 
            lbl_Code.AutoSize = true;
            lbl_Code.Location = new Point(90, 87);
            lbl_Code.Name = "lbl_Code";
            lbl_Code.Size = new Size(35, 15);
            lbl_Code.TabIndex = 1;
            lbl_Code.Text = "Code";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(94, 129);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Name";
            // 
            // txb_Code
            // 
            txb_Code.Location = new Point(167, 87);
            txb_Code.Name = "txb_Code";
            txb_Code.PlaceholderText = "Code";
            txb_Code.Size = new Size(100, 23);
            txb_Code.TabIndex = 3;
            // 
            // txb_Name
            // 
            txb_Name.Location = new Point(167, 129);
            txb_Name.Name = "txb_Name";
            txb_Name.PlaceholderText = "Name";
            txb_Name.Size = new Size(100, 23);
            txb_Name.TabIndex = 4;
            // 
            // bt_AddModule
            // 
            bt_AddModule.Location = new Point(157, 210);
            bt_AddModule.Name = "bt_AddModule";
            bt_AddModule.Size = new Size(100, 23);
            bt_AddModule.TabIndex = 5;
            bt_AddModule.Text = "Add Module";
            bt_AddModule.UseVisualStyleBackColor = true;
            bt_AddModule.Click += bt_AddModule_Click;
            // 
            // AddModulePopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(bt_AddModule);
            Controls.Add(txb_Name);
            Controls.Add(txb_Code);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Code);
            Controls.Add(lbl_AddingModule);
            Name = "AddModulePopUp";
            Text = "AddModulePopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_AddingModule;
        private Label lbl_Code;
        private Label lbl_Name;
        private TextBox txb_Code;
        private TextBox txb_Name;
        private Button bt_AddModule;
    }
}