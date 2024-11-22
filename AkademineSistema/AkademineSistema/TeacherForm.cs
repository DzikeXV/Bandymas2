using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GradeRepository;

namespace AkademineSistema
{
    public partial class TeacherForm : Form
    {
        private int _teacherId;



        public TeacherForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
           
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courseRepository = new CourseRepository();
            var courses = courseRepository.GetCoursesByTeacher(_teacherId); // gauna kursus pagal destytoja

            comboBoxKursas.DataSource = courses;
            comboBoxKursas.DisplayMember = "Name"; // dalyko pavadinimas
            comboBoxKursas.ValueMember = "Id";    // dalyko ID
        }



        private void LoadStudentsByCourse(int courseId)
        {
            var userRepository = new UserRepository();
            var students = userRepository.GetStudentsByCourse(courseId);

            listBox1.DataSource = students; // saltinis
            listBox1.DisplayMember = "FullName"; // Vardas_pavarde
            listBox1.ValueMember = "Id";
        }



        private void buttonPazymis_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is User selectedStudent)
            {
                if (int.TryParse(textBoxPazymis.Text, out int score))
                {
                    int courseId = (int)comboBoxKursas.SelectedValue; // Pasirinkto kurso ID
                    var gradeRepository = new GradeRepository();

                    try
                    {
                        gradeRepository.SaveGrade(selectedStudent.Id, courseId, score);
                        MessageBox.Show($"Pažymys studentui {selectedStudent.FullName} sėkmingai išsaugotas!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Klaida išsaugant pažymį: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Įveskite pažymį.");
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite studentą iš sąrašo.");
            }
        }

        private void comboBoxKursas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKursas.SelectedValue is int courseId)
            {
                LoadStudentsByCourse(courseId);
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is StudentScore selectedStudent)
            {
                textBoxPazymis.Text = selectedStudent.Score?.ToString() ?? string.Empty; // Rodyti pažymį arba
            }
        }

        private void buttonAtsijungti_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
