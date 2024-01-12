using BookStore_C.BL.Interfaces;
using BookStore_C.BL.Services;
using BookStore_C.DL.Interfaces;
using BookStore_C.DL.Repositories;
using BookStore_C.HealthChecks;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BookStore_C
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddSingleton<IAuthorRepository, AuthorRepository>();
            builder.Services
                .AddSingleton<IAuthorService, AuthorService>();
            builder.Services
                .AddSingleton<IBookRepository, BookRepository>();
            builder.Services
                .AddSingleton<IBookService, BookService>();
            builder.Services
                .AddSingleton<ILibraryService, LibraryService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services
                .AddFluentValidationAutoValidation();
            builder.Services
                .AddValidatorsFromAssemblyContaining(typeof(Program));
            
            builder.Services.AddHealthChecks()
                .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");

            app.MapControllers();

            app.Run();
        }
    }
}
