using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moisi_Vanesa_Lab2.Models;

namespace Moisi_Vanesa_Lab2.Data
{
    public class Moisi_Vanesa_Lab2Context : DbContext
    {
        public Moisi_Vanesa_Lab2Context (DbContextOptions<Moisi_Vanesa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moisi_Vanesa_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Moisi_Vanesa_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Moisi_Vanesa_Lab2.Models.Publisher> Publishers { get; set; } = default!;
        public DbSet<Moisi_Vanesa_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
