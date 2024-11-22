namespace AkademineSistema
{
    partial class AdminGrupiuAdd
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
            textboxGrupe = new TextBox();
            buttonPridetiGrupe = new Button();
            buttonAtsaukti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 0;
            label1.Text = "Įrašykite grupės pavadinima:";
            // 
            // textboxGrupe
            // 
            textboxGrupe.Location = new Point(334, 73);
            textboxGrupe.Name = "textboxGrupe";
            textboxGrupe.Size = new Size(259, 39);
            textboxGrupe.TabIndex = 1;
            // 
            // buttonPridetiGrupe
            // 
            buttonPridetiGrupe.Location = new Point(443, 138);
            buttonPridetiGrupe.Name = "buttonPridetiGrupe";
            buttonPridetiGrupe.Size = new Size(150, 46);
            buttonPridetiGrupe.TabIndex = 2;
            buttonPridetiGrupe.Text = "Pridėti";
            buttonPridetiGrupe.UseVisualStyleBackColor = true;
            buttonPridetiGrupe.Click += buttonPridetiGrupe_Click;
            // 
            // buttonAtsaukti
            // 
            buttonAtsaukti.Location = new Point(443, 210);
            buttonAtsaukti.Name = "buttonAtsaukti";
            buttonAtsaukti.Size = new Size(150, 46);
            buttonAtsaukti.TabIndex = 3;
            buttonAtsaukti.Text = "Atšaukti";
            buttonAtsaukti.UseVisualStyleBackColor = true;
            buttonAtsaukti.Click += buttonAtsaukti_Click;
            // 
            // AdminGrupiuAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(679, 345);
            Controls.Add(buttonAtsaukti);
            Controls.Add(buttonPridetiGrupe);
            Controls.Add(textboxGrupe);
            Controls.Add(label1);
            Name = "AdminGrupiuAdd";
            Text = "AdminGrupiuAdd";
            Load += AdminGrupiuAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxGrupe;
        private Button buttonPridetiGrupe;
        private Button buttonAtsaukti;
    }
}