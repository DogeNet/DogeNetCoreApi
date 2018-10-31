using DogeCore.Controllers.Lib.Controllers.Users.Commands;
using DogeNetCore.Controllers.lib.implementations.Controllers.Users.Commands;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UsersRepository.Entities;
using DogeNetCore.DataAccess.lib.UsersRepository;
using DogeNetCore.DataAccess.lib.UsersRepository.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DogeNetCoreApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connectionString = Configuration["connectionStrings:usersDBConnectionString"];
            services.AddScoped<IUsersCommand, UsersCommand>();
            services.AddDbContext<UsersContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<IUsersRepository<User>, UsersRepositroy>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UsersContext usersContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            usersContext.EnsureSeedDataForContext();
            
        }
    }
}
