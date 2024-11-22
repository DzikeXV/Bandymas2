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
    public partial class AdminPriskirtiDestytojus : Form
    {
        public AdminPriskirtiDestytojus()
        {
            InitializeComponent();
        }

        private void AdminPriskirtiDestytojus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Užkrauna kursus
            var courseRepository = new CourseRepository();
            var courses = courseRepository.GetAllCourses();
            comboBoxDalykas.DataSource = courses;
            comboBoxDalykas.DisplayMember = "Name";
            comboBoxDalykas.ValueMember = "Id";

            // Užkrauna dėstytojus
            var userRepository = new UserRepository();
            var teachers = userRepository.GetUsersByRole("Teacher");
            comboBoxDestytojas.DataSource = teachers;
            comboBoxDestytojas.DisplayMember = "FirstName"; 
            comboBoxDestytojas.ValueMember = "Id";
        }

        private void buttonPatvirtinti_Click(object sender, EventArgs e)
        {
            if (comboBoxDalykas.SelectedItem == null || comboBoxDestytojas.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite kursą ir dėstytoją.");
                return;
            }

            var selectedCourseId = (int)comboBoxDalykas.SelectedValue;
            var selectedTeacherId = (int)comboBoxDestytojas.SelectedValue;

            try
            {
                var courseRepository = new CourseRepository();
                courseRepository.AssignTeacherToCourse(selectedCourseId, selectedTeacherId);

                MessageBox.Show("Dėstytojas sėkmingai priskirtas kursui!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida priskiriant dėstytoją: {ex.Message}");
            }
        }

        private void buttonAtsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
