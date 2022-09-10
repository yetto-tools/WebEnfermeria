using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.DTOs;



namespace WebEnfermeria.Entities.Employee
{
    public class EmployeeEntity
    {
        public UInt32 Id { get; set; }
        [Required]
        public PersonEntity PersonId { get; set; }
        public bool IsActive { get; set; } = true;
        public int Code { get; set; } = 0;
        public string CardNumber { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime Income { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Egreso")]
        public DateTime Egress { get; set; }
        public List<RecordCompanyDTO> RecordCompanyId { get; set; }
    }

    
}
