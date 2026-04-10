namespace CustomerAPP.Service.Navigation
{
    internal interface INavigationService
    {
        void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class;

        void SetMdiParent(Form mdiParent);
    }
}
