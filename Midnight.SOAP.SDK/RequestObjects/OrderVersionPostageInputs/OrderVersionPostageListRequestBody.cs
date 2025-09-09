using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for listing order version postages in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageList")]
public class OrderVersionPostageListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage list request.
    /// </summary>
    public required OrderVersionPostageListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version postages in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageListInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
}