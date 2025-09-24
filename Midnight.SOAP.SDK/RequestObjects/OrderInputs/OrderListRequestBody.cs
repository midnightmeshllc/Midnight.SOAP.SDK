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
    [XmlElement(IsNullable = true)]
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the order number to copy from.</summary>
    [XmlElement(IsNullable = true)]
    public string? CopyFromOrderNumber { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerCode { get; set; }
    /// <summary>Gets or sets the order date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDateFrom { get; set; }
    /// <summary>Gets or sets the order date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDateTo { get; set; }
    /// <summary>Gets or sets the order status.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderStatus { get; set; }
    /// <summary>Gets or sets the order due date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDueDateFrom { get; set; }
    /// <summary>Gets or sets the order due date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDueDateTo { get; set; }
    /// <summary>Gets or sets the order close date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderCloseDateFrom { get; set; }
    /// <summary>Gets or sets the order close date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderCloseDateTo { get; set; }
    /// <summary>Gets or sets the order modified date.</summary>
    [XmlElement(IsNullable = true)]
    public string? Ordermodifieddate { get; set; }
    /// <summary>Gets or sets a value indicating whether to return only open orders.</summary>
    [XmlElement(IsNullable = true)]
    public bool? OpenOrdersOnly { get; set; }
}
