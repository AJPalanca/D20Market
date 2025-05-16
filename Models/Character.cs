using System.ComponentModel.DataAnnotations;

namespace D20Market.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        [Required]
        public string Name { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        [Range(1, 20)]
        public int Level { get; set; }

        [Range(1, 20)]
        public int Strength { get; set; }

        [Range(1, 20)]
        public int Dexterity { get; set; }

        [Range(1, 20)]
        public int Constitution { get; set; }

        [Range(1, 20)]
        public int Intelligence { get; set; }

        [Range(1, 20)]
        public int Wisdom { get; set; }

        [Range(1, 20)]
        public int Charisma { get; set; }

        public string? Backstory { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsPublic { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
