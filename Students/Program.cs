using Students.Data;
using Students.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Get our connection string from the appsettings.json file.
var connectionString = builder.Configuration.GetConnectionString("StudentStore");

// The DbContext has scope lifetime by default.
builder.Services.AddSqlite<StudentStoreContext>(connectionString);

var app = builder.Build();

// GET /
app.MapGet("/", () => "Hello .NET!!");

app.MapStudentsEndpoints();
app.MapDepartmentEndpoints();

await app.MigrateDbAsync();

app.Run();
