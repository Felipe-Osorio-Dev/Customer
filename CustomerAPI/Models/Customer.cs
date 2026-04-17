using CustomerAPI.Util;

namespace CustomerAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public CustomerType Type { get; set; }
        public string Document { get; set; }
        public bool IsActive { get; set; }
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly? UpdateAt { get; set; }

        public Address? Address { get; set; }
    }
}
