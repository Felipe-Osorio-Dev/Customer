using CustomerAPP.Presenters;
using CustomerAPP.Service.Navigation;
using CustomerAPP.Views.Main;
using CustomerAPP.Views.Register;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerAPP
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainContainer = provider.GetRequiredService<MainForm>();
                provider.GetRequiredService<MainPresenter>();

                Application.Run(mainContainer);
            }

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Main Container
            services.AddSingleton<MainForm>();
            services.AddScoped<RegisterCustomerForm>();

            //Presenters
            services.AddTransient<MainPresenter>();
            services.AddScoped<RegisterCustomerPresenter>();

            //Navigation
            services.AddSingleton<INavigationService, NavigationService>();

            //Interfaces
            services.AddTransient<IMainView>(sp => sp.GetRequiredService<MainForm>());
        }
    }
}