using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class GroupRepository
{
    private readonly string _connectionString;

    public GroupRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

    public void AddGroup(string name)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Groups (Name) VALUES (@Name)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteGroup(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Groups WHERE Id = @Id";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void PriskirtiStudentusGrupei(int groupId, List<User> students)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO GroupStudents (GroupId, StudentId) VALUES (@GroupId, @StudentId)";
            connection.Open();

            foreach (var student in students)
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupId", groupId);
                    command.Parameters.AddWithValue("@StudentId", student.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public void PriskirtiDalykusIGrupe(int groupId, List<Course> courses)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO GroupSubjects (GroupId, SubjectId) VALUES (@GroupId, @CourseId)";
            connection.Open();

            foreach (var course in courses)
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupId", groupId);
                    command.Parameters.AddWithValue("@CourseId", course.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    // Gauti grupes pagal kursą
    public List<Group> GetGroupsByCourse(int courseId)
    {
        var groups = new List<Group>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            SELECT DISTINCT g.Id, g.Name
            FROM Groups g
            JOIN GroupSubjects gs ON g.Id = gs.GroupId
            JOIN GroupStudents grs ON grs.GroupId = g.Id
            JOIN Users u ON grs.StudentId = u.Id
            WHERE gs.SubjectId = @CourseId
              AND u.Role = 'Student'";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CourseId", courseId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groups.Add(new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        return groups;
    }





    public List<Group> GetAllGroups()
    {
        var groups = new List<Group>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id, Name FROM Groups";
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groups.Add(new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        return groups;
    }
}




public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
}
