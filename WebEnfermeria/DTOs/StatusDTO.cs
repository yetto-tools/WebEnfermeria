using System.ComponentModel.DataAnnotations;

namespace WebEnfermeria.DTOs.Status
{
    public class StatusEmployeeDTO
    {
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Field Maximum Length is {0} and Minimum Length is {1}")]
        public string Status { get; set; }

    }
}
