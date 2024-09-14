using BookLibrary.Application.Services;
using BookLibrary.Core.Interfaces;
using BookLibrary.Database;
using BookLibrary.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var configuration = builder.Configuration;

            builder.Services.AddDbContext<BookLibraryDBContext>(
                options =>
                {
                    options.UseNpgsql(configuration.GetConnectionString(nameof(BookLibraryDBContext)));
                });

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
