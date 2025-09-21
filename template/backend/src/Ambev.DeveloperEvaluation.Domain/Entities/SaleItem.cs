namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleItem
{
    public int Id { get; set; }
    public string Product { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal DiscountPercent { get; set; }
    public bool IsCancelled { get; set; } = false;

    public decimal LineTotal => !IsCancelled
        ? Quantity * UnitPrice * (1 - DiscountPercent / 100)
        : 0;
}
