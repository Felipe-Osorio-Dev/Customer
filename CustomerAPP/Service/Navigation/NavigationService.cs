namespace CustomerAPP.Service.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;
        private Form? _mdiParent;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class, new()
        {
            throw new NotImplementedException();
        }

        public void SetMdiParent(Form mdiParent)
        {
            _mdiParent = mdiParent;
        }
    }
}
