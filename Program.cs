using Microsoft.EntityFrameworkCore;
using D20Market.Data;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<D20MarketContextDb>(options =>
    options.UseSqlite("Data Source=D20Market.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<D20MarketContextDb>();
    db.Database.Migrate(); // Optional: ensures DB is up-to-date
    DataSeeder.SeedRandomCharacters(db); // ← This runs your seeding
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
