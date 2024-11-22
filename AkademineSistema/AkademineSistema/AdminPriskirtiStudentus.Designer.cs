namespace AkademineSistema
{
    partial class AdminPriskirtiStudentus
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
            comboBoxGrupes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            checkedListBoxStudentai = new CheckedListBox();
            buttonPriskirti = new Button();
            buttonAtsaukti = new Button();
            SuspendLayout();
            // 
            // comboBoxGrupes
            // 
            comboBoxGrupes.FormattingEnabled = true;
            comboBoxGrupes.Location = new Point(553, 92);
            comboBoxGrupes.Name = "comboBoxGrupes";
            comboBoxGrupes.Size = new Size(242, 40);
            comboBoxGrupes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(535, 32);
            label1.TabIndex = 1;
            label1.Text = "Pasirinkite grupe į kurią norite priskirti studentus:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 2;
            label2.Text = "Pasirinkite studentus:";
            // 
            // checkedListBoxStudentai
            // 
            checkedListBoxStudentai.FormattingEnabled = true;
            checkedListBoxStudentai.Location = new Point(12, 221);
            checkedListBoxStudentai.Name = "checkedListBoxStudentai";
            checkedListBoxStudentai.Size = new Size(382, 364);
            checkedListBoxStudentai.TabIndex = 3;
            // 
            // buttonPriskirti
            // 
            buttonPriskirti.Location = new Point(12, 624);
            buttonPriskirti.Name = "buttonPriskirti";
            buttonPriskirti.Size = new Size(150, 82);
            buttonPriskirti.TabIndex = 4;
            buttonPriskirti.Text = "Priskirti studentus";
            buttonPriskirti.UseVisualStyleBackColor = true;
            buttonPriskirti.Click += buttonPriskirti_Click;
            // 
            // buttonAtsaukti
            // 
            buttonAtsaukti.Location = new Point(244, 624);
            buttonAtsaukti.Name = "buttonAtsaukti";
            buttonAtsaukti.Size = new Size(150, 82);
            buttonAtsaukti.TabIndex = 5;
            buttonAtsaukti.Text = "Atšaukti";
            buttonAtsaukti.UseVisualStyleBackColor = true;
            buttonAtsaukti.Click += buttonAtsaukti_Click;
            // 
            // AdminPriskirtiStudentus
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1117, 792);
            Controls.Add(buttonAtsaukti);
            Controls.Add(buttonPriskirti);
            Controls.Add(checkedListBoxStudentai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGrupes);
            Name = "AdminPriskirtiStudentus";
            Text = "AdminPriskirtiStudentus";
            Load += AdminPriskirtiStudentus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGrupes;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxStudentai;
        private Button buttonPriskirti;
        private Button buttonAtsaukti;
    }
}