using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using students.Models;

namespace students.Repositories.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student {Id = 1, Ad= "Muhammed", Soyad="Akıncı",Yas="12"},     
                new Student {Id = 2, Ad= "Arda", Soyad="Tekin",Yas="11"},     
                new Student {Id = 3, Ad= "Ahmet", Soyad="Sülü",Yas="14"}
            );
        }
    }
}
