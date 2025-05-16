using D20Market.Models;

namespace D20Market.Data
{
    public static class DataSeeder
    {
        public static void SeedRandomCharacters(D20MarketContextDb context)
        {
            if (context.Characters.Any()) return;

            var rand = new Random();
            var characters = new List<Character>();

            for (int i = 1; i <= 25; i++)
            {
                characters.Add(new Character
                {
                    Name = $"Character{i}",
                    RaceId = rand.Next(1, 11),
                    ClassId = rand.Next(1, 13),
                    Level = rand.Next(1, 21),
                    Strength = rand.Next(8, 19),
                    Dexterity = rand.Next(8, 19),
                    Constitution = rand.Next(8, 19),
                    Intelligence = rand.Next(8, 19),
                    Wisdom = rand.Next(8, 19),
                    Charisma = rand.Next(8, 19),
                    IsPublic = i % 2 == 0,
                    Backstory = $"This is the backstory for your Character{i}.",
                    PlayerId = (i % 2) + 1,
                    ImageUrl = null
                });
            }

            context.Characters.AddRange(characters);
            context.SaveChanges();
        }
    }
}
