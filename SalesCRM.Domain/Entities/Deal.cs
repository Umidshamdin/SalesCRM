using SalesCRM.Domain.Common;
using SalesCRM.Domain.Enums;
using SalesCRM.Domain.Exceptions;

namespace SalesCRM.Domain.Entities;

public class Deal : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "AZN";

    public DealStage Stage { get; private set; }
        = DealStage.Prospecting;

    public Guid CustomerId { get; set; }

    public Customer Customer { get; set; } = null!;

    public Guid? AssignedToUserId { get; set; }

    public AppUser? AssignedToUser { get; set; }

    public DateTime? ExpectedCloseDate { get; set; }

    public DateTime? ActualCloseDate { get; private set; }

    public string? Description { get; set; }

    public ICollection<DealProduct> DealProducts { get; set; }
        = new List<DealProduct>();

    public void ChangeStage(DealStage newStage)
    {
        if (!Enum.IsDefined(newStage))
            throw new DomainException("Yanlış satış mərhələsi.");

        if (Stage == DealStage.Won || Stage == DealStage.Lost)
            throw new DomainException(
                "Bağlanmış satışın mərhələsi dəyişdirilə bilməz.");

        Stage = newStage;

        if (newStage == DealStage.Won || newStage == DealStage.Lost)
            ActualCloseDate = DateTime.UtcNow;

        UpdatedAt = DateTime.UtcNow;
    }
}