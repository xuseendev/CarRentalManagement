using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class BaseDomainModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
