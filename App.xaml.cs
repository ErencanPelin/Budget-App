using BudgetApp.Core;
using BudgetApp.MVVM.ViewModel;
using BudgetApp.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindow>((serviceProvider) => new MainWindow()
            {
                DataContext = serviceProvider.GetRequiredService<MainViewModel>()
            });
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<BudgetViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();
            
            services.AddSingleton<Func<Type, ViewModel>>(serviceProvider => viewModelType => (ViewModel)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = _serviceProvider.GetRequiredService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }
    }
}
