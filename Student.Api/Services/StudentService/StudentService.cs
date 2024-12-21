
namespace Student.Api.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private List<MyStudent> _studentList = new List<MyStudent>() {
            new MyStudent() {
                Id = 1,
                Name = "John Doe",
                Address = "123 Main" },
            new MyStudent() {
                Id = 2,
                Name = "Jane Doe",
                Address = "456 Main"
            }
            };
        public IEnumerable<MyStudent> Get()
        {
            return _studentList;
        }
    }

    public class MyStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
