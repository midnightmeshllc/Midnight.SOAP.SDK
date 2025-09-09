using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for completing an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionComplete")]
public class OrderVersionCompleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version complete request.
    /// </summary>
    public required OrderVersionCompleteInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for completing an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionCompleteInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
    /// <summary>Gets or sets a value indicating whether the order version is complete.</summary>
    public required bool Complete { get; set; }
}