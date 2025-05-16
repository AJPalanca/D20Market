using Microsoft.EntityFrameworkCore;
using D20Market.Models;

namespace D20Market.Data
{
    public class D20MarketContextDb : DbContext
    {
        public D20MarketContextDb(DbContextOptions<D20MarketContextDb> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, Email = "player1@example.com", Name = "Alice" },
                new Player { PlayerId = 2, Email = "player2@example.com", Name = "Bob" }
            );
            var races = new[]
            {
                "Human", "Elf", "Dwarf", "Halfling", "Orc",
                "Tiefling", "Dragonborn", "Gnome", "Half-Elf", "Half-Orc"
            };

            for (int i = 0; i < races.Length; i++)
            {
                modelBuilder.Entity<Race>().HasData(new Race
                {
                    RaceId = i + 1,
                    Name = races[i]
                });
            }
            var classes = new[]
            {
                "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk",
                "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard"
            };

            for (int i = 0; i < classes.Length; i++)
            {
                modelBuilder.Entity<Class>().HasData(new Class
                {
                    ClassId = i + 1,
                    Name = classes[i]
                });
            }
            }
        }
    }