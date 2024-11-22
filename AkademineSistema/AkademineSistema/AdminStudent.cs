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
    public partial class AdminStudent : Form
    {
        public AdminStudent()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            lstStudents.Items.Clear();

            var userRepository = new UserRepository();
            var students = userRepository.GetUsersByRole("Student");

            foreach (var student in students)
            {
                lstStudents.Items.Add($"{student.Id}: {student.FirstName} {student.LastName}");
            }


        }


        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var AdminStudentAdd = new AdminStudentAdd();
            AdminStudentAdd.ShowDialog();

            if (AdminStudentAdd.IsSaved)
            {
                var userRepository = new UserRepository();
                userRepository.AddUser(AdminStudentAdd.FirstName, AdminStudentAdd.LastName, "Student");
                MessageBox.Show("Studentas sėkmingai pridėtas!");
                LoadStudents();
            }


        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite studentą kuri ištrinti.");
                return;
            }

            int studentId = int.Parse(lstStudents.SelectedItem.ToString().Split(':')[0]);
            var userRepository = new UserRepository();
            userRepository.DeleteUser(studentId);
            MessageBox.Show("studentas sėkmingai panaikintas!");
            LoadStudents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
