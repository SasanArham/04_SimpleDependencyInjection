
using DependencyInjection.Interface;
using DependencyInjection.Implement;
namespace DependencyInjection
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();




            builder.Services.AddScoped<IMyService, MyService>();
            builder.Services.AddTransient<IMyService2, SecondService>();
            builder.Services.AddTransient<IInnerService, InnerService>();






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

    public static class DependencyInjection
    {
        public static IServiceCollection AddInner(this IServiceCollection services)
        {

            services.AddScoped(typeof(IInnerService), typeof(InnerService));


            return services;
        }
    }


}

