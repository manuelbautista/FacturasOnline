using FacturasOnline.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FacturasOnline.Persistence
{
    public class FODbContext: DbContext
    {
        public DbSet<Users> Users {get;set;}
        public DbSet<Photo> Photo {get;set;}
        public DbSet<InvoiceInfo> InvoiceInfo {get;set;}
        public DbSet <UsersAccountants> UsersAccountants {get;set;}
        public FODbContext(DbContextOptions<FODbContext> options) : base(options) {

        }
    }
}