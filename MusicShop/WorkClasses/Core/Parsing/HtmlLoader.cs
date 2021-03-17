﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Parser.Core.Platonus
{
    class HtmlLoader 
    {
        readonly HttpClient client; 
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient(); 
            url = $"{settings.BaseUrl}/{settings.Prefix}"; 
        }

        public async Task<string> getSourceByPageId() 
        {
           
            var response = await client.GetAsync(url); 
            string source = null;

            if(response!=null && response.StatusCode == HttpStatusCode.OK) 
            {
                source = await response.Content.ReadAsStringAsync(); 
            }

            return source; 
        }

        public void Authorize()
        {


        }
    }
}
