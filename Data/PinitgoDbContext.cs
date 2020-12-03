using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Data
{
    public class PinitgoDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Upload> Uploads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=tcp:pinitgoserver.database.windows.net,1433;Initial Catalog=pinitgodb;Persist Security Info=False;User ID=pinitgoadmin;Password=Goldclaw1!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
