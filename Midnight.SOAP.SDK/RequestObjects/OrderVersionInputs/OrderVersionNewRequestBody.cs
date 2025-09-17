using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for creating a new order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionNew")]
public class OrderVersionNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version new request.
    /// </summary>
    public required OrderVersionNewInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionNewInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the order ID.</summary>
    public required int OrderID { get; set; }
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int Quantity { get; set; }
    /// <summary>Gets or sets the name.</summary>
    public string? Name { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
    /// <summary>Gets or sets the data processing status ID.</summary>
    public int? DataProcessingStatusID { get; set; } = null;
    /// <summary>Gets or sets the job type ID.</summary>
    public int? JobTypeID { get; set; } = null;
    /// <summary>Gets or sets the urgency ID.</summary>
    public int? UrgencyID { get; set; } = null;
    /// <summary>Gets or sets the list of order version details.</summary>
    public List<OrderVersionDetail>? OrderVersionDetails { get; set; }
    /// <summary>Gets or sets the list of order version inventories.</summary>
    public List<OrderVersionInventoryNew>? OrderVersionInventories { get; set; }
}

/// <summary>
/// Represents a new inventory entry for an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionInventoryNew
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the quantity needed.</summary>
    public int? QuantityNeeded { get; set; } = null;
    /// <summary>Gets or sets the item priority.</summary>
    public int? ItemPriority { get; set; } = null;
    /// <summary>Gets or sets the notes.</summary>
    public string? Notes { get; set; } = null;
}

/// <summary>
/// Represents a detail entry for an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetail
{
    /// <summary>Gets or sets the service ID.</summary>
    public int ServiceID { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; } = null;
    /// <summary>Gets or sets the service quantity.</summary>
    public int? ServiceQuantity { get; set; } = null;
    /// <summary>Gets or sets the service unit price.</summary>
    public decimal? ServiceUnitPrice { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the service is taxable.</summary>
    public bool ServiceTaxable { get; set; } = true;
    /// <summary>Gets or sets the service priority.</summary>
    public int? ServicePriority { get; set; } = null;
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? Servicehyperlink { get; set; } = null;
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; } = null;
    /// <summary>Gets or sets the service comment.</summary>
    public string? ServiceComment { get; set; } = null;
}