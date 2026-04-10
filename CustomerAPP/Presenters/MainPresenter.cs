using CustomerAPP.Service.Navigation;
using CustomerAPP.Views.Main;

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

            _mainView.ClickCustomerRegister += OnClickCustomerRegister;
        }

        private void OnClickCustomerRegister(object sender, EventArgs e)
        {
            MessageBox.Show("TESTANDO");
        }
    }
}
