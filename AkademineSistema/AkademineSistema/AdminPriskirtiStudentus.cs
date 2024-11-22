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
    public partial class AdminPriskirtiStudentus : Form
    {
        public AdminPriskirtiStudentus()
        {
            InitializeComponent();
        }

        private void AdminPriskirtiStudentus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Užkrauna grupes
            var groupRepository = new GroupRepository();
            var groups = groupRepository.GetAllGroups();
            comboBoxGrupes.DataSource = groups;
            comboBoxGrupes.DisplayMember = "Name";
            comboBoxGrupes.ValueMember = "Id";

            // Užkrauna studentus
            //    var userRepository = new UserRepository();
            //  var students = userRepository.GetUsersByRole("Student");
            //checkedListBoxStudentai.Items.Clear();

            var userRepository = new UserRepository();
            var students = userRepository.GetStudents(); // Šis metodas turėtų grąžinti studentų sąrašą

            checkedListBoxStudentai.DataSource = students; // Priskiriame studentų sąrašą
            checkedListBoxStudentai.DisplayMember = "FullName";
            checkedListBoxStudentai.ValueMember = "Id"; 

        /*    foreach (var student in students)
            {
                checkedListBoxStudentai.Items.Add(student, false); // false reiškia, kad iš pradžių studentai nepasirinkti
            } */
        }

        private void buttonPriskirti_Click(object sender, EventArgs e)
        {
            if (comboBoxGrupes.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite grupę.");
                return;
            }

            var selectedGroupId = (int)comboBoxGrupes.SelectedValue;

            var selectedStudents = new List<User>();
            foreach (var item in checkedListBoxStudentai.CheckedItems)
            {
                if (item is User student)
                {
                    selectedStudents.Add(student);
                }
            }

            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("Pasirinkite bent vieną studentą.");
                return;
            }

            try
            {
                var groupRepository = new GroupRepository();
                groupRepository.PriskirtiStudentusGrupei(selectedGroupId, selectedStudents);

                MessageBox.Show("Studentai sėkmingai priskirti grupei!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida priskiriant studentus: {ex.Message}");
            }
        }

        private void buttonAtsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
