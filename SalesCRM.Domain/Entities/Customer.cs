using SalesCRM.Domain.Common;

namespace SalesCRM.Domain.Entities;

public class Customer : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Notes { get; set; }

    public Guid? AssignedToUserId { get; set; }

    public AppUser? AssignedToUser { get; set; }

    public ICollection<Deal> Deals { get; set; }
        = new List<Deal>();

    public ICollection<Activity> Activities { get; set; }
        = new List<Activity>();
}