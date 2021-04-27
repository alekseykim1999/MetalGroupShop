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
    class NewsParser : IParser<string[]> 
    {
        public string[] Parse(IHtmlDocument document) 
        {

            var list = new List<string>();
            foreach (HtmlElement parentDiv in document.QuerySelectorAll("div").Where(i => i.ClassName == "tn-image-container" || i.ClassName == "tn-video-container"))
            {
                HtmlElement tag = (HtmlElement)parentDiv.FirstElementChild;
                if (!tag.HasChildNodes)
                {
                    list.Add(tag.GetAttribute("src") + tag.InnerHtml);
                }
                else
                {
                    HtmlElement video = (HtmlElement)parentDiv.FirstElementChild;
                    HtmlElement source = (HtmlElement)video.FirstElementChild;
                    list.Add(source.GetAttribute("src"));
                }
            }


            foreach (var span in document.QuerySelectorAll("a").Where(i => i.ClassName != null && i.ClassName.Contains("tn-link")))
            {
                list.Add(span.TextContent);
            }
            return list.ToArray();
        }


       

       


    }
}
