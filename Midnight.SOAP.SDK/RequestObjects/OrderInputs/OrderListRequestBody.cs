using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

/// <summary>
/// Represents the request body for listing orders in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderList")]
public class OrderListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order list request.
    /// </summary>
    public required OrderListInputParameter InputParameter { get; set; } = new OrderListInputParameter();
}

/// <summary>
/// Represents the input parameter for listing orders in the Midnight SOAP API.
/// </summary>
public class OrderListInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; } = string.Empty;
    /// <summary>Gets or sets the order number to copy from.</summary>
    public string? CopyFromOrderNumber { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer code.</summary>
    public string? CustomerCode { get; set; } = string.Empty;
    /// <summary>Gets or sets the order date from.</summary>
    public string? OrderDateFrom { get; set; } = string.Empty;
    /// <summary>Gets or sets the order date to.</summary>
    public string? OrderDateTo { get; set; } = string.Empty;
    /// <summary>Gets or sets the order status.</summary>
    public string? OrderStatus { get; set; } = string.Empty;
    /// <summary>Gets or sets the order due date from.</summary>
    public string? OrderDueDateFrom { get; set; } = string.Empty;
    /// <summary>Gets or sets the order due date to.</summary>
    public string? OrderDueDateTo { get; set; } = string.Empty;
    /// <summary>Gets or sets the order close date from.</summary>
    public string? OrderCloseDateFrom { get; set; } = string.Empty;
    /// <summary>Gets or sets the order close date to.</summary>
    public string? OrderCloseDateTo { get; set; } = string.Empty;
    /// <summary>Gets or sets the order modified date.</summary>
    public string? Ordermodifieddate { get; set; } = string.Empty;
    /// <summary>Gets or sets a value indicating whether to return only open orders.</summary>
    public bool? OpenOrdersOnly { get; set; } = true;
}
