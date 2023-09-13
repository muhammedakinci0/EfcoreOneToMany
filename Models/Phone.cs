using students.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace phones.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
     
        public string Phonenumber { get; set; }    
        public bool Default { get; set; }


    }
}
