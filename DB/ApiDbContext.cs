using danj_backend.Model;
using Microsoft.EntityFrameworkCore;

namespace danj_backend.DB {
    public class ApiDbContext : DbContext{
        public ApiDbContext(DbContextOptions <ApiDbContext> options) : base(options){}
        public DbSet<Users> Users { get; set;}
    }
}