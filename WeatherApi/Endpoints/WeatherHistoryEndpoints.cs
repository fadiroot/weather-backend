using Microsoft.EntityFrameworkCore;
using WeatherApi.Data;

namespace WeatherApi.Endpoints
{
    public static class WeatherHistoryEndpoints
    {
        public static void MapWeatherHistoryEndpoints(this WebApplication app)
        {
            app.MapPost("/weatherhistory", async (ApplicationDbContext db, WeatherHistoryDto dto) =>
            {
                var history = new WeatherHistory
                {
                    Name = dto.Name,
                    SearchTime = DateTime.UtcNow
                };
                db.WeatherHistories.Add(history);
                await db.SaveChangesAsync();
                return Results.Created($"/weatherhistory/{history.Id}", history);
            });

            app.MapGet("/weatherhistory", async (ApplicationDbContext db) =>
            {
                var histories = await db.WeatherHistories.ToListAsync();
                return Results.Ok(histories);
            });
        }
    }

    public record WeatherHistoryDto(string Name);
} 