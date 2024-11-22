using System.Data.SqlClient;

namespace AkademineSistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Prašome įvesti vartotojo vardą ir slaptažodį.");
                return;
            }

            try
            {
                using (var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Role FROM Users WHERE Username = @Username AND Password = @Password";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0); // Gauname userId
                                string role = reader.GetString(1); // Gauname rolę

                                MessageBox.Show($"Prisijungta sėkmingai kaip {role}!");

                                // Atidaryk atitinkamą formą pagal rolę
                                OpenFormBasedOnRole(userId, role);
                            }
                            else
                            {
                                MessageBox.Show("Neteisingas vartotojo vardas arba slaptažodis.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Prisijungimo klaida: {ex.Message}");
            }
        }

        private void OpenFormBasedOnRole(int userId, string role)
        {
            if (role == "Admin")
            {
                var adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (role == "Teacher")
            {
                var teacherForm = new TeacherForm(userId); 
                teacherForm.Show();
            }
            else if (role == "Student")
            {
                var studentForm = new StudentForm(userId);
                studentForm.Show();
            }

          
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

