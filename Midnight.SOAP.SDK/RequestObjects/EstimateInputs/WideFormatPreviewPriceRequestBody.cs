using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for previewing wide format price in the Midnight SOAP API.
/// </summary>
[XmlRoot("WFPreviewPrice")]
public class WideFormatPreviewPriceRequestBody
{
    /// <summary>Gets or sets the wide format product type ID.</summary>
    public required int WideFormatProductTypeID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public required int Quantity { get; set; }
}
