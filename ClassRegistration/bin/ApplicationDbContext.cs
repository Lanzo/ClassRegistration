using System.Security.Claims;

namespace ClassRegistration.Api
{
    public class ApplicationDbContext : DbContext
{
    public DbSet<Claim> Classes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<ClassRegistration> ClassRegistrations { get; set; }
    public DbSet<MarketingAnnouncement> MarketingAnnouncements { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}

    public class DbContext
    {
    }
}