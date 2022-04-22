using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class comment
    {
        public int ID { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public string Author { get; set; } = string.Empty;
         [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}