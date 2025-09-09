using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

/// <summary>
/// Represents the request body for listing order version drops in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDropList")]
public class OrderVersionDropListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version drop list request.
    /// </summary>
    public required OrderVersionDropListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version drops in the Midnight SOAP API.
/// </summary>
public class OrderVersionDropListInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
}