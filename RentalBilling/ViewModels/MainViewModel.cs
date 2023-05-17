using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace RentalBilling.ViewModels;

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
    [ObservableProperty]
    private ViewModelBase[]? _viewModels;
    [ObservableProperty]
    private Nav _selectedPageIndex;
    public void Receive(NavMessage message)
    {
        SelectedPageIndex = message.Value;
    }
}
