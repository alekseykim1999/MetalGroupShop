using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.FileModels
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
