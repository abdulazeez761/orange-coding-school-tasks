using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_first_task.Models
{
    public class Feadbacks
    {
        [Key]
        public int FeedbackID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public int SentToID { get; set; }

        public bool Viewed { get; set; } = false;

        public string Message { get; set; }

        public DateTime? Date { get; set; }

        [ForeignKey("SentToID")]
        public Employees SentTo { get; set; }
    }
}
