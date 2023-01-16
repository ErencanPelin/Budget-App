using BudgetApp.Core;
using BudgetApp.Service;
using System;

namespace BudgetApp.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {
        private INavigationService _navigationService;
        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateHomeCommand { get; set; }
        public RelayCommand NavigateBudgetCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;

            NavigateHomeCommand = new RelayCommand(canExecute:o => true, o => { Console.WriteLine("Home"); NavigationService.NavigateTo<HomeViewModel>(); });
            NavigateBudgetCommand = new RelayCommand(canExecute:o => true, o => { NavigationService.NavigateTo<BudgetViewModel>(); });

            NavigateHomeCommand.Execute(this);
        }
    }
}
