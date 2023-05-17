using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using AvaloniaNavigation.Models;
using System;
using System.Collections.ObjectModel;

namespace AvaloniaNavigation.ViewModels;
public partial class RentalsViewModel:ViewModelBase
{
    public RentalsViewModel()
    {
        TenantRentals = new ObservableCollection<Tenant>
        {
            new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 1", Status = true },
            new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 2", Status = true },
            new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 3", Status = true },
            new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 4", Status = true }
        };
    }
    [ObservableProperty]
    private string _pageTitle = "Rentals";
    [ObservableProperty]
    private ObservableCollection<Tenant>? _tenantRentals;
    
    [RelayCommand]
    public void Return()
    {
        WeakReferenceMessenger.Default.Send(new NavMessage(Nav.DASHBOARD));
    }
}
