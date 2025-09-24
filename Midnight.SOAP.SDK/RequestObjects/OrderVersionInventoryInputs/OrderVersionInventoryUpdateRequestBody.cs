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
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the quantity needed.</summary>
    [XmlElement(IsNullable = true)]
    public int? QuantityNeeded { get; set; }
    /// <summary>Gets or sets the priority.</summary>
    [XmlElement(IsNullable = true)]
    public int? Priority { get; set; }
    /// <summary>Gets or sets the notes.</summary>
    [XmlElement(IsNullable = true)]
    public string? Notes { get; set; }
}