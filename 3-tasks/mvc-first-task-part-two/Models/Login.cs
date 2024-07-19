using System.ComponentModel.DataAnnotations;

namespace mvc_first_task.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }


    }
}
