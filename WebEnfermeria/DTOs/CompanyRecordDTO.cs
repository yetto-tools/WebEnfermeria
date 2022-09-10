using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.DTOs.Company;
using WebEnfermeria.DTOs.Employee;

namespace WebEnfermeria.DTOs.CompaniesRecord
{
    public class CompaniesRecordDTO
    {
        public UInt32 Id { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Egreso")]

        public DateTime Income { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Egreso")]

        public DateTime? Egress { get; set; }

        //public EmployeeDTO Employee { get; set; }
        public CompanyDTO CompaniesId { get; set; } 
    }
}
