using Microsoft.EntityFrameworkCore;

namespace Students.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        // To Migrate our database.
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<StudentStoreContext>();

        await dbContext.Database.MigrateAsync();
    }

}
