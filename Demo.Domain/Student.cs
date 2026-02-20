namespace Demo.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? GraduationDate { get; set; }

        public Student() { }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
