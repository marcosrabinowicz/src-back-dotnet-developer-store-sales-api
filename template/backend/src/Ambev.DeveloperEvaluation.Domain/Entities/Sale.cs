namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = "Active";
    public string Customer { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;

    public List<SaleItem> Items { get; set; } = new();

    public decimal Total => Items.Sum(i => i.LineTotal);
}
