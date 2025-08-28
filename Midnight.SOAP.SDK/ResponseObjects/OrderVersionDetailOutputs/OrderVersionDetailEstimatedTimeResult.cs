using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

/// <summary>
/// Represents the result of an estimated time request for order version details in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDetailEstimatedTimeResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of estimated time details for order version details.
    /// </summary>
    [XmlArray("OrderVersionDetailEstimatedTime")]
    [XmlArrayItem("Details")]
    public List<OrderVersionEstimatedTimeDetail> OrderVersionDetailEstimatedTime { get; set; } = new List<OrderVersionEstimatedTimeDetail>();
}

/// <summary>
/// Represents an estimated time detail for an order version detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionEstimatedTimeDetail : UserDefinedFieldsFirst10
{
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the order version due date.</summary>
    public string? OrderVersionDueDate { get; set; }
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int? OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service code.</summary>
    public string? ServiceCode { get; set; }
    /// <summary>Gets or sets the order version detail quantity.</summary>
    public decimal? OrderVersionDetailQuantity { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the order version detail run rate.</summary>
    public decimal? OrderVersionDetailRunRate { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the estimated service time.</summary>
    public decimal? EstimateServiceTime { get; set; } = decimal.Zero;
}