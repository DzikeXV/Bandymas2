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
    public partial class AdminPaskaituAdd : Form
    {
        public string SubjectName { get; private set; }
        public bool IsSaved { get; private set; }

        public AdminPaskaituAdd()
        {
            InitializeComponent();
        }

        private void buttonIssaugoti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDalykas.Text))
            {
                MessageBox.Show("Dalyko pavadinimas negali būti tuščias");
                return;
            }

            SubjectName = textBoxDalykas.Text.Trim();
            IsSaved = true;
            this.Close();
        }

        private void buttonAtsaukti_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }

        private void AdminPaskaituAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
