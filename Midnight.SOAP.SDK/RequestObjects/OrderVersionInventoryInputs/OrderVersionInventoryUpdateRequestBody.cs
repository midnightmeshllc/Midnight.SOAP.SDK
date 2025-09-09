using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

/// <summary>
/// Represents the request body for updating an order version inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionInventoryUpdate")]
public class OrderVersionInventoryUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version inventory update request.
    /// </summary>
    public required OrderVersionInventoryUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version inventory in the Midnight SOAP API.
/// </summary>
public class OrderVersionInventoryUpdateInputParameter
{
    /// <summary>Gets or sets the order inventory ID.</summary>
    public required int OrderInventoryID { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the quantity needed.</summary>
    public int? QuantityNeeded { get; set; } = null;
    /// <summary>Gets or sets the priority.</summary>
    public int? Priority { get; set; } = null;
    /// <summary>Gets or sets the notes.</summary>
    public string? Notes { get; set; } = null;
}