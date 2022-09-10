using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEnfermeria.DTOs.Person
{
    public class PersonDTO
    {
        [Required]
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; }
        public string CUI { get; set; } = null!;

        [Display(Name = "Direccion")]
        public string Address { get; set; } = string.Empty;
        [Display(Name = "Telefono1")]
        public string Phone1 { get; set; } = string.Empty;
        [Display(Name = "Telefono2")]
        public string Phone2 { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Birday { get; set; }

    }
}
