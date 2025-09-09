using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for previewing print template price in the Midnight SOAP API.
/// </summary>
[XmlRoot("PrintTemplatePreviewPrice")]
public class PrintTemplatePreviewPriceRequestBody
{
    /// <summary>Gets or sets the project type ID.</summary>
    public required int ProjectTypeID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public required int Quantity { get; set; }
}
