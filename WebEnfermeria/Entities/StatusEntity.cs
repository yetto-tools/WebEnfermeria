using System.ComponentModel.DataAnnotations;

namespace WebEnfermeria.Entities.Status
{
    public class StatusEmployeeEntity
    {
        public Guid Id { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Field Maximum Length is {0}")]
        public string Status { get; set; }
    }
    public class StatusEntity
    {
        public Guid Id { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Field Maximum Length is {0}")]
        public string Status { get; set; }
    }
}
