namespace AkademineSistema
{
    partial class TeacherForm
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
            comboBoxKursas = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            textBoxPazymis = new TextBox();
            buttonPazymis = new Button();
            buttonAtsijungti = new Button();
            SuspendLayout();
            // 
            // comboBoxKursas
            // 
            comboBoxKursas.FormattingEnabled = true;
            comboBoxKursas.Location = new Point(223, 41);
            comboBoxKursas.Name = "comboBoxKursas";
            comboBoxKursas.Size = new Size(242, 40);
            comboBoxKursas.TabIndex = 0;
            comboBoxKursas.SelectedIndexChanged += comboBoxKursas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 1;
            label1.Text = "Pasirinkite kursą:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 219);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 4;
            label3.Text = "Pasirinkite studentą:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 260);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 548);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 6;
            label4.Text = "Pažymis:";
            // 
            // textBoxPazymis
            // 
            textBoxPazymis.Location = new Point(137, 548);
            textBoxPazymis.Name = "textBoxPazymis";
            textBoxPazymis.Size = new Size(200, 39);
            textBoxPazymis.TabIndex = 7;
            // 
            // buttonPazymis
            // 
            buttonPazymis.Location = new Point(1088, 515);
            buttonPazymis.Name = "buttonPazymis";
            buttonPazymis.Size = new Size(150, 46);
            buttonPazymis.TabIndex = 8;
            buttonPazymis.Text = "Išsaugoti";
            buttonPazymis.UseVisualStyleBackColor = true;
            buttonPazymis.Click += buttonPazymis_Click;
            // 
            // buttonAtsijungti
            // 
            buttonAtsijungti.Location = new Point(1088, 567);
            buttonAtsijungti.Name = "buttonAtsijungti";
            buttonAtsijungti.Size = new Size(150, 46);
            buttonAtsijungti.TabIndex = 9;
            buttonAtsijungti.Text = "Atsijungti";
            buttonAtsijungti.UseVisualStyleBackColor = true;
            buttonAtsijungti.Click += buttonAtsijungti_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1250, 627);
            Controls.Add(buttonAtsijungti);
            Controls.Add(buttonPazymis);
            Controls.Add(textBoxPazymis);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBoxKursas);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxKursas;
        private Label label1;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBoxPazymis;
        private Button buttonPazymis;
        private Button buttonAtsijungti;
    }
}