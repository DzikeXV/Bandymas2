using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class StudentForm : Form
    {
        private int _userId;

        public StudentForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadGrades(_userId);
        }

        private void LoadGrades(int userId)
        {
            var gradeRepository = new GradeRepository(); // rysis su duombaze
            var grades = gradeRepository.GetGradesByStudent(userId); // pazxymiai

            listBox1.Items.Clear(); // isvalo duom

            foreach (var grade in grades)
            {
                var item = new ListViewItem(grade.CourseName);
                item.SubItems.Add(grade.Score.HasValue ? grade.Score.Value.ToString() : "Nėra"); // Pažymys
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
