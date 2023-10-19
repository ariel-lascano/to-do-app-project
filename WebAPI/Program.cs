using Microsoft.EntityFrameworkCore;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);
// Load connection string from .json app. settings:
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDatabaseContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddSignalR();
builder.Services.AddControllers();
var app = builder.Build();
app.UseAuthorization();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<NotificationHub>("/notificationHub");
});
app.UseStaticFiles();
app.MapControllers();
app.Run();
