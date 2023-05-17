using CommunityToolkit.Mvvm.Messaging.Messages;

namespace RentalBilling.ViewModels;
public class NavMessage:ValueChangedMessage<Nav>
{
    public NavMessage(Nav value):base(value)
    {
    }
}
public enum Nav
{
    DASHBOARD,
    RENTALS,
    PAYMENTS,
    REPORTS
}