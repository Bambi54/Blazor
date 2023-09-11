namespace cw11.Data
{
    public interface IStudentService
    {
        public ICollection<Student> GetStudents();
        public Student? GetStudent(int id);
    }
    public class StudentService: IStudentService
    {
        private readonly ICollection<Student> _students;

        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Krystian",
                    LastName = "Szturemski",
                    Birthdate = DateTime.Parse("01/01/2000"),
                    Studies = "Informatyka",
                    AvatarURL = "https://img.freepik.com/darmowe-wektory/awatar-postaci-biznesmen-na-bialym-tle_24877-60111.jpg?w=2000"

                },
                new Student
                {
                    ID = 2,
                    FirstName = "Jan",
                    LastName = "Zalewski",
                    Birthdate = DateTime.Parse("01/01/1990"),
                    Studies = "Nowe Media",
                    AvatarURL = "https://img.freepik.com/darmowe-wektory/awatar-postaci-biznesmen-na-bialym-tle_24877-60111.jpg?w=2000"

                },
                new Student
                {
                    ID = 3,
                    FirstName = "Aleksander",
                    LastName = "Babij",
                    Birthdate = DateTime.Parse("01/01/2001"),
                    Studies = "Zarządzanie",
                    AvatarURL = "https://img.freepik.com/darmowe-wektory/awatar-postaci-biznesmen-na-bialym-tle_24877-60111.jpg?w=2000"

                }
            };
        }

        public ICollection<Student> GetStudents()
        {
            return _students;
        }

        public Student? GetStudent(int id)
        {
            return _students.FirstOrDefault(e => e.ID == id);
        }

    }
}
