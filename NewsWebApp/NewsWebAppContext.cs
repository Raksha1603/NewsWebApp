using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NewsWebApp.Models
{
    public class NewsWebAppContext : DbContext
    {

        public NewsWebAppContext(DbContextOptions<NewsWebAppContext> options)
            : base(options)
        {
        }
        public DbSet<News_Category> news_Categories { get; set; }
    }
}
