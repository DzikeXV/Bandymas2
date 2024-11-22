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
    public partial class AdminPriskirtiPaskaitas : Form
    {
        public AdminPriskirtiPaskaitas()
        {
            InitializeComponent();
        }

        private void AdminPriskirtiPaskaitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Užkrauna grupes
            var groupRepository = new GroupRepository();
            var groups = groupRepository.GetAllGroups();
            comboBox1.DataSource = groups;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            // Užkrauna kursus
            var courseRepository = new CourseRepository();
            var courses = courseRepository.GetAllCourses();
            checkedListBoxDalykai.Items.Clear();

            foreach (var course in courses)
            {
                checkedListBoxDalykai.Items.Add(course, false); // false reiškia, kad pradžioje visi nepasirinkti
            }
        }

        private void buttonPriskirti_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite grupę.");
                return;
            }

            var selectedGroupId = (int)comboBox1.SelectedValue;

            var selectedCourses = new List<Course>();
            foreach (var item in checkedListBoxDalykai.CheckedItems)
            {
                if (item is Course course)
                {
                    selectedCourses.Add(course);
                }
            }

            if (selectedCourses.Count == 0)
            {
                MessageBox.Show("Pasirinkite bent vieną kursą.");
                return;
            }

            try
            {
                var groupRepository = new GroupRepository();
                groupRepository.PriskirtiDalykusIGrupe(selectedGroupId, selectedCourses);

                MessageBox.Show("Kursai sėkmingai priskirti grupei!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida priskiriant kursus: {ex.Message}");
            }
        }

        private void buttonAtsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
