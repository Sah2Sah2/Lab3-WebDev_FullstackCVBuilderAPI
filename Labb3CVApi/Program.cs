using Labb3CVApi.Data;
using Microsoft.EntityFrameworkCore;


namespace Labb3CVApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add CORS 
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    policy =>
                    {
                        // Get the frontend URL from environment variable (or app settings in development)
                        var frontendUrl = builder.Configuration["FrontendUrl"];

                        // In case the environment variable is not set, fallback to localhost URL in development
                        if (string.IsNullOrEmpty(frontendUrl))
                        {
                            frontendUrl = "http://localhost:5000"; // Local development URL
                        }

                        // Allow localhost in development and the frontend URL in production
                        policy.WithOrigins("http://localhost:5000", frontendUrl)
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add DbContext
            builder.Services.AddDbContext<CvDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            var app = builder.Build();

            // Use CORS policy
            app.UseCors("AllowLocalhost");

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
