using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Platonus
{
    class ParserSettings : IParserSettings //настройки парсируемого сайта
    {
        public string BaseUrl { get; set; } = "https://tengrinews.kz/music/"; //основной url
        public string Prefix { get; set; } = ""; //главная страница. 
    }
}
