using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.DTOs.CompaniesRecord;
using WebEnfermeria.DTOs.Person;
using WebEnfermeria.DTOs.Status;

namespace WebEnfermeria.DTOs.Employee
{
    public class EmployeeDTO
    {

        public UInt32 Id { get; set; }
        [Required]
        public PersonDTO PersonId{ get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Birday { get; set; }

        [Display(Name = "Estado")]
        [StringLength(maximumLength: 15, ErrorMessage = "Field Maximum Length")]
        public StatusEmployeeDTO StatusId { get; set; }
        public int Code { get; set; } = 0;
        public string CardNumber { get; set; } = string.Empty;        
        public List<CompaniesRecordDTO> CompaniesRecordId { get; set; } = new List<CompaniesRecordDTO>();


        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;


    }

}
