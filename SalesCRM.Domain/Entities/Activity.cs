using SalesCRM.Domain.Common;
using SalesCRM.Domain.Enums;

namespace SalesCRM.Domain.Entities;

public class Activity : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public ActivityType Type { get; set; }

    public string? Description { get; set; }

    public DateTime? ScheduledAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public bool IsCompleted { get; set; }

    public Guid? CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public Guid? AssignedToUserId { get; set; }

    public AppUser? AssignedToUser { get; set; }
}