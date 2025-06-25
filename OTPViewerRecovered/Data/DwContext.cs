using Microsoft.EntityFrameworkCore;
using OTPViewerRecovered.Models;

namespace OTPViewerRecovered.Data
{
    public class DwContext : DbContext
    {
        public DwContext(DbContextOptions<DwContext> options) : base(options) { }

        public DbSet<CodigosOtpV> CodigosOtpV { get; set; }
    }
}
