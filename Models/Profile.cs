using System.ComponentModel.DataAnnotations;

namespace Jander.HspService.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsTeacher { get; set; }
    }
}
