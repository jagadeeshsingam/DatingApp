using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class Value
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}