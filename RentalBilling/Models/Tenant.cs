using System;

namespace RentalBilling.Models;
public class Tenant
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Status { get; set; }
}