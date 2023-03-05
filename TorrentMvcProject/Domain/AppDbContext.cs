using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;


namespace TorrentMvcProject.Domain{
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> settings) : base(settings) {

        }
        
        public DbSet<Catagory> Categories { get; set; }
        public DbSet<GameItem> GameItems { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
