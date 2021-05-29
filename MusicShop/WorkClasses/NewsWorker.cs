using Parser.Core.Platonus;
using Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicShop.WorkClasses
{
    class NewsWorker
    {

        static List<string> allNews = new List<string>();
        public List<NewsModel> getAllNews()
        {  
            ParserWorker<string[]> parser = new ParserWorker<string[]>(
                new NewsParser());
            parser.ParserSettings = new ParserSettings();
            parser.onCompleted += parser_on_completed; 
            parser.onNewData += parser_on_new_data;
            parser.Start();
            Thread.Sleep(3000);
          
            List<string> images = new List<string>();
            List<string> texts = new List<string>();

            foreach (string ss in allNews)
            {
                if (ss.Contains(".jpeg") || ss.Contains(".png") || ss.Contains(".mp4"))
                    images.Add("https://tengrinews.kz"+ss);
                else
                    texts.Add(ss);
            }


            List<NewsModel> resultList = new List<NewsModel>();
            for (int index = 0; index < texts.Count; index++)
            {
                resultList.Add(new NewsModel { img = images[index], news = texts[index] });
            }

            parser.onCompleted -= parser_on_completed;
            parser.onNewData -= parser_on_new_data;
            return resultList;

        }

        private static void parser_on_completed(object obj)
        {
           
        }

        private static void parser_on_new_data(object arg1, string[] arg2)
        {
            for (int i = 0; i < arg2.Length; i++)
            {
                allNews.Add(arg2[i]);
            }

        }
    }
}
