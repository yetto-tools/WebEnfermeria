using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnfermeria.Entities.Company;

namespace WebEnfermeria.Entities.CompaniesRecord
{
    public class CompanyRecordEntity
    {
        public UInt32 Id { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime Income { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Egreso")]
        public DateTime? Egress { get; set; }

        public CompanyEntity CompanyId { get; set; }

    }
}