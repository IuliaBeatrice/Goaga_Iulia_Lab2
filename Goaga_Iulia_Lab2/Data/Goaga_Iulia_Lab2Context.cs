using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Goaga_Iulia_Lab2.Models;

namespace Goaga_Iulia_Lab2.Data
{
    public class Goaga_Iulia_Lab2Context : DbContext
    {
        public Goaga_Iulia_Lab2Context (DbContextOptions<Goaga_Iulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Goaga_Iulia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Goaga_Iulia_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
