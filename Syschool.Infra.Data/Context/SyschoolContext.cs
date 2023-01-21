using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Syschool.Domain.Entities;
using Syschool.Infra.Data.Configuration;

namespace Syschool.Infra.Data.Context
{
    public class SyschoolContext : IdentityDbContext
    {
        public SyschoolContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AlunoConfiguration());
        }
    }
}
