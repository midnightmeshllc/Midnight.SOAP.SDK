using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

/// <summary>
/// Represents the request body for listing order version inventories in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionInventoryList")]
public class OrderVersionInventoryListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version inventory list request.
    /// </summary>
    public required OrderVersionInventoryListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version inventories in the Midnight SOAP API.
/// </summary>
public class OrderVersionInventoryListInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public int VersionID { get; set; }
}