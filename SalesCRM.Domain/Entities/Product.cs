using SalesCRM.Domain.Common;

namespace SalesCRM.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string SKU { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal UnitPrice { get; set; }

    public string Currency { get; set; } = "AZN";

    public int StockQuantity { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<DealProduct> DealProducts { get; set; }
        = new List<DealProduct>();
}