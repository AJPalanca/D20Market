using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace D20Market.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }

        public List<Character> Characters { get; set; }
    }
}
