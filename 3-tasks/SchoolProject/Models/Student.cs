using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppMvcsCore.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [MaxLength(30)]
        [MinLength(3)]
        public string StudentName { get; set; }
        public bool IsActive { get; set; } = true;
        [Range(6, 18)]
        public int StudentAge { get; set; }
        public string photoPath { get; set; }
        public string Role { get; set; }

    }

}
