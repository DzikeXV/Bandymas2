namespace AkademineSistema
{
    partial class AdminPriskirtiDestytojus
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
            buttonPatvirtinti = new Button();
            comboBoxDalykas = new ComboBox();
            comboBoxDestytojas = new ComboBox();
            buttonAtsaukti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 126);
            label1.Name = "label1";
            label1.Size = new Size(403, 32);
            label1.TabIndex = 0;
            label1.Text = "Pasirinkite dalyką kuri norite priskirti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 177);
            label2.Name = "label2";
            label2.Size = new Size(445, 32);
            label2.TabIndex = 1;
            label2.Text = "Pasirinkite kuri dėstytoją priskirti dalykui:";
            // 
            // buttonPatvirtinti
            // 
            buttonPatvirtinti.Location = new Point(34, 245);
            buttonPatvirtinti.Name = "buttonPatvirtinti";
            buttonPatvirtinti.Size = new Size(150, 46);
            buttonPatvirtinti.TabIndex = 2;
            buttonPatvirtinti.Text = "Patvirtinti";
            buttonPatvirtinti.UseVisualStyleBackColor = true;
            buttonPatvirtinti.Click += buttonPatvirtinti_Click;
            // 
            // comboBoxDalykas
            // 
            comboBoxDalykas.FormattingEnabled = true;
            comboBoxDalykas.Location = new Point(443, 123);
            comboBoxDalykas.Name = "comboBoxDalykas";
            comboBoxDalykas.Size = new Size(242, 40);
            comboBoxDalykas.TabIndex = 3;
            // 
            // comboBoxDestytojas
            // 
            comboBoxDestytojas.FormattingEnabled = true;
            comboBoxDestytojas.Location = new Point(485, 177);
            comboBoxDestytojas.Name = "comboBoxDestytojas";
            comboBoxDestytojas.Size = new Size(242, 40);
            comboBoxDestytojas.TabIndex = 4;
            // 
            // buttonAtsaukti
            // 
            buttonAtsaukti.Location = new Point(210, 245);
            buttonAtsaukti.Name = "buttonAtsaukti";
            buttonAtsaukti.Size = new Size(150, 46);
            buttonAtsaukti.TabIndex = 5;
            buttonAtsaukti.Text = "Atšaukti";
            buttonAtsaukti.UseVisualStyleBackColor = true;
            buttonAtsaukti.Click += buttonAtsaukti_Click;
            // 
            // AdminPriskirtiDestytojus
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1025, 506);
            Controls.Add(buttonAtsaukti);
            Controls.Add(comboBoxDestytojas);
            Controls.Add(comboBoxDalykas);
            Controls.Add(buttonPatvirtinti);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminPriskirtiDestytojus";
            Text = "AdminPriskirtiDestytojus";
            Load += AdminPriskirtiDestytojus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonPatvirtinti;
        private ComboBox comboBoxDalykas;
        private ComboBox comboBoxDestytojas;
        private Button buttonAtsaukti;
    }
}