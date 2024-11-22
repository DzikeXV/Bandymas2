namespace AkademineSistema
{
    partial class AdminForm
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
            btnAddStud = new Button();
            btnAddTeacher = new Button();
            GrupiuValdymas = new Button();
            buttonDalykai = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 78);
            label1.TabIndex = 0;
            label1.Text = "Sveiki, admin.";
            label1.Click += label1_Click;
            // 
            // btnAddStud
            // 
            btnAddStud.Location = new Point(12, 153);
            btnAddStud.Name = "btnAddStud";
            btnAddStud.Size = new Size(274, 81);
            btnAddStud.TabIndex = 1;
            btnAddStud.Text = "Studentai";
            btnAddStud.UseVisualStyleBackColor = true;
            btnAddStud.Click += btnAddStud_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(325, 153);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(276, 81);
            btnAddTeacher.TabIndex = 2;
            btnAddTeacher.Text = "Dėstytojai";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // GrupiuValdymas
            // 
            GrupiuValdymas.Location = new Point(645, 154);
            GrupiuValdymas.Name = "GrupiuValdymas";
            GrupiuValdymas.Size = new Size(265, 80);
            GrupiuValdymas.TabIndex = 3;
            GrupiuValdymas.Text = "Grupės";
            GrupiuValdymas.UseVisualStyleBackColor = true;
            GrupiuValdymas.Click += GrupiuValdymas_Click;
            // 
            // buttonDalykai
            // 
            buttonDalykai.Location = new Point(961, 153);
            buttonDalykai.Name = "buttonDalykai";
            buttonDalykai.Size = new Size(265, 81);
            buttonDalykai.TabIndex = 4;
            buttonDalykai.Text = "Dalykai";
            buttonDalykai.UseVisualStyleBackColor = true;
            buttonDalykai.Click += buttonDalykai_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 275);
            button1.Name = "button1";
            button1.Size = new Size(274, 80);
            button1.TabIndex = 5;
            button1.Text = "Priskirti dėstytojus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 275);
            button2.Name = "button2";
            button2.Size = new Size(276, 80);
            button2.TabIndex = 6;
            button2.Text = "Priskirti studentus į grupę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(645, 275);
            button3.Name = "button3";
            button3.Size = new Size(265, 80);
            button3.TabIndex = 7;
            button3.Text = "Priskirti paskaitas į grupę";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1124, 706);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 9;
            button4.Text = "Atsijungti";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1286, 764);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDalykai);
            Controls.Add(GrupiuValdymas);
            Controls.Add(btnAddTeacher);
            Controls.Add(btnAddStud);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddStud;
        private Button btnAddTeacher;
        private Button GrupiuValdymas;
        private Button buttonDalykai;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}