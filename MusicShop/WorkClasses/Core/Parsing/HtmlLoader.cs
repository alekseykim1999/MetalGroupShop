using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Parser.Core.Platonus
{
    class HtmlLoader //объект, который загружает страницу
    {
        readonly HttpClient client; //клиент 
        readonly string url; //путь к страницу

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient(); //создать клиента
            url = $"{settings.BaseUrl}/{settings.Prefix}"; //полный путь к нужному html
        }

        public async Task<string> getSourceByPageId() //получить нужную страницу
        {
           
            var response = await client.GetAsync(url); //получить ответ клиенту
            string source = null;

            if(response!=null && response.StatusCode == HttpStatusCode.OK) //если статус ОК, то страница передалась
            {
                source = await response.Content.ReadAsStringAsync(); //получить весь код главной страницы платонуса
            }

            return source; //весь код страницы
        }

        public void Authorize()
        {


        }
    }
}
