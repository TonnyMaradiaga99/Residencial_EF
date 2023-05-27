using Microsoft.EntityFrameworkCore;
using residencial.Models;

namespace residencial
{

    public class context:DbContext
    {

        public DbSet<casa> casa {get; set; }

        public DbSet<habitante> habitante {get; set;}

        public DbSet<residente> residente {get; set; }

        public DbSet<visita> visita {get; set; }

        public DbSet<visitante> visitante {get; set;}

        public context(DbContextOptions<context> options) : base(options){}
    }
}