using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEnfermeria.Entities
{
    public class PersonEntity
    {
        public UInt32 Id { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; } = "+50254281759";
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
