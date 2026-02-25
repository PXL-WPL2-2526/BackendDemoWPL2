using Dapper;
using Demo.Domain;

namespace Demo.Infrastructure.Repositories
{
    public class StudentRepository : Repository
    {
        public StudentRepository() : base()
        {

        }

        public IEnumerable<Student> GetAll()
        {
            using var connection = CreateConnection();

            string sql = @"
                SELECT 
                    studentId AS Id,FirstName, LastName
                FROM Students;
            ";
            return connection.Query<Student>(sql).ToList();
        }

        public Student? Get(int id)
        {
            using var connection = CreateConnection();

            string sql = @"
                SELECT 
                    studentId AS Id, FirstName, LastName, RegistrationDate, GraduationDate
                FROM Students WHERE studentId = @Id;
            ";

            return connection.QueryFirstOrDefault<Student>(sql, new { Id = id });
        }

        #region Create
        public void Add(Student student)
        {
            using var connection = CreateConnection();

            string sql = @"INSERT INTO Students (FirstName, LastName) VALUES (@FirstName, @LastName);";

            connection.Execute(sql, new { FirstName = student.FirstName, LastName = student.LastName });
        }
        #endregion

        #region Delete
        public void Remove(int id)
        {
            using var connection = CreateConnection();

            string sql = "DELETE FROM Students WHERE studentId = @Id";

            connection.Execute(sql, new { Id = id });
        }
        #endregion
    }
}
