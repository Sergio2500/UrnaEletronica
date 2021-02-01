using DDD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Mapping
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Candidatos> CandidatosContext { get; set; }
        public virtual DbSet<Votos> VotosContext { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidatos>().HasKey(x => x.Id);
            modelBuilder.Entity<Candidatos>().HasMany(x => x.VotosId).WithOne(x => x.CandidatoId);

            modelBuilder.Entity<Votos>().HasKey(x => x.IdVotos);
            modelBuilder.Entity<Votos>().HasOne(x => x.CandidatoId);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
