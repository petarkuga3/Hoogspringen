using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Globals;


namespace DataLayer
{
    public class SprongContext : DbContext
    {
        public virtual DbSet<Springer> Springers { get; set; }

        public virtual DbSet<Sprong> Sprongen { get; set; }


        public SprongContext() : base ("SprongDb")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Springer>().HasKey<int>(s => s.Id);
            modelBuilder.Entity<Sprong>().HasKey<int>(s => s.Id);

            modelBuilder.Entity<Sprong>()
                        .HasRequired(s => s.Springer)
                        .WithMany(d => d.Sprongen)
                        .HasForeignKey(o => o.Id);
        }
    }
}
