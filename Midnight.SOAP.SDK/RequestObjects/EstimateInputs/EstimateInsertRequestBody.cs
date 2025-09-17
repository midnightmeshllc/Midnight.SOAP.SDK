using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for inserting an estimate in the Midnight SOAP API.
/// </summary>
[XmlRoot("EstimateInsertModel")]
public class EstimateInsertRequestBody
{
    /// <summary>Gets or sets the expected quantity.</summary>
    public int? ExpectedQuantity { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the contact ID.</summary>
    public int? ContactID { get; set; } = null;
    /// <summary>Gets or sets the sales representative ID.</summary>
    public int? SalesRepID { get; set; } = null;
    /// <summary>Gets or sets the customer service representative ID.</summary>
    public int? CSRID { get; set; } = null;
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; } = null;
    /// <summary>Gets or sets the PO number.</summary>
    public string? PONumber { get; set; } = null;
    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the estimate is taxable.</summary>
    public bool EstimateTaxable { get; set; } = true;
    /// <summary>Gets or sets the estimate date.</summary>
    public string? EstimateDate { get; set; } = null;
    /// <summary>Gets or sets the data in date.</summary>
    public string? DataIn { get; set; } = null;
    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; } = null;
    /// <summary>Gets or sets the artwork in date.</summary>
    public string? ArtworkInDate { get; set; } = null;
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; } = null;
    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; } = null;
    /// <summary>Gets or sets the estimate detail comment.</summary>
    public string? EstimateDetailComment { get; set; } = null;
    /// <summary>Gets or sets the list of estimate user-defined fields.</summary>
    public List<EstimateUDF> EstimateUDFList { get; set; } = new List<EstimateUDF>();
    /// <summary>Gets or sets the list of inventory items.</summary>
    public List<Inventory> InventoryList { get; set; } = new List<Inventory>();
    /// <summary>Gets or sets the list of new estimate services.</summary>
    public List<NewEstimateService> ServiceList { get; set; } = new List<NewEstimateService>();
}

/// <summary>
/// Represents a new estimate service in the Midnight SOAP API.
/// </summary>
public class NewEstimateService
{
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service quantity.</summary>
    public decimal? ServiceQuantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; }
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; }
    /// <summary>Gets or sets the item notes.</summary>
    public string? ItemNotes { get; set; }
    /// <summary>Gets or sets a value indicating whether the service is taxable.</summary>
    public bool Taxable { get; set; }
    /// <summary>Gets or sets the list of user-defined fields for the service.</summary>
    public List<NewEstimateServiceUDF> UDFList { get; set; } = new List<NewEstimateServiceUDF>();
}

/// <summary>
/// Represents a user-defined field for a new estimate service in the Midnight SOAP API.
/// </summary>
public class NewEstimateServiceUDF : UserDefinedFields
{
}

/// <summary>
/// Represents an inventory item for an estimate in the Midnight SOAP API.
/// </summary>
public class Inventory
{
    /// <summary>Gets or sets the priority.</summary>
    public int? Priority { get; set; }
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the quantity needed.</summary>
    public int? QuantityNeeded { get; set; }
}

/// <summary>
/// Represents a user-defined field for an estimate in the Midnight SOAP API.
/// </summary>
public class EstimateUDF : UserDefinedFields
{
}