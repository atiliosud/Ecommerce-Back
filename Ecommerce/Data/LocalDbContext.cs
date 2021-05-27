using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalContext> options) : base(options)
        {
            
        }
    }
}