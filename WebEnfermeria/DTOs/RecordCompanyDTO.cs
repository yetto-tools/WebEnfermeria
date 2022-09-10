using WebEnfermeria.DTOs.Company;
using WebEnfermeria.DTOs.Employee;

namespace WebEnfermeria.DTOs
{
    public class RecordCompanyDTO
    {
        public UInt32 Id { get; set; }
        public EmployeeDTO Employee { get; set; }
        public CompanyDTO RecordCompaniesId { get; set; } 
    }
}
