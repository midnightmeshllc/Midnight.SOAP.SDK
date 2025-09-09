using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of an order list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of orders returned by the request.
    /// </summary>
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<Order> Orders { get; set; } = new List<Order>();
}

/// <summary>
/// Represents an order in the Midnight SOAP API.
/// </summary>
public class Order : UserDefinedFields
{
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the contact name.</summary>
    public string? ContactName { get; set; }
    /// <summary>Gets or sets the sales representative name.</summary>
    public string? SalesRepName { get; set; }
    /// <summary>Gets or sets the CSR name.</summary>
    public string? CSRName { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the licensee name.</summary>
    public string? LicenseeName { get; set; }
    /// <summary>Gets or sets the purchase order number.</summary>
    public string? PurchaseOrderNumber { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; }
    /// <summary>Gets or sets the raw value indicating if the order is taxable.</summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    /// <summary>Gets a value indicating whether the order is taxable.</summary>
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

    /// <summary>Gets or sets the order status.</summary>
    public string? OrderStatus { get; set; }
    /// <summary>Gets or sets the order date.</summary>
    public string? OrderDate { get; set; }
    /// <summary>Gets or sets the data in date.</summary>
    public string? DataInDate { get; set; }
    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; }
    /// <summary>Gets or sets the artwork in date.</summary>
    public string? ArtworkInDate { get; set; }
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; }
    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; }
    /// <summary>Gets or sets the expected quantity.</summary>
    public int? QuantityExpected { get; set; }
    /// <summary>Gets or sets the order progress code.</summary>
    public string? OrderProgressCode { get; set; }
    /// <summary>Gets or sets the order progress text.</summary>
    public string? OrderProgressText { get; set; }
    /// <summary>Gets or sets the order tax.</summary>
    public decimal? OrderTax { get; set; }
    /// <summary>Gets or sets the order total.</summary>
    public decimal? OrderTotal { get; set; }
    /// <summary>Gets or sets the postage total.</summary>
    public decimal? PostageTotal { get; set; }
    /// <summary>Gets or sets the available earmarked deposit.</summary>
    public decimal? AvailableEarmarkedDeposit { get; set; }
    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; }
    /// <summary>Gets or sets the job type.</summary>
    public string? JobType { get; set; }
}
