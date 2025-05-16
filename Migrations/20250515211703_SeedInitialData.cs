using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace D20Market.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "player1@example.com", "Alice" },
                    { 2, "player2@example.com", "Bob" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Backstory", "Charisma", "Class", "Constitution", "Dexterity", "ImageUrl", "Intelligence", "IsPublic", "Level", "Name", "PlayerId", "Race", "Strength", "Wisdom" },
                values: new object[,]
                {
                    { 1, "This is the backstory for your Character1", 15, "Fighter", 14, 12, null, 13, false, 2, "Character1", 2, "Elf", 10, 11 },
                    { 2, "This is the backstory for your Character2", 15, "Cleric", 14, 12, null, 13, true, 3, "Character2", 1, "Elf", 10, 11 },
                    { 3, "This is the backstory for your Character3", 15, "Rogue", 14, 12, null, 13, false, 4, "Character3", 2, "Elf", 10, 11 },
                    { 4, "This is the backstory for your Character4", 15, "Ranger", 14, 12, null, 13, true, 5, "Character4", 1, "Elf", 10, 11 },
                    { 5, "This is the backstory for your Character5", 15, "Wizard", 14, 12, null, 13, false, 6, "Character5", 2, "Elf", 10, 11 },
                    { 6, "This is the backstory for your Character6", 15, "Fighter", 14, 12, null, 13, true, 7, "Character6", 1, "Elf", 10, 11 },
                    { 7, "This is the backstory for your Character7", 15, "Cleric", 14, 12, null, 13, false, 8, "Character7", 2, "Elf", 10, 11 },
                    { 8, "This is the backstory for your Character8", 15, "Rogue", 14, 12, null, 13, true, 9, "Character8", 1, "Elf", 10, 11 },
                    { 9, "This is the backstory for your Character9", 15, "Ranger", 14, 12, null, 13, false, 10, "Character9", 2, "Elf", 10, 11 },
                    { 10, "This is the backstory for your Character10", 15, "Wizard", 14, 12, null, 13, true, 11, "Character10", 1, "Elf", 10, 11 },
                    { 11, "This is the backstory for your Character11", 15, "Fighter", 14, 12, null, 13, false, 12, "Character11", 2, "Elf", 10, 11 },
                    { 12, "This is the backstory for your Character12", 15, "Cleric", 14, 12, null, 13, true, 13, "Character12", 1, "Elf", 10, 11 },
                    { 13, "This is the backstory for your Character13", 15, "Rogue", 14, 12, null, 13, false, 14, "Character13", 2, "Elf", 10, 11 },
                    { 14, "This is the backstory for your Character14", 15, "Ranger", 14, 12, null, 13, true, 15, "Character14", 1, "Elf", 10, 11 },
                    { 15, "This is the backstory for your Character15", 15, "Wizard", 14, 12, null, 13, false, 16, "Character15", 2, "Elf", 10, 11 },
                    { 16, "This is the backstory for your Character16", 15, "Fighter", 14, 12, null, 13, true, 17, "Character16", 1, "Elf", 10, 11 },
                    { 17, "This is the backstory for your Character17", 15, "Cleric", 14, 12, null, 13, false, 18, "Character17", 2, "Elf", 10, 11 },
                    { 18, "This is the backstory for your Character18", 15, "Rogue", 14, 12, null, 13, true, 19, "Character18", 1, "Elf", 10, 11 },
                    { 19, "This is the backstory for your Character19", 15, "Ranger", 14, 12, null, 13, false, 20, "Character19", 2, "Elf", 10, 11 },
                    { 20, "This is the backstory for your Character20", 15, "Wizard", 14, 12, null, 13, true, 1, "Character20", 1, "Elf", 10, 11 },
                    { 21, "This is the backstory for your Character21", 15, "Fighter", 14, 12, null, 13, false, 2, "Character21", 2, "Elf", 10, 11 },
                    { 22, "This is the backstory for your Character22", 15, "Cleric", 14, 12, null, 13, true, 3, "Character22", 1, "Elf", 10, 11 },
                    { 23, "This is the backstory for your Character23", 15, "Rogue", 14, 12, null, 13, false, 4, "Character23", 2, "Elf", 10, 11 },
                    { 24, "This is the backstory for your Character24", 15, "Ranger", 14, 12, null, 13, true, 5, "Character24", 1, "Elf", 10, 11 },
                    { 25, "This is the backstory for your Character25", 15, "Wizard", 14, 12, null, 13, false, 6, "Character25", 2, "Elf", 10, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);
        }
    }
}
