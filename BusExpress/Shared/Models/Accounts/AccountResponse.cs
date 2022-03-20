namespace BusExpress.Shared.Models.Accounts;

// The account response model defines the account data returned by the
// GetAll, GetById, Create and Update methods of the accounts controller and account service.
// It includes basic account details and excludes sensitive data such as hashed passwords and tokens.
public class AccountResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool IsVerified { get; set; }
}