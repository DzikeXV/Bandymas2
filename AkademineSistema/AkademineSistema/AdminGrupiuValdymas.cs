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
    public partial class AdminGrupiuValdymas : Form
    {
        public AdminGrupiuValdymas()
        {
            InitializeComponent();
        }

        private void buttonPrideti_Click(object sender, EventArgs e)
        {
            using (var AdminGrupiuAdd = new AdminGrupiuAdd())
            {
                AdminGrupiuAdd.ShowDialog();

                if (AdminGrupiuAdd.IsSaved)
                {
                    try
                    {
                        var groupRepository = new GroupRepository();
                        groupRepository.AddGroup(AdminGrupiuAdd.GroupName);

                        MessageBox.Show("Grupė sėkmingai pridėta!");
                        LoadGroups(); // Atnaujina grupių sąrašą
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Klaida pridedant grupę: {ex.Message}");
                    }
                }
            }
        }

        private void LoadGroups()
        {
            listGrupes.Items.Clear();

            try
            {
                var groupRepository = new GroupRepository();
                var groups = groupRepository.GetAllGroups();

                foreach (var group in groups)
                {
                    listGrupes.Items.Add($"{group.Id}: {group.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida kraunant grupes: {ex.Message}");
            }
        }

        private void AdminGrupiuValdymas_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void buttonPanaikinti_Click(object sender, EventArgs e)
        {
            if (listGrupes.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite grupę, kurią norite pašalinti.");
                return;
            }

            string selectedItem = listGrupes.SelectedItem.ToString();
            int groupId = int.Parse(selectedItem.Split(':')[0]);

            var confirmation = MessageBox.Show(
                "Ar tikrai norite pašalinti šią grupę?",
                "Patvirtinimas",
                MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var groupRepository = new GroupRepository();
                    groupRepository.DeleteGroup(groupId);

                    MessageBox.Show("Grupė sėkmingai pašalinta!");
                    LoadGroups(); // Atnaujina grupių sąrašą
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Klaida šalinant grupę: {ex.Message}");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
