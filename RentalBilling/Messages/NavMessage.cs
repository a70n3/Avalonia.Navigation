using CommunityToolkit.Mvvm.Messaging.Messages;

namespace RentalBilling.ViewModels;
public class NavMessage:ValueChangedMessage<string>
{
    public NavMessage(string value):base(value)
    {
    }
}