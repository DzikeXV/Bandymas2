namespace AkademineSistema
{
    partial class AdminGrupes
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
            comboBoxGrupes = new ComboBox();
            buttonPerziureti = new Button();
            label2 = new Label();
            listBoxStudentai = new ListBox();
            label3 = new Label();
            listBoxDalykai = new ListBox();
            buttonGrizti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(440, 32);
            label1.TabIndex = 0;
            label1.Text = "Pasirinkite kuria grupe norite pasižiūrėti:";
            // 
            // comboBoxGrupes
            // 
            comboBoxGrupes.FormattingEnabled = true;
            comboBoxGrupes.Location = new Point(458, 66);
            comboBoxGrupes.Name = "comboBoxGrupes";
            comboBoxGrupes.Size = new Size(299, 40);
            comboBoxGrupes.TabIndex = 1;
            // 
            // buttonPerziureti
            // 
            buttonPerziureti.Location = new Point(815, 66);
            buttonPerziureti.Name = "buttonPerziureti";
            buttonPerziureti.Size = new Size(150, 40);
            buttonPerziureti.TabIndex = 2;
            buttonPerziureti.Text = "Peržiūrėti";
            buttonPerziureti.UseVisualStyleBackColor = true;
            buttonPerziureti.Click += buttonPerziureti_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 3;
            label2.Text = "Studentai:";
            // 
            // listBoxStudentai
            // 
            listBoxStudentai.FormattingEnabled = true;
            listBoxStudentai.Location = new Point(12, 203);
            listBoxStudentai.Name = "listBoxStudentai";
            listBoxStudentai.Size = new Size(240, 324);
            listBoxStudentai.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 168);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 5;
            label3.Text = "Dalykai:";
            // 
            // listBoxDalykai
            // 
            listBoxDalykai.FormattingEnabled = true;
            listBoxDalykai.Location = new Point(370, 203);
            listBoxDalykai.Name = "listBoxDalykai";
            listBoxDalykai.Size = new Size(240, 324);
            listBoxDalykai.TabIndex = 6;
            // 
            // buttonGrizti
            // 
            buttonGrizti.Location = new Point(944, 651);
            buttonGrizti.Name = "buttonGrizti";
            buttonGrizti.Size = new Size(150, 46);
            buttonGrizti.TabIndex = 7;
            buttonGrizti.Text = "Grįžti";
            buttonGrizti.UseVisualStyleBackColor = true;
            // 
            // AdminGrupes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1106, 709);
            Controls.Add(buttonGrizti);
            Controls.Add(listBoxDalykai);
            Controls.Add(label3);
            Controls.Add(listBoxStudentai);
            Controls.Add(label2);
            Controls.Add(buttonPerziureti);
            Controls.Add(comboBoxGrupes);
            Controls.Add(label1);
            Name = "AdminGrupes";
            Text = "AdminGrupes";
            Load += AdminGrupes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxGrupes;
        private Button buttonPerziureti;
        private Label label2;
        private ListBox listBoxStudentai;
        private Label label3;
        private ListBox listBoxDalykai;
        private Button buttonGrizti;
    }
}