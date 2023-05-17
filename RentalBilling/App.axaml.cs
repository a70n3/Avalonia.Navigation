using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RentalBilling.ViewModels;

namespace RentalBilling;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
            desktop.MainWindow.DataContext = new MainViewModel() {
                ViewModels = new ViewModelBase[]
                {
                    new DashboardViewModel(),
                    new PaymentsViewModel(),
                    new RentalsViewModel(),
                    new ReportsViewModel()
                }
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}