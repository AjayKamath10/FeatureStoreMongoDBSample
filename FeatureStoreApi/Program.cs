using FeatureStoreApi.Controllers;
using FeatureStoreApi.Models;
using MongoDB.Driver;
using FeatureStoreApi.Services;

namespace FeatureStoreApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));
            builder.Services.AddSingleton<MongoDBService>();
            //builder.Services.AddScoped(FeaturePublishController) ;

            var app = builder.Build();

            // Configure the HTTP request pipeline

            


            app.MapControllers();

            app.Run();
        }
    }
}
