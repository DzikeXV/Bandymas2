namespace AkademineSistema
{
    partial class AdminTeacher
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
            lstTeachers = new ListBox();
            btnAddTeacher = new Button();
            btnRemoveTeacher = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lstTeachers
            // 
            lstTeachers.FormattingEnabled = true;
            lstTeachers.Location = new Point(51, 340);
            lstTeachers.Name = "lstTeachers";
            lstTeachers.Size = new Size(528, 420);
            lstTeachers.TabIndex = 0;
            lstTeachers.SelectedIndexChanged += lstTeachers_SelectedIndexChanged;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(51, 139);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(217, 46);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "Pridėti dėstytoją";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnRemoveTeacher
            // 
            btnRemoveTeacher.Location = new Point(288, 139);
            btnRemoveTeacher.Name = "btnRemoveTeacher";
            btnRemoveTeacher.Size = new Size(233, 46);
            btnRemoveTeacher.TabIndex = 2;
            btnRemoveTeacher.Text = "Pašalinti dėstytoją";
            btnRemoveTeacher.UseVisualStyleBackColor = true;
            btnRemoveTeacher.Click += btnRemoveTeacher_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(540, 139);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 3;
            btnBack.Text = "Atšaukti";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminTeacher
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1286, 842);
            Controls.Add(btnBack);
            Controls.Add(btnRemoveTeacher);
            Controls.Add(btnAddTeacher);
            Controls.Add(lstTeachers);
            Name = "AdminTeacher";
            Text = "AdminTeacher";
            Load += AdminTeacher_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstTeachers;
        private Button btnAddTeacher;
        private Button btnRemoveTeacher;
        private Button btnBack;
    }
}