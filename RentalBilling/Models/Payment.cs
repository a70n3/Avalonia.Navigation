namespace RentalBilling.ViewModels;
public class Payment
{
    public int Id { get; set; }
    public int RentId { get; set; }
    public decimal Amount { get; set; }
}