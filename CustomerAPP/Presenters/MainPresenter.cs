using CustomerAPP.Service.Navigation;
using CustomerAPP.Views.Main;
using CustomerAPP.Views.Register;

namespace CustomerAPP.Presenters
{
    internal class MainPresenter
    {
        private readonly INavigationService _navigationService;
        private readonly IMainView _mainView;

        public MainPresenter(IMainView mainView, INavigationService navigationService)
        {
            _navigationService = navigationService;
            _mainView = mainView;

            _navigationService.SetMdiParent((Form) _mainView);
            _mainView.ClickCustomerRegister += OnClickCustomerRegister;
        }

        private void OnClickCustomerRegister(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<RegisterCustomer, RegisterCustomerPresenter>();
        }
    }
}
