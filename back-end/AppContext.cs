using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<javascript_tute> javascript_tute { get; set; }
        public DbSet<cs_tute> cs_tute { get; set; }
        public DbSet<python_tute> python_tute { get; set; }
        public DbSet<cpp_tute> cpp_tute { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cs_tute>(entity =>
            {
                entity.HasKey(e => e.topic_id);
            });
            modelBuilder.Entity<javascript_tute>(entity =>
            {
                entity.HasKey(e => e.topic_id);
            });
            modelBuilder.Entity<cpp_tute>(entity =>
            {
                entity.HasKey(e => e.topic_id);
            });
            modelBuilder.Entity<python_tute>(entity =>
            {
                entity.HasKey(e => e.topic_id);
            });
        }
    }
}
