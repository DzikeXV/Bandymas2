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
    public partial class AdminTeacherAdd : Form
    {
        public AdminTeacherAdd()
        {
            InitializeComponent();
        }

        private void AdminTeacherAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Užpildykite visus laukus.");
                return;
            }

            FirstName = txtFirstName.Text.Trim();
            LastName = txtLastName.Text.Trim();
            IsSaved = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool IsSaved { get; private set; }



    }
}
