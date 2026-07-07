using MedicineManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicineManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}