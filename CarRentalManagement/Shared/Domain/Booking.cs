namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}