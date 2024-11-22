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
    public partial class AdminStudentAdd : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool IsSaved { get; private set; }


        public AdminStudentAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("užpildykite visus langus.");
                return;
            }

            FirstName = txtFirstName.Text.Trim();
            LastName = txtLastName.Text.Trim();
            IsSaved = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }

        private void AdminStudentAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
