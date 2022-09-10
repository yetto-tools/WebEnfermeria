using Microsoft.EntityFrameworkCore;
using WebEnfermeria.Entities.CompaniesRecord;
using WebEnfermeria.Entities.Company;
using WebEnfermeria.Entities.Employee;
using WebEnfermeria.Entities.MedicalRecord;
using WebEnfermeria.Entities.Person;
using WebEnfermeria.Entities.Status;

namespace WebEnfermeria.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }
        public DbSet<StatusEntity> Status { get; set; }
        public DbSet<StatusEmployeeEntity> StatusEmployees { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<CompanyRecordEntity> CompanyRecordEntities { get; set; }
        public DbSet<MedicalRecordEntity> MedicalRecord { get; set; }
        
        
        
        
    }
}
