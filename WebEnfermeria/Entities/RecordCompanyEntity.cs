using WebEnfermeria.Entities.Company;

namespace WebEnfermeria.Entities.Employee
{
    internal class RecordCompanyEntity
    {
        public UInt32 Id { get; set; }
        public EmployeeEntity Employee { get; set; }
        public CompanyEntity RecordCompanyId { get; set; }

    }
}