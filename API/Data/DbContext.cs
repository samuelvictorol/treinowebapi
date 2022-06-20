using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        public Context(DbContextOptions<Context> options) : base(options){}
    }
}