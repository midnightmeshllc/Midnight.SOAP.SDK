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
    public string? PurchaseOrderType { get; set; } = null;
    /// <summary>Gets or sets the purchase order ID.</summary>
    public int? PurchaseOrderID { get; set; } = null;
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; } = null;
}