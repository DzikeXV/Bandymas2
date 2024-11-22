namespace AkademineSistema
{
    partial class AdminPriskirtiPaskaitas
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            checkedListBoxDalykai = new CheckedListBox();
            buttonPriskirti = new Button();
            buttonAtsaukti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(539, 32);
            label1.TabIndex = 0;
            label1.Text = "Pasirinkite grupę kuria norėsite priskirti dalykams:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(557, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 2;
            label2.Text = "Pasirinkite dalykus:";
            // 
            // checkedListBoxDalykai
            // 
            checkedListBoxDalykai.FormattingEnabled = true;
            checkedListBoxDalykai.Location = new Point(12, 126);
            checkedListBoxDalykai.Name = "checkedListBoxDalykai";
            checkedListBoxDalykai.Size = new Size(366, 256);
            checkedListBoxDalykai.TabIndex = 3;
            // 
            // buttonPriskirti
            // 
            buttonPriskirti.Location = new Point(12, 439);
            buttonPriskirti.Name = "buttonPriskirti";
            buttonPriskirti.Size = new Size(150, 46);
            buttonPriskirti.TabIndex = 4;
            buttonPriskirti.Text = "Priskirti";
            buttonPriskirti.UseVisualStyleBackColor = true;
            buttonPriskirti.Click += buttonPriskirti_Click;
            // 
            // buttonAtsaukti
            // 
            buttonAtsaukti.Location = new Point(228, 439);
            buttonAtsaukti.Name = "buttonAtsaukti";
            buttonAtsaukti.Size = new Size(150, 46);
            buttonAtsaukti.TabIndex = 5;
            buttonAtsaukti.Text = "Atšaukti";
            buttonAtsaukti.UseVisualStyleBackColor = true;
            buttonAtsaukti.Click += buttonAtsaukti_Click;
            // 
            // AdminPriskirtiPaskaitas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1145, 652);
            Controls.Add(buttonAtsaukti);
            Controls.Add(buttonPriskirti);
            Controls.Add(checkedListBoxDalykai);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AdminPriskirtiPaskaitas";
            Text = "AdminPriskirtiPaskaitas";
            Load += AdminPriskirtiPaskaitas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private CheckedListBox checkedListBoxDalykai;
        private Button buttonPriskirti;
        private Button buttonAtsaukti;
    }
}