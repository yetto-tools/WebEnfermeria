using Microsoft.EntityFrameworkCore;
using WebEnfermeria.Entities.Company;
using WebEnfermeria.Entities.Employee;
using WebEnfermeria.Entities.MedicalRecord;

namespace WebEnfermeria.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyEntity> Companies  { get; set; }
        public DbSet<MedicalRecordEntity> MedicalRecord { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        
    }
}
