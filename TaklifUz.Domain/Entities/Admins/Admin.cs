﻿using TaklifUz.Domain.Entities.Threads;

namespace TaklifUz.Domain.Entities.Admins;

public class Admin : Auditable
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public bool PhoneNumberConfirmed { get; set; }
    public string ImagePath { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public double Wallet { get; set; }
    public string PasswordHash { get; set; } = String.Empty;
    public string Salt { get; set; } = String.Empty;
    public string Role { get; set; } = "Admin";

    public IList<ProductLink> ProductLinks { get; set; } = new List<ProductLink>();
}
