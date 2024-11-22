namespace AkademineSistema
{
    partial class AdminStudentAdd
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 160);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(336, 39);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(182, 224);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(336, 39);
            txtLastName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(182, 296);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Išsaugoti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(368, 296);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Atšaukti";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 163);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 4;
            label1.Text = "Vardas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 227);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 5;
            label2.Text = "Pavardė";
            // 
            // AdminStudentAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1027, 601);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "AdminStudentAdd";
            Text = "AdminStudentAdd";
            Load += AdminStudentAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}