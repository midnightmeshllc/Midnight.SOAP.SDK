using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

/// <summary>
/// Represents the request body for deleting an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDropDelete")]
public class OrderVersionDropDeleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version drop delete request.
    /// </summary>
    public required OrderVersionDropDeleteinputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for deleting an order version drop in the Midnight SOAP API.
/// </summary>
public class OrderVersionDropDeleteinputParameter
{
    /// <summary>Gets or sets the order version drop ID.</summary>
    public required int OrderVersionDropID { get; set; }
}