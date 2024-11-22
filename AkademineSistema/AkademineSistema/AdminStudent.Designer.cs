namespace AkademineSistema
{
    partial class AdminStudent
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
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnBack = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(12, 68);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(220, 46);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Pridėti studentą";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(238, 68);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(220, 46);
            btnRemoveStudent.TabIndex = 1;
            btnRemoveStudent.Text = "Pašalinti studentą";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(464, 68);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "Grįžti";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(12, 240);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(602, 452);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // AdminStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1044, 718);
            Controls.Add(lstStudents);
            Controls.Add(btnBack);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Name = "AdminStudent";
            Text = "AdminStudent";
            Load += AdminStudent_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnBack;
        private ListBox lstStudents;
    }
}