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

    }
}
