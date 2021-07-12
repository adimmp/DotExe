using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotExe
{
    public partial class SampleApiDbContext : IdentityDbContext
    {
        public SampleApiDbContext()
        {

        }

        public SampleApiDbContext(DbContextOptions<SampleApiDbContext> options)
            : base(options)
        {

        }
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}