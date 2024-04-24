namespace TaklifUz.Service.Dtos.Heads;

public class HeadUpdateDto
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public bool PhoneNumberConfirmed { get; set; }
    //public IFormFile? ImagePath { get; set; }
    public string Address { get; set; } = String.Empty;
    public double Wallet { get; set; }
    public string PasswordHash { get; set; } = String.Empty;
    public string Salt { get; set; } = String.Empty;
    public string Role { get; set; } = "Head";
}
