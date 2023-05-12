using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBilling.ViewModels
{
    public partial class MainViewModel:ViewModelBase,IRecipient<NavMessage>
    {
        public MainViewModel()
        {
            WeakReferenceMessenger.Default.Register(this);
        }
        [ObservableProperty]
        private string _pageTitle = string.Empty;
        [ObservableProperty]
        private ViewModelBase? _currentViewModel;
        [RelayCommand]
        public void DashBoard()
        {
            CurrentViewModel = new DashboardViewModel();
        }
        [RelayCommand]
        public void Rentals()
        {
            CurrentViewModel = new RentalsViewModel();
        }

        public void Receive(NavMessage message)
        {
            CurrentViewModel = new DashboardViewModel();
        }
    }
}
