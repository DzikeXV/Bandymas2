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
    public partial class AdminTeacher : Form
    {
        public AdminTeacher()
        {
            InitializeComponent();
        }

        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            lstTeachers.Items.Clear();

            try
            {
                var userRepository = new UserRepository();
                var teachers = userRepository.GetUsersByRole("Teacher");

                foreach (var teacher in teachers)
                {
                    lstTeachers.Items.Add($"{teacher.Id}: {teacher.FirstName} {teacher.LastName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida kraunant dėstytojų sąrašą: {ex.Message}");
            }
        }


        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            using (var AdminTeacherAdd = new AdminTeacherAdd())
            {
                AdminTeacherAdd.ShowDialog();

                if (AdminTeacherAdd.IsSaved)
                {
                    try
                    {
                        var userRepository = new UserRepository();
                        userRepository.AddUser(AdminTeacherAdd.FirstName, AdminTeacherAdd.LastName, "Teacher");

                        string username = $"{AdminTeacherAdd.FirstName.ToLower()}.{AdminTeacherAdd.LastName.ToLower()}";
                        string password = AdminTeacherAdd.LastName.ToLower();

                        MessageBox.Show($"Pavyko! Prisijungimo vardas: {username}\nSlaptažodis: {password}");
                        LoadTeachers(); // Atnaujina dėstytojų sąrašą
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Klaida pridedant dėstytoją: {ex.Message}");
                    }
                }
            }
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite dėstytoją, kurį norite pašalinti.");
                return;
            }

            string selectedItem = lstTeachers.SelectedItem.ToString();
            int teacherId = int.Parse(selectedItem.Split(':')[0]);

            try
            {
                var userRepository = new UserRepository();
                userRepository.DeleteUser(teacherId);

                MessageBox.Show("Dėstytojas pašalintas sėkmingai!");
                LoadTeachers(); // Atnaujina dėstytojų sąrašą
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida šalinant dėstytoją: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
