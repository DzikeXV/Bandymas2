namespace AkademineSistema
{
    partial class AdminPaskaituAdd
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
            textBoxDalykas = new TextBox();
            buttonIssaugoti = new Button();
            buttonAtsaukti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 0;
            label1.Text = "Įveskite dalyko pavadinimą:";
            // 
            // textBoxDalykas
            // 
            textBoxDalykas.Location = new Point(324, 57);
            textBoxDalykas.Name = "textBoxDalykas";
            textBoxDalykas.Size = new Size(251, 39);
            textBoxDalykas.TabIndex = 1;
            // 
            // buttonIssaugoti
            // 
            buttonIssaugoti.Location = new Point(425, 119);
            buttonIssaugoti.Name = "buttonIssaugoti";
            buttonIssaugoti.Size = new Size(150, 46);
            buttonIssaugoti.TabIndex = 2;
            buttonIssaugoti.Text = "Išsaugoti";
            buttonIssaugoti.UseVisualStyleBackColor = true;
            buttonIssaugoti.Click += buttonIssaugoti_Click;
            // 
            // buttonAtsaukti
            // 
            buttonAtsaukti.Location = new Point(425, 191);
            buttonAtsaukti.Name = "buttonAtsaukti";
            buttonAtsaukti.Size = new Size(150, 46);
            buttonAtsaukti.TabIndex = 3;
            buttonAtsaukti.Text = "Atšaukti";
            buttonAtsaukti.UseVisualStyleBackColor = true;
            buttonAtsaukti.Click += buttonAtsaukti_Click;
            // 
            // AdminPaskaituAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(836, 365);
            Controls.Add(buttonAtsaukti);
            Controls.Add(buttonIssaugoti);
            Controls.Add(textBoxDalykas);
            Controls.Add(label1);
            Name = "AdminPaskaituAdd";
            Text = "AdminPaskaituAdd";
            Load += AdminPaskaituAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDalykas;
        private Button buttonIssaugoti;
        private Button buttonAtsaukti;
    }
}