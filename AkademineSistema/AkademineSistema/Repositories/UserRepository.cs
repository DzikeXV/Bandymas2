using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class UserRepository
{
    private readonly string _connectionString;

    public UserRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

    public void AddUser(string firstName, string lastName, string role)
    {
        string username = $"{firstName.ToLower()}.{lastName.ToLower()}";
        string password = lastName.ToLower();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Users (Username, Password, Role, FirstName, LastName) VALUES (@Username, @Password, @Role, @FirstName, @LastName)";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteUser(int userId)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Users WHERE Id = @UserId";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public List<User> GetStudents()
    {
        var students = new List<User>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            SELECT Id, FirstName, LastName 
            FROM Users 
            WHERE Role = 'Student'";

            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new User
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2)
                        });
                    }
                }
            }
        }

        return students;
    }

   


    public List<User> GetStudentsByCourse(int courseId)
    {
        var students = new List<User>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            SELECT 
                u.Id AS StudentId, 
                u.FirstName, 
                u.LastName
            FROM Users u
            JOIN GroupStudents gs ON u.Id = gs.StudentId
            JOIN GroupSubjects gsj ON gs.GroupId = gsj.GroupId
            WHERE gsj.SubjectId = @CourseId
              AND u.Role = 'Student'";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CourseId", courseId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new User
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2)
                        });
                    }
                }
            }
        }

        return students;
    }


    public List<User> GetUsersByRole(string role)
    {
        var users = new List<User>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id, FirstName, LastName FROM Users WHERE Role = @Role";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Role", role);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2)
                        });
                    }
                }
            }
        }

        return users;
    }
}





public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }

    // Pilnas vardas
    public string FullName => $"{FirstName} {LastName}"; // Sugeneruoja vardą ir pavardę

}

