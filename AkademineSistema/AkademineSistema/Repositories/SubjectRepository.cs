using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SubjectRepository
{
    private readonly string _connectionString;

    public SubjectRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

    public void AddSubject(string name)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Courses (Name) VALUES (@Name)"; // Atnaujinta lentelės pavadinimas
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteSubject(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Courses WHERE Id = @Id"; // Atnaujinta lentelės pavadinimas
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Subject> GetAllSubjects()
    {
        var subjects = new List<Subject>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id, Name FROM Courses"; // Atnaujinta lentelės pavadinimas
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        return subjects;
    }
}

    public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
}
