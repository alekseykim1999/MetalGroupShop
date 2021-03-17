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
            parser.onCompleted += parser_on_completed; //функция, которая вызывается при уведомлении события о конце
            parser.onNewData += parser_on_new_data; //при полуениии данных
            parser.Start();

            Thread.Sleep(3000); 
            List<string> images = new List<string>();
            List<string> texts = new List<string>();

            foreach (string ss in allNews)
            {
                if (ss.Contains(".jpeg"))
                {
                    images.Add(ss);
                }
                else
                {
                    if(!texts.Contains(ss))
                    {
                        texts.Add(ss);
                    }
                }
                    
            }
            texts.RemoveRange(12, 7);
            List<NewsModel> resultList = new List<NewsModel>();

                for (int index = 0; index < texts.Count; index++)
                {
                    try
                    {
                        resultList.Add(new NewsModel { img = images[index], news = texts[index] });
                    }
                    catch
                    {

                    }
                     
                }

            return resultList;

        }

        private static void parser_on_completed(object obj)
        {
            Console.WriteLine("Парсинг завершен");
        }

        private static void parser_on_new_data(object arg1, string[] arg2)
        {

            //выводить массив полученных строк на консоль
            for (int i = 0; i < arg2.Length; i++)
            {
                allNews.Add(arg2[i]);
            }

        }
    }
}
