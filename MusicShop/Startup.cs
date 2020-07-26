using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MusicShop.Data.Mocks;
using MusicShop.Interfaces;

namespace MusicShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //регистрация плагинов внутри проекта
        {
            services.AddTransient<IAllAlbums, MockAlbum>(); //связь между классом и интерфейсом
            services.AddTransient<IAllGroups, MockGroups>();
            services.AddMvc(); //добавить поддержку MVC
            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); //страницы с ошибками
            app.UseStatusCodePages(); //страница с кодом статуса - 200, если все хорошо
            app.UseStaticFiles(); // отображать статические файлы CSS
            app.UseMvcWithDefaultRoute(); // если  в url не указан контроллер и представление, то вывести файл по умлочанию
        }
    }
}
