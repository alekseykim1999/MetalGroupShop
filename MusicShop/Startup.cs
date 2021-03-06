﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
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


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940


        public void ConfigureServices(IServiceCollection services) //регистрация плагинов внутри проекта
        {
            services.AddDbContext<AppDBContent>(options=>options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddDbContext<ApplicationContext>();
            services.AddTransient<IAllAlbums, MockAlbum>(); //связь между классом и интерфейсом
            services.AddTransient<IAllGroups, MockGroups>();
            services.AddMvcCore(); //добавить поддержку MVC
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); //страницы с ошибками
            app.UseStatusCodePages(); //страница с кодом статуса - 200, если все хорошо
            app.UseStaticFiles(); // отображать статические файлы CSS
            app.UseSession();
            app.UseMvcWithDefaultRoute(); // если  в url не указан контроллер и представление, то вывести файл по умолчанию
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Entrance}/{action=Authorization}");
            });

            app.UseDeveloperExceptionPage();

            app.UseReact(config => { });
            app.UseDefaultFiles();
        }
    }
}
