using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chiperi_Geanina_Lab8.Models;

namespace Chiperi_Geanina_Lab8.Data
{
    public class Chiperi_Geanina_Lab8Context : DbContext
    {
        public Chiperi_Geanina_Lab8Context (DbContextOptions<Chiperi_Geanina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Chiperi_Geanina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Chiperi_Geanina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Chiperi_Geanina_Lab8.Models.Category> Category { get; set; }
    }
}
