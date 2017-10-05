using Microsoft.EntityFrameworkCore;

namespace FacturasOnline.Persistence
{
    public class FODbContext: DbContext
    {
        public FODbContext(DbContextOptions<FODbContext> options) : base(options) {
            
        }
    }
}