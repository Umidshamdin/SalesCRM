using SalesCRM.Domain.Common;

namespace SalesCRM.Domain.Entities;

public class DealProduct : BaseEntity
{
    public Guid DealId { get; set; }

    public Deal Deal { get; set; } = null!;

    public Guid ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal DiscountPercent { get; set; }

    public decimal TotalPrice =>
        Quantity * UnitPrice * (1 - DiscountPercent / 100);
}