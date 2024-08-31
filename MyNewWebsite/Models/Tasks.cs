using System.ComponentModel.DataAnnotations;

namespace MyNewWebsite.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
