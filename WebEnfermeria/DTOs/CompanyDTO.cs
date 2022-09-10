using System.ComponentModel.DataAnnotations;

namespace WebEnfermeria.DTOs.Company
{
    public class CompanyDTO
    {
        [Required]
        [Display(Name = "Nombre_Empresa")]
        public string CompanyName { get; set; } 
        public string Comment { get; set; } = null!;


    }
}
