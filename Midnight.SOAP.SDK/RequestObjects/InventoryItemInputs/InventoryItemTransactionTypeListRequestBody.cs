using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for listing inventory item transaction types in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemTransactionTypeList")]
public class InventoryItemTransactionTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item transaction type list request.
    /// </summary>
    public required InventoryItemTransactionTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing inventory item transaction types in the Midnight SOAP API.
/// </summary>
public class InventoryItemTransactionTypeListInputParameter
{
    /// <summary>Gets or sets the item transaction type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemTransactionTypeID { get; set; }
    /// <summary>Gets or sets the description.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
}