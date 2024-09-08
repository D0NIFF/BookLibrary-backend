using BookLibrary.Domain;
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

            var app = builder.Build();


            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
