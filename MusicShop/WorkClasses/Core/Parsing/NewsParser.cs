using AngleSharp;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Parser.Core.Platonus
{
    class NewsParser : IParser<string[]> //сам парсер 
    {
        public string[] Parse(IHtmlDocument document) //функция, которая выводит нужную информацию
        {

            var list = new List<string>(); //список всех найденных надписей
            foreach (var img in document.QuerySelectorAll("img"))
            {
                string src = img.GetAttribute("src");
                if(!src.Contains(".png") && src!="https://tengrinews.kz/https://mc.yandex.ru/watch/1838272")
                 list.Add("https://tengrinews.kz/"+src); //добавить содержание тегов 
            }
            list.RemoveAt(list.Count - 1);

            foreach (var span in document.QuerySelectorAll("span").Where(i => i.ClassName != null && i.ClassName.Contains("tn-article-title")))
            {
                list.Add(span.TextContent);
            }
            list.RemoveAt(list.Count - 1);

            return list.ToArray();
        }


       

       


    }
}
