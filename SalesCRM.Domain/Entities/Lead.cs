using SalesCRM.Domain.Common;
using SalesCRM.Domain.Enums;

namespace SalesCRM.Domain.Entities;

public class Lead : BaseEntity
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? CompanyName { get; set; }

    public string? Source { get; set; }

    public LeadStatus Status { get; set; } = LeadStatus.New;

    public string? Notes { get; set; }

    public Guid? AssignedToUserId { get; set; }

    public AppUser? AssignedToUser { get; set; }

    public Guid? ConvertedCustomerId { get; set; }

    public Customer? ConvertedCustomer { get; set; }
}