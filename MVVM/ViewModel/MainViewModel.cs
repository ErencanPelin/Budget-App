using BudgetApp.Core;
using BudgetApp.Data;
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

            NavigateHomeCommand = new RelayCommand(o => { Console.WriteLine("Home"); NavigationService.NavigateTo<HomeViewModel>(); }, canExecute: o => true);
            NavigateBudgetCommand = new RelayCommand(o => { NavigationService.NavigateTo<BudgetViewModel>(); }, canExecute: o => true);

            NavigateHomeCommand.Execute(this);
        
            DataStore.InitTestData();
        }
    }
}
