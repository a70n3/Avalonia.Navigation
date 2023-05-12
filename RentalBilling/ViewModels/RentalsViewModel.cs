using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using RentalBilling.Models;
using System;
using System.Collections.ObjectModel;

namespace RentalBilling.ViewModels;
public partial class RentalsViewModel:ViewModelBase
{
    public RentalsViewModel()
    {
        TenantRentals = new ObservableCollection<Tenant>();
        TenantRentals.Add(new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 1",Status = true});
        TenantRentals.Add(new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 2", Status = true });
        TenantRentals.Add(new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 3", Status = true });
        TenantRentals.Add(new Tenant() { Id = Guid.NewGuid(), Name = "Foobar 4", Status = true });
    }
    [ObservableProperty]
    private string _pageTitle = "Rentals";
    [ObservableProperty]
    private ObservableCollection<Tenant>? _tenantRentals;
    [ObservableProperty]
    private Tenant _tenantRent;
    [RelayCommand]
    public void Return()
    {
        WeakReferenceMessenger.Default.Send(new NavMessage("Dashboard"));
    }
}
