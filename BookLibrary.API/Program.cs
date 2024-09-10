using BookLibrary.Database;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;
            
            builder.Services.AddDbContext<BookLibraryDBContext>(
                options =>
                {
                    options.UseNpgsql(configuration.GetConnectionString(nameof(BookLibraryDBContext)));
                });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
