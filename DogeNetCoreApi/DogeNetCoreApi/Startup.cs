using DogeNetCore.Controllers.lib.Controllers.Clips.Commands;
using DogeNetCore.Controllers.lib.Controllers.Users.Commands.Users;
using DogeNetCore.Controllers.lib.implementations.Controllers.Clips.Commands;
using DogeNetCore.Controllers.lib.implementations.Controllers.Users.Commands;
using DogeNetCore.DataAccess.lib.ClipsRepository;
using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Entities;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UserRepository;
using DogeNetCore.DataAccess.lib.implementations.EntityFramework.UserRepository.Entities;
using DogeNetCore.DataAccess.lib.UserRepository;
using DogeNetCore.DataAccess.lib.UserRepository.Entities;
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
            var userDbConnectionString = Configuration["connectionStrings:usersDBConnectionString"];
            //var clipDbConnectionString = Configuration["connectionStrings:localClips"];
            services.AddDbContext<UserContext>(o => o.UseSqlServer(userDbConnectionString));
            //services.AddDbContext<ClipContext>(o => o.UseSqlServer(clipDbConnectionString));
            services.AddScoped<IUserRepository<User>, UserRepository>();
            //services.AddScoped<IClipRepository<Clip>, ClipRepository>();
            services.AddScoped<IUsersCommand, UsersCommand>();
            //services.AddScoped<IClipsCommand, ClipsCommand>();


        }


        //public void Configure(IApplicationBuilder app,
        //    IHostingEnvironment env,
        //    UserContext userContext,
        //    ClipContext clipContext)
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            UserContext userContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            userContext.EnsureSeedDataForContext();
            //clipContext.EnsureSeedDataForContext();            
        }
    }
}
