using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for listing item request types in the Midnight SOAP API.
/// </summary>
[XmlRoot("ItemRequestTypeList")]
public class ItemRequestTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the item request type list request.
    /// </summary>
    public required ItemRequestTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing item request types in the Midnight SOAP API.
/// </summary>
public class ItemRequestTypeListInputParameter
{
    /// <summary>Gets or sets the item request type ID.</summary>
    public int? ItemRequestTypeID { get; set; } = null;
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
}