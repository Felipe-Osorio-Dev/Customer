using Microsoft.Extensions.DependencyInjection;

namespace CustomerAPP.Service.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;
        private static Form? _mdiParent;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class
        {
            var scoped = _serviceProvider.CreateScope();

            var existingForm = _mdiParent?.MdiChildren.FirstOrDefault(f => f is TForm);

            if (existingForm != null)
            {
                existingForm.Activate();
                scoped.Dispose();
                return;
            }

            var form = scoped.ServiceProvider.GetRequiredService<TForm>();
            scoped.ServiceProvider.GetRequiredService<TPresenter>();

            form.FormClosed += (s, e) => scoped.Dispose();
            form.MdiParent = _mdiParent;
            form.Show();
        }

        public void SetMdiParent(Form mdiParent)
        {
            _mdiParent = mdiParent;
        }
    }
}
