namespace AkademineSistema
{
    partial class AdminGrupiuValdymas
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
            buttonPrideti = new Button();
            buttonPanaikinti = new Button();
            buttonBack = new Button();
            label2 = new Label();
            listGrupes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(465, 71);
            label1.TabIndex = 0;
            label1.Text = "Grupių valdymas:";
            // 
            // buttonPrideti
            // 
            buttonPrideti.Location = new Point(12, 142);
            buttonPrideti.Name = "buttonPrideti";
            buttonPrideti.Size = new Size(211, 46);
            buttonPrideti.TabIndex = 1;
            buttonPrideti.Text = "Pridėti grupę";
            buttonPrideti.UseVisualStyleBackColor = true;
            buttonPrideti.Click += buttonPrideti_Click;
            // 
            // buttonPanaikinti
            // 
            buttonPanaikinti.Location = new Point(249, 142);
            buttonPanaikinti.Name = "buttonPanaikinti";
            buttonPanaikinti.Size = new Size(214, 46);
            buttonPanaikinti.TabIndex = 2;
            buttonPanaikinti.Text = "Panaikinti grupę";
            buttonPanaikinti.UseVisualStyleBackColor = true;
            buttonPanaikinti.Click += buttonPanaikinti_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(490, 142);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 46);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Grįžti";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.5F, FontStyle.Bold);
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(399, 70);
            label2.TabIndex = 4;
            label2.Text = "Grupių sąrašas:";
            // 
            // listGrupes
            // 
            listGrupes.FormattingEnabled = true;
            listGrupes.Location = new Point(12, 325);
            listGrupes.Name = "listGrupes";
            listGrupes.Size = new Size(399, 324);
            listGrupes.TabIndex = 5;
            // 
            // AdminGrupiuValdymas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1137, 678);
            Controls.Add(listGrupes);
            Controls.Add(label2);
            Controls.Add(buttonBack);
            Controls.Add(buttonPanaikinti);
            Controls.Add(buttonPrideti);
            Controls.Add(label1);
            Name = "AdminGrupiuValdymas";
            Text = "AdminGrupiuValdymas";
            Load += AdminGrupiuValdymas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonPrideti;
        private Button buttonPanaikinti;
        private Button buttonBack;
        private Label label2;
        private ListBox listGrupes;
    }
}