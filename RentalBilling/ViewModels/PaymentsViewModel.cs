using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace RentalBilling.ViewModels;

public partial class PaymentsViewModel:ViewModelBase
{
    public PaymentsViewModel()
    {
        Payments = new()
        {
            new Payment() { Id = 1, RentId = 1, Amount = 1000 },
            new Payment() { Id = 2, RentId = 2, Amount = 1000 },
            new Payment() { Id = 3, RentId = 3, Amount = 1000 },
            new Payment() { Id = 4, RentId = 4, Amount = 1000 },
            new Payment() { Id = 5, RentId = 5, Amount = 1000 }
        };
    }
    public string PageTitle { get; } = "Payments";
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(UpdateCommand))]
    private Payment? _selectedPayment;
    public ObservableCollection<Payment>? Payments{ get; set; }
    [RelayCommand(CanExecute =nameof(CanUpdate))]
    private void Update(Payment? payment)
    {
        Console.WriteLine($"Helloo {payment!.RentId}");
    }
    private bool CanUpdate(Payment? payment)
    {
        return payment is not null;
    }
}
