namespace AkademineSistema
{
    partial class AdminTeacherAdd
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
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 161);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 210);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Pavardė:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(221, 161);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 39);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(221, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 39);
            txtLastName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Išsaugoti";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Atšaukti";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminTeacherAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1103, 668);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminTeacherAdd";
            Text = "AdminTeacherAdd";
            Load += AdminTeacherAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSave;
        private Button btnCancel;
    }
}