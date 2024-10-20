
using Microsoft.EntityFrameworkCore;
using VacanGio.Context;
using VacanGio.Repositories;
using VacanGio.Services;

namespace VacanGio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<VacanGioContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest")));
            //Repo
            builder.Services.AddScoped<DestinazioneRepo>();
            builder.Services.AddScoped<PacchettoRepo>();
            builder.Services.AddScoped<RecensioneRepo>();

            //Services
            builder.Services.AddScoped<DestinazioneService>();
            builder.Services.AddScoped<PacchettoService>();
            builder.Services.AddScoped<RecensioneService>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors(builder =>
          builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
          );

            app.Run();
        }
    }
}
