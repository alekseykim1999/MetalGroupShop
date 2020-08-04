using Microsoft.EntityFrameworkCore;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
            {


        }

        public DbSet<Album> Album { get; set; }

        public DbSet<MetalGroup> MetalGroup { get; set; }
    }
}
