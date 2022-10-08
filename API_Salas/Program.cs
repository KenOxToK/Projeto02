using API_Alunos.Context;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Obter a string de conexão com o banco de dadosdo arquivo appsettings.json
            string mySqlConnection = builder.Configuration.GetConnectionString("Connection");

            builder.Services.AddDbContext<AppDbContext>(options =>
                                options.UseSqlServer(mySqlConnection));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
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