using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class CourseRepository
{
    private readonly string _connectionString;

    public CourseRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

    // Gauti visus kursus
    public List<Course> GetAllCourses()
    {
        var courses = new List<Course>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id, Name, TeacherID FROM Courses";
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            TeacherId = reader.IsDBNull(2) ? null : reader.GetInt32(2)
                        });
                    }
                }
            }
        }

        return courses;
    }

    // Pridėti naują kursą
    public void AddCourse(string name)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Courses (Name) VALUES (@Name)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Pašalinti kursą
    public void DeleteCourse(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Courses WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // gauti kursus pagal destytojus
    public List<Course> GetCoursesByTeacher(int teacherId)
    {
        var courses = new List<Course>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id, Name FROM Courses WHERE TeacherID = @TeacherID";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TeacherID", teacherId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        return courses;
    }


    // Priskirti dėstytoją kursui
    public void AssignTeacherToCourse(int courseId, int teacherId)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Courses SET TeacherID = @TeacherID WHERE Id = @CourseID";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@CourseID", courseId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}


public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? TeacherId { get; set; } // Gali buti 0

    public override string ToString()
    {
        return Name; // grazina kurso pavadinima
    }


}
