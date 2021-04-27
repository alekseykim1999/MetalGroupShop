using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Platonus
{
    class ParserSettings : IParserSettings 
    {
        public string BaseUrl { get; set; } = "https://tengrinews.kz/tag/music/"; 
        public string Prefix { get; set; } = ""; 
    }
}
