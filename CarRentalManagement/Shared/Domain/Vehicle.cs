namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public string Vin { get; set; }
        public string LicencePlateNumber { get; set; }
        public Colour Colour { get; set; }
        public int ColourId { get; set; }
        public double RentalRate { get; set; }

    }
}
