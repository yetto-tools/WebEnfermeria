using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.DTOs.Person;

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
        public DateOnly Birday { get; set; }
        
        [Display(Name = "Activo")]
        public bool IsActive { get; set; } = true;
        public int Code { get; set; } = 0;
        public string CardNumber { get; set; } = string.Empty;
        public DateOnly Income { get; set; }
        public DateOnly Egress { get; set; }
        
        public List<RecordCompanyDTO> RecordCompanyId { get; set; } = new List<RecordCompanyDTO>();


        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;


    }

}
