using phones.Models;
using students.Models;
namespace students.Data
{
    public static class ApplicationContext
    {
        public static List<Student> Students { get; set; }
        public static List<Phone> Phones { get; set; }

    }
}
