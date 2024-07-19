using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppMvcsCore.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [MaxLength(30)]
        [MinLength(3)]
        public string CourseName { get; set; }

        public int TeacherId { get; set; }
        [Range(0, 25)]
        public int Capacity { get; set; }

    }
}
