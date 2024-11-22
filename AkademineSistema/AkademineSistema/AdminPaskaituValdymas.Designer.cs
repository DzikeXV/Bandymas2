namespace AkademineSistema
{
    partial class AdminPaskaituValdymas
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
            Label label1;
            buttonPridetiDalyka = new Button();
            buttonSalintiDalyka = new Button();
            buttonGrizti = new Button();
            listDalykai = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(468, 71);
            label1.TabIndex = 0;
            label1.Text = "Dalykų valdymas:";
            // 
            // buttonPridetiDalyka
            // 
            buttonPridetiDalyka.Location = new Point(12, 143);
            buttonPridetiDalyka.Name = "buttonPridetiDalyka";
            buttonPridetiDalyka.Size = new Size(191, 46);
            buttonPridetiDalyka.TabIndex = 1;
            buttonPridetiDalyka.Text = "Pridėti dalyką";
            buttonPridetiDalyka.UseVisualStyleBackColor = true;
            buttonPridetiDalyka.Click += buttonPridetiDalyka_Click;
            // 
            // buttonSalintiDalyka
            // 
            buttonSalintiDalyka.Location = new Point(209, 143);
            buttonSalintiDalyka.Name = "buttonSalintiDalyka";
            buttonSalintiDalyka.Size = new Size(213, 46);
            buttonSalintiDalyka.TabIndex = 2;
            buttonSalintiDalyka.Text = "Šalinti dalyką";
            buttonSalintiDalyka.UseVisualStyleBackColor = true;
            buttonSalintiDalyka.Click += buttonSalintiDalyka_Click;
            // 
            // buttonGrizti
            // 
            buttonGrizti.Location = new Point(428, 143);
            buttonGrizti.Name = "buttonGrizti";
            buttonGrizti.Size = new Size(150, 46);
            buttonGrizti.TabIndex = 3;
            buttonGrizti.Text = "Grįžti";
            buttonGrizti.UseVisualStyleBackColor = true;
            buttonGrizti.Click += buttonGrizti_Click;
            // 
            // listDalykai
            // 
            listDalykai.FormattingEnabled = true;
            listDalykai.Location = new Point(12, 377);
            listDalykai.Name = "listDalykai";
            listDalykai.Size = new Size(425, 196);
            listDalykai.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 284);
            label2.Name = "label2";
            label2.Size = new Size(644, 71);
            label2.TabIndex = 5;
            label2.Text = "Dėstomų dalykų sąrašas:";
            // 
            // AdminPaskaituValdymas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1028, 614);
            Controls.Add(label2);
            Controls.Add(listDalykai);
            Controls.Add(buttonGrizti);
            Controls.Add(buttonSalintiDalyka);
            Controls.Add(buttonPridetiDalyka);
            Controls.Add(label1);
            Name = "AdminPaskaituValdymas";
            Text = "AdminPaskaituValdymas";
            Load += AdminPaskaituValdymas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPridetiDalyka;
        private Button buttonSalintiDalyka;
        private Button buttonGrizti;
        private ListBox listDalykai;
        private Label label2;
    }
}