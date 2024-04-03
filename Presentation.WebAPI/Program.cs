using BusinessLogicLayer.ServiceRegistrations;
using Presentation.WebAPI.Extensions.ServiceRegistrations;
namespace Presentation.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigModelState();

            builder.Services.DbContextConfig(builder.Configuration);

            builder.Services.AutoMapperConfig();
            builder.Services.AddValidationRules();
            builder.Services.AddBllServices();

            builder.Services.RepositoriesConfig();

            builder.Services.AddMediatRConfig();


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureAuthenticatonJwt(builder.Configuration);



            var app = builder.Build();

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
