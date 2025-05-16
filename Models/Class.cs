using System.ComponentModel.DataAnnotations;

namespace D20Market.Models
{
    public class Class
    {
        public int ClassId { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
