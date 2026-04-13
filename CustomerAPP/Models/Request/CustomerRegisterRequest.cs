namespace CustomerAPP.Models.Request
{
    public class CustomerRegisterRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public int CustomerType { get; set; } = 1;

        public CustomerAddressRequest Address { get; set; } = new();
    }
}
