using phones.Models;
using System.ComponentModel.DataAnnotations;

namespace students.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Yas { get; set; }        
        public virtual List<Phone>? Phones { get; set; }
    }

    
}
