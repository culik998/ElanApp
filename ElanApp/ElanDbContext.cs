using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElanApp
{
    public class ElanDbContext:DbContext
    {
        public ElanDbContext() : base("db") { }

        public DbSet<User> Users { get; set; }

        public DbSet<House>  Houses { get; set; }

    }
}
