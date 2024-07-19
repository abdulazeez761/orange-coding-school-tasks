using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppMvcsCore.Models
{
    public class Teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [MaxLength(30)]
        [MinLength(3)]
        public string TeacherName { get; set; }
        public bool IsActive { get; set; } = true;
        [Range(22, 50)]
        public int TeacherAge { get; set; }

        public string Role { get; set; }


    }
}
