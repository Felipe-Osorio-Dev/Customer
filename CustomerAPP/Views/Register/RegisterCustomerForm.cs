using CustomerAPP.Models.Request;
using CustomerAPP.Util;

namespace CustomerAPP.Views.Register
{
    public partial class RegisterCustomerForm : Form, IRegisterCustomerView
    {
        public RegisterCustomerForm()
        {
            InitializeComponent();
            cbbDocument.DataSource = Enum.GetValues<CustomerType>();
        }

        public event EventHandler<CustomerEventArgs> ClickRegisterCustomer;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var newCustomer = new CustomerRegisterRequest
            {
                Name = txtCustomerName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Document = txtDocNumber.Text.Trim(),
                CustomerType = 1,
                Address =
                {
                    ZipCode = txtZipCode.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Neighborhood = txtNeighborhood.Text.Trim(),
                    State = txtState.Text.Trim(),
                    Street = txtStreet.Text.Trim(),
                    Number = txtHouseNumber.Text.Trim(),
                }
            };

            ClickRegisterCustomer?.Invoke(this, new CustomerEventArgs(newCustomer));
        }
    }
}
