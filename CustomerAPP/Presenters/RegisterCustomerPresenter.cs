using CustomerAPP.Views.Register;

namespace CustomerAPP.Presenters
{
    internal class RegisterCustomerPresenter
    {
        private readonly IRegisterCustomerView _view;

        public RegisterCustomerPresenter(IRegisterCustomerView view)
        {
            _view = view;

            _view.ClickRegisterCustomer += TestarEvento;
        }

        private void TestarEvento(Object sender, CustomerEventArgs e)
        {
            MessageBox.Show(e._request.Name);
        }
    }
}
