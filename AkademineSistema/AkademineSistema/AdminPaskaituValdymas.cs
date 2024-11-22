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
    public partial class AdminPaskaituValdymas : Form
    {
        public AdminPaskaituValdymas()
        {
            InitializeComponent();
        }

        private void AdminPaskaituValdymas_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }
        private void LoadSubjects()
        {
            listDalykai.Items.Clear();

            try
            {
                var subjectRepository = new SubjectRepository();
                var subjects = subjectRepository.GetAllSubjects();

                foreach (var subject in subjects)
                {
                    listDalykai.Items.Add($"{subject.Id}: {subject.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida kraunant dalykus: {ex.Message}");
            }
        }

        private void buttonPridetiDalyka_Click(object sender, EventArgs e)
        {
            using (var AdminPaskaituAdd = new AdminPaskaituAdd())
            {
                AdminPaskaituAdd.ShowDialog();

                if (AdminPaskaituAdd.IsSaved)
                {
                    try
                    {
                        var subjectRepository = new SubjectRepository();
                        subjectRepository.AddSubject(AdminPaskaituAdd.SubjectName);

                        MessageBox.Show("Dalykas sėkmingai pridėtas!");
                        LoadSubjects(); // Atnaujina dalykų sąrašą
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Klaida pridedant dalyką: {ex.Message}");
                    }
                }
            }
        }

        private void buttonSalintiDalyka_Click(object sender, EventArgs e)
        {
            if (listDalykai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite dalyką, kurį norite pašalinti.");
                return;
            }

            string selectedItem = listDalykai.SelectedItem.ToString();
            int subjectId = int.Parse(selectedItem.Split(':')[0]);

            var confirmation = MessageBox.Show(
                "Ar tikrai norite pašalinti šį dalyką?",
                "Patvirtinimas",
                MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var subjectRepository = new SubjectRepository();
                    subjectRepository.DeleteSubject(subjectId);

                    MessageBox.Show("Dalykas sėkmingai pašalintas!");
                    LoadSubjects(); // Atnaujina dalykų sąrašą
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Klaida šalinant dalyką: {ex.Message}");
                }
            }
        }

        private void buttonGrizti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
