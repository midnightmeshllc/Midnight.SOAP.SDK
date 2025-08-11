
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderListResult : CommonResult
{
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<Order> Orders { get; set; } = new List<Order>();
}

public class Order : UserDefinedFields
{
    public int? OrderID { get; set; }
    public string? OrderNumber { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public string? ContactName { get; set; }
    public string? SalesRepName { get; set; }
    public string? CSRName { get; set; }
    public string? ProjectName { get; set; }
    public string? LicenseeName { get; set; }
    public string? PurchaseOrderNumber { get; set; }
    public string? Terms { get; set; }
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    [XmlIgnore]
    public bool Taxable
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TaxableRaw)) return false;
            return string.Equals(TaxableRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TaxableRaw == "1";
        }
    }

    public string? OrderStatus { get; set; }
    public string? OrderDate { get; set; }
    public string? DataInDate { get; set; }
    public string? MaterialInDate { get; set; }
    public string? ArtworkInDate { get; set; }
    public string? DueDate { get; set; }
    public string? CloseDate { get; set; }
    public int? QuantityExpected { get; set; }
    public string? OrderProgressCode { get; set; }
    public string? OrderProgressText { get; set; }
    public decimal? OrderTax { get; set; }
    public decimal? OrderTotal { get; set; }
    public decimal? PostageTotal { get; set; }
    public decimal? AvailableEarmarkedDeposit { get; set; }
    public string? ShipDate { get; set; }
    public string? JobType { get; set; }
}
