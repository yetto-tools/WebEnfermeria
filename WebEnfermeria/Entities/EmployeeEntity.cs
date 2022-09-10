using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.Entities.CompaniesRecord;
using WebEnfermeria.Entities.Person;
using WebEnfermeria.Entities.Status;

namespace WebEnfermeria.Entities.Employee
{
    public class EmployeeEntity
    {
        public UInt32 Id { get; set; }

        public StatusEmployeeEntity Status { get; set; }
        public int Code { get; set; } = 0;

        [Required]
        public PersonEntity PersonId { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public List<CompanyRecordEntity> CompaniesRecordId { get; set; } = new List<CompanyRecordEntity>();
    }

    
}
