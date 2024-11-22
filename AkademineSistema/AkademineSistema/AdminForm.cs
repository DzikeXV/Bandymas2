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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // prideda stud
        private void btnAddStud_Click(object sender, EventArgs e)
        {
            var AdminStudent = new AdminStudent();
            AdminStudent.FormClosed += (s, args) => this.Show();
            this.Hide();
            AdminStudent.Show();
        }

        // prideda dest
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var AdminTeacher = new AdminTeacher();
            AdminTeacher.FormClosed += (s, args) => this.Show();
            this.Hide();
            AdminTeacher.Show();
        }

        // grupiu valdymas
        private void GrupiuValdymas_Click(object sender, EventArgs e)
        {
            var AdminGrupiuValdymas = new AdminGrupiuValdymas();
            AdminGrupiuValdymas.FormClosed += (s, args) => this.Show();
            this.Hide();
            AdminGrupiuValdymas.Show();
        }

        // dalyku valdymas
        private void buttonDalykai_Click(object sender, EventArgs e)
        {
            var AdminPaskaituValdymas = new AdminPaskaituValdymas();
            AdminPaskaituValdymas.FormClosed += (s, args) => this.Show();
            this.Hide();
            AdminPaskaituValdymas.Show();
        }

        // priskirti destytojus
        private void button1_Click(object sender, EventArgs e)
        {
            var AdminPriskirtiDestytojus = new AdminPriskirtiDestytojus();
            AdminPriskirtiDestytojus.ShowDialog();
        }

        // priskirti studentus
        private void button2_Click(object sender, EventArgs e)
        {
            var PriskirtiForm = new AdminPriskirtiStudentus();
            PriskirtiForm.ShowDialog();
        }

        // priskirti paskaitas
        private void button3_Click(object sender, EventArgs e)
        {
            var AdminPriskirtiPaskaitas = new AdminPriskirtiPaskaitas();
            AdminPriskirtiPaskaitas.ShowDialog();
        }

        private void buttonGrupesInfo_Click(object sender, EventArgs e)
        {

        }

        // grizta i login
        private void button4_Click(object sender, EventArgs e)
        {
    
            var loginForm = new Form1();
            loginForm.Show();

  
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
