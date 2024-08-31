using System.ComponentModel.DataAnnotations;

namespace MyNewWebsite.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string? Login { get; set; }
        [Required(ErrorMessage = "Не указан login")]
        public int? Password { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        public List<Tasks> Task { get; set; }
    }
}
