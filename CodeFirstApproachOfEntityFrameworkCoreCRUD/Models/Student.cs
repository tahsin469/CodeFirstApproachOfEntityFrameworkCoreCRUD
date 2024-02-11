using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachOfEntityFrameworkCoreCRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        [Required]
        public String? Name { get; set; }
        [Column("StudentGender", TypeName = "varchar(20)")]
        [Required]
        public String? Gender { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        public int? Num { get; set; }
    }
}
