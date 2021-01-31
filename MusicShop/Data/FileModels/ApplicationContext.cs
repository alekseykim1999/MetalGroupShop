using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicShop.Data.FileModels
{
    public class ApplicationContext: DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        
        }
    }
}
