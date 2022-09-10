using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEnfermeria.Entities.MedicalRecord
{
    public class MedicalRecordEntity
    {
        public UInt32 Id { get; set; }

        public string BloodGroup { get; set; } = null!;

    }
}
