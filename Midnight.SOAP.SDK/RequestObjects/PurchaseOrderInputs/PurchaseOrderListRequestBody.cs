using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;

/// <summary>
/// Represents the request body for listing purchase orders in the Midnight SOAP API.
/// </summary>
[XmlRoot("PurchaseOrderList")]
public class PurchaseOrderListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the purchase order list request.
    /// </summary>
    public required PurchaseOrderListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing purchase orders in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderListInputParameter
{
    /// <summary>Gets or sets the purchase order type.</summary>
    [XmlElement(IsNullable = true)]
    public string? PurchaseOrderType { get; set; }

    /// <summary>Gets or sets the purchase order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? PurchaseOrderID { get; set; }

    /// <summary>Gets or sets the vendor ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? VendorID { get; set; }

    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderID { get; set; }

    /// <summary>Gets or sets the company ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CompanyID { get; set; }
}