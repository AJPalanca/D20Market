using System.ComponentModel.DataAnnotations;

namespace D20Market.Models
{
    public class Race
    {
        public int RaceId { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
