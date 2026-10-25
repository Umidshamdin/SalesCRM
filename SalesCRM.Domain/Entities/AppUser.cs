using SalesCRM.Domain.Common;
using SalesCRM.Domain.Enums;

namespace SalesCRM.Domain.Entities;

public class AppUser : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.SalesRepresentative;

    public bool IsActive { get; set; } = true;

    public ICollection<Customer> Customers { get; set; }
        = new List<Customer>();

    public ICollection<Lead> Leads { get; set; }
        = new List<Lead>();

    public ICollection<Deal> Deals { get; set; }
        = new List<Deal>();

    public ICollection<Activity> Activities { get; set; }
        = new List<Activity>();
}