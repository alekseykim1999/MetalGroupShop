using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using MusicShop.Data;
using MusicShop.Data.FileModels;
using MusicShop.Data.Mocks;
using MusicShop.Data.Models;
using MusicShop.Data.Repository;
using MusicShop.Interfaces;
using MusicShop.WorkClasses;
using React.AspNet;
using Supermarket.Item;

namespace MusicShop
{
    public class Startup
    {

        private IConfiguration _confString;

        public Startup(IHostingEnvironment host)
        {
            _confString = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 44344;
            });
            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
                options.ExcludedHosts.Add("us.example.com");
                options.ExcludedHosts.Add("www.example.com");
            });
            services.AddDbContext<AppDBContent>(options=>options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddDbContext<ApplicationContext>();
            services.AddTransient<IAllAlbums, MockAlbum>(); 
            services.AddTransient<IAllGroups, MockGroups>();
            services.AddMvcCore(); 
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDistributedMemoryCache();
            services.AddSignalR();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Entrance/Authorization");
                });
            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

           
            app.UseSignalR(route =>
            {
                route.MapHub<MessageHub>("/Message");
            });
            app.UseDeveloperExceptionPage(); 
            app.UseStatusCodePages(); 
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            app.UseAuthentication();    
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Entrance}/{action=Authorization}");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseReact(config => { });
            app.UseDefaultFiles();
        }
    }
}
