namespace Midnight.SOAP.SDK.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; } = 0;
        public string? OrderNumber { get; set; } = string.Empty;
        public int CustomerID { get; set; } = 0;
        public string? CustomerName { get; set; } = string.Empty;
        public string? ProjectName { get; set; } = string.Empty;
        public int QuantityExpected { get; set; } = 0;
        public decimal OrderTax { get; set; } = 0;
        public decimal OrderTotal { get; set; } = 0;
        public decimal PostageTotal { get; set; } = 0;
        public string? OrderDate { get; set; } = string.Empty;
        public string? DueDate { get; set; } = string.Empty;
        public string? CloseDate { get; set; } = string.Empty;
        public string? SalesRep { get; set; } = string.Empty;

        public List<Versions>? Versions { get; set; }
    }

    public class Versions
    {
        public int VersionID { get; set; } = 0;
        public string? VersionName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal SubTotal { get; set; } = decimal.Zero;
        public decimal TaxAmount { get; set; } = decimal.Zero;
        public decimal Postage { get; set; } = decimal.Zero;
        public int PostageAffixID { get; set; } = 0;
        public string? PostageAffixName { get; set; } = string.Empty;
        public int MailClassID { get; set; } = 0;
        public string? MailClassName { get; set; } = string.Empty;
        public decimal TotalDue { get; set; } = decimal.Zero;
        public string? VersionDropDate { get; set; } = string.Empty;
        public string? VersionDropActualDate { get; set; } = string.Empty;

        public List<Drops>? Drops { get; set; }
        public List<Details>? Details { get; set; }
        public List<Inventorys>? Inventorys { get; set; }
    }

    public class Drops
    {
        public int OrderVersionDropID { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string? DropName { get; set; } = string.Empty;
        public string? DropDate { get; set; } = string.Empty;
        public string? ActualDrop { get; set; } = string.Empty;
        public bool DropDateComplete { get; set; } = false;
    }

    public class Details
    {
        public int OrderVersionDetailID { get; set; } = 0;
        public int VersionID { get; set; } = 0;
        public int ServiceTypeID { get; set; } = 0;
        public int ServiceID { get; set; } = 0;
        public string? ServiceCode { get; set; } = string.Empty;
        public string? ServiceName { get; set; } = string.Empty;
        public decimal Quantity { get; set; } = decimal.Zero;
        public decimal UnitPrice { get; set; } = decimal.Zero;
        public decimal LineTotal { get; set; } = decimal.Zero;
        public bool IsTaxable { get; set; } = false;
        public decimal TaxablePercent { get; set; } = decimal.Zero;
        public decimal TaxAmount { get; set; } = decimal.Zero;
        public string? UnitOfMeasure { get; set; } = string.Empty;
    }

    public class Inventorys
    {
        public int OrderInventoryID { get; set; } = 0;
        public int OrderID { get; set; } = 0;
        public int VersionID { get; set; } = 0;
        public int ItemID { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public decimal QuantityNeeded { get; set; } = decimal.Zero;
        public string Notes { get; set; } = string.Empty;
        public string ItemCode { get; set; } = string.Empty;
    }
}
