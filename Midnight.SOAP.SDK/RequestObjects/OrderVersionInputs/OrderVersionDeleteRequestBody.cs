using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for deleting an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDelete")]
public class OrderVersionDeleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version delete request.
    /// </summary>
    public required OrderVersionDeleteInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for deleting an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionDeleteInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
}