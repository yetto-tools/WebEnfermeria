namespace WebEnfermeria.Entities.Company
{
    public class CompanyEntity
    {
        public UInt32 Id { get; set; }
        public bool IsActive { get; set; } = true;        
        public string CompanyName { get; set; } = null!;
        public string Comment { get; set; } = null!;

        public DateTime CreateDate { get; set; }  = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;

    }
}
