using System.Reflection;
using DbUp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payment_API.Business;
using Payment_API.Business.Implementation;
using Payment_API.Model.Context;
using Payment_API.Repository.Generic;
using Payment_API.Repository.Generic.Implementation;

namespace Payment_API
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration["SqlServerConection:SqlServerConectionString"];
            services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            // creates the database if not yet exists
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader = DeployChanges.To.SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            upgrader.PerformUpgrade();

            services.AddApiVersioning();

            services.AddScoped<IClient, ClientBusinessImpl>();
            services.AddScoped<IBuyer, BuyerBusinessImpl>();
            services.AddScoped<ICard, CardBusinessImpl>();
            services.AddScoped<IPayment, PaymentBusinessImpl>();
            services.AddScoped<IPaymentsData, PaymentsDataBusinessImpl>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepositoryImpl<>));
            
            //var result = upgrader.PerformUpgrade();
            //Console.Out.WriteLine(result.Successful ? "Success" : "Failure");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}
