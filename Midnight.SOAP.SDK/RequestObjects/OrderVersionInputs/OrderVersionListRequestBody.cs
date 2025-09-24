using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for listing order versions in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionList")]
public class OrderVersionListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version list request.
    /// </summary>
    public required OrderVersionListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order versions in the Midnight SOAP API.
/// </summary>
public class OrderVersionListInputParameter
{
    /// <summary>Gets or sets the order ID.</summary>
    public required int OrderID { get; set; }
    /// <summary>Gets or sets the order drop date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDropDateFrom { get; set; }
    /// <summary>Gets or sets the order drop date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDropDateTo { get; set; }
}