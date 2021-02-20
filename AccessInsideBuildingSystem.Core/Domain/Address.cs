namespace AccessInsideBuildingSystem.Core.Domain
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }
    }
}
