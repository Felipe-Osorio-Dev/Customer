namespace CustomerAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

    }
}
