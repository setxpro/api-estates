using Microsoft.EntityFrameworkCore;
using Zend.Data;

namespace Zend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //# Add services to the container.


            // Add connection with database
            var connectionStringMysql = builder.Configuration.GetConnectionString("DataBase");
            builder.Services.AddDbContext<ZendDbContext>(x => x.UseMySql(
                connectionStringMysql,
                ServerVersion.Parse("8.0.32-MySQL")
                )
            );


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