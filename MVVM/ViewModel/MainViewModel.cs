using BudgetApp.Core;
using BudgetApp.Data;
using BudgetApp.Service;
using System;
using System.Windows;

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
        public RelayCommand CloseAppCommand { get; set; }
        public RelayCommand MaximiseAppCommand { get; set; }
        public RelayCommand MinimiseAppCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;

            NavigateHomeCommand = new RelayCommand(o => { Console.WriteLine("Home"); NavigationService.NavigateTo<HomeViewModel>(); }, canExecute: o => true);
            NavigateBudgetCommand = new RelayCommand(o => { NavigationService.NavigateTo<BudgetViewModel>(); }, canExecute: o => true);
            CloseAppCommand = new RelayCommand((o) => { Application.Current.Shutdown(); }, o => true);

            NavigateHomeCommand.Execute(this);
        
            DataStore.InitTestData();
        }
    }
}
