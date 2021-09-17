using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }
        public DbSet<Educator> Kasvataja { get; set; }
        public DbSet<Absence> Puudumine { get; set; }
        public DbSet<Children> lapsed { get; set; }
        public DbSet<Cook> Kokk { get; set; }
        public DbSet<EatingHistory> Söömisajalugu { get; set; }
        public DbSet<Group> Grupp { get; set; }
        public DbSet<GroupHistory> Grupiajalugu { get; set; }
        public DbSet<Kindergarten> Lasteaed { get; set; }
        public DbSet<Kitchen> Köök { get; set; }
        public DbSet<Menu> Menüü { get; set; }
        public DbSet<Position> Positsioon { get; set; }
        public DbSet<Queue> Järjekord { get; set; }
        public DbSet<WorkingHistory> Tööajalugu { get; set; }


        
        
    }
}