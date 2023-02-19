using Microsoft.EntityFrameworkCore;
using Syschool.Domain.Interfaces.Factory;

namespace Syschool.Infra.Data.Context.Factory
{
    public class DbContextFactory : IDbContextFactory
    {
        public DbContextOptions DbContextOptions { get; }
        public SyschoolContext SyschoolContext { get; private set; }

        public DbContextFactory(DbContextOptions dbContextOptions) =>
            DbContextOptions = dbContextOptions;

        public SyschoolContext Init() => SyschoolContext ?? (SyschoolContext = new SyschoolContext(DbContextOptions));

        public void Dispose()
        {
            if (SyschoolContext != null)
            {
                SyschoolContext.Dispose();
            }
        }
    }
}
