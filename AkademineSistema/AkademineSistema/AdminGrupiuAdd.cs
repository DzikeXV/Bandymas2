using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    public partial class AdminGrupiuAdd : Form
    {
        public string GroupName { get; private set; }
        public bool IsSaved { get; private set; }

        public AdminGrupiuAdd()
        {
            InitializeComponent();
        }

        private void AdminGrupiuAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonPridetiGrupe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxGrupe.Text))
            {
                MessageBox.Show("Grupės pavadinimas negali būti tuščias!");
                return;
            }

            GroupName = textboxGrupe.Text.Trim();
            IsSaved = true;
            this.Close();
        }

        private void buttonAtsaukti_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }
    }
}
