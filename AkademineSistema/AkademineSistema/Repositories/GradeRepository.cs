using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Formats.Asn1.AsnWriter;

public class GradeRepository
{
    private readonly string _connectionString;

    public class StudentScore
    {
        public int UserId { get; set; } // Student ID iš Users lentelės
        public string FirstName { get; set; } // Studento vardas
        public string LastName { get; set; } // Studento pavardė
        public int? Score { get; set; } // Pažymys 

        
        public override string ToString()
        {
            return $"{FirstName} {LastName} - Pažymys: {(Score.HasValue ? Score.Value.ToString() : "Nėra")}";
        }
    }

    public class StudentGrade
    {
        public string CourseName { get; set; } // Kurso pavadinimas
        public int? Score { get; set; } // Pažymys (gali būti null, jei nėra įrašyto pažymio)

        public override string ToString()
        {
            return $"{CourseName}: {(Score.HasValue ? Score.Value.ToString() : "Nėra")}";
        }
    }

    public List<StudentGrade> GetGradesByStudent(int userId)
    {
        var grades = new List<StudentGrade>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            SELECT 
                c.Name AS CourseName,
                g.Score
            FROM Grades g
            JOIN Courses c ON g.CourseId = c.Id
            JOIN Users u ON g.UserId = u.Id
            WHERE g.UserId = @UserId AND u.Role = 'Student';";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grades.Add(new StudentGrade
                        {
                            CourseName = reader.GetString(0),
                            Score = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1)
                        });
                    }
                }
            }
        }

        return grades;
    }



    public GradeRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AkademineSistemaDB"].ConnectionString;
    }

   

    public List<StudentScore> GetStudentsAndScoresByCourse(int courseId)
    {
        var studentScores = new List<StudentScore>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            SELECT 
                u.Id AS UserId,
                u.FirstName,
                u.LastName,
                g.Score
            FROM Users u
            LEFT JOIN Grades g ON u.Id = g.UserId AND g.CourseId = @CourseId
            WHERE u.Role = 'Student';";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CourseId", courseId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentScores.Add(new StudentScore
                        {
                            UserId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Score = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3)
                        });
                    }
                }
            }
        }

        return studentScores;
    }


    // Išsaugoti arba redaguoti pažymį
    public void SaveGrade(int userId, int courseId, int score)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"
            MERGE INTO Grades AS Target
            USING (SELECT @UserId AS UserId, @CourseId AS CourseId) AS Source
            ON Target.UserId = Source.UserId AND Target.CourseId = Source.CourseId
            WHEN MATCHED THEN 
                UPDATE SET Score = @Score
            WHEN NOT MATCHED THEN
                INSERT (UserId, CourseId, Score) VALUES (@UserId, @CourseId, @Score);";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@CourseId", courseId);
                command.Parameters.AddWithValue("@Score", score);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }



}
