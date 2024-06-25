using Microsoft.EntityFrameworkCore;
using Students.Data;
using Students.Mapping;

namespace Students.Endpoints;

public static class DepartmentEndpoints
{
    public static RouteGroupBuilder MapDepartmentEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("departments");

        group.MapGet("/", async (StudentStoreContext dbContext) =>
            await dbContext.Departments
                .Select(department => department.ToDto())
                .AsNoTracking()
                .ToListAsync());

        return group;
    }
}
