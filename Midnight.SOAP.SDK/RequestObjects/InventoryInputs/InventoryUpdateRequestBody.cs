using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

/// <summary>
/// Represents the request body for updating an inventory item in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryUpdate")]
public class InventoryUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory update request.
    /// </summary>
    public required InventoryUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an inventory item in the Midnight SOAP API.
/// </summary>
public class InventoryUpdateInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int CustomerID { get; set; }
    /// <summary>Gets or sets the item type name.</summary>
    public string? ItemTypeName { get; set; } = null;
    /// <summary>Gets or sets the item name.</summary>
    public string? ItemName { get; set; } = null;
    /// <summary>Gets or sets the item description.</summary>
    public string? ItemDescription { get; set; } = null;
    /// <summary>Gets or sets the customer part number.</summary>
    public string? CustomerPartNumber { get; set; } = null;
    /// <summary>Gets or sets the version number.</summary>
    public string? VersionNumber { get; set; } = null;
    /// <summary>Gets or sets the lot.</summary>
    public string? Lot { get; set; } = null;
    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is discontinued.</summary>
    public bool? Discontinued { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is a kit.</summary>
    public bool? Kit { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is global.</summary>
    public bool? Global { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is active.</summary>
    public bool? Active { get; set; } = null;
    /// <summary>Gets or sets the UPC code.</summary>
    public string? UPCCode { get; set; } = null;
    /// <summary>Gets or sets the unit value.</summary>
    public decimal? UnitValue { get; set; } = null;
    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; } = null;
    /// <summary>Gets or sets the reorder point.</summary>
    public int? ReOrderPoint { get; set; } = null;
    /// <summary>Gets or sets the reorder quantity.</summary>
    public int? ReOrderQuantity { get; set; } = null;
    /// <summary>Gets or sets the lead time.</summary>
    public int? LeadTime { get; set; } = null;
    /// <summary>Gets or sets the default quantity per container.</summary>
    public int? DefaultQuantityPerContainer { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is a PO item.</summary>
    public bool? POItem { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is print on demand.</summary>
    public bool? PrintOnDemand { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is a digital asset.</summary>
    public bool? DigitalAsset { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is serialized.</summary>
    public bool? Serialized { get; set; } = null;
    /// <summary>Gets or sets the vendor.</summary>
    public string? Vendor { get; set; } = null;
    /// <summary>Gets or sets the color.</summary>
    public string? Color { get; set; } = null;
    /// <summary>Gets or sets the material type.</summary>
    public string? MaterialType { get; set; } = null;
    /// <summary>Gets or sets the unit cost.</summary>
    public decimal? UnitCost { get; set; } = null;
    /// <summary>Gets or sets the cover text.</summary>
    public string? CoverText { get; set; } = null;
    /// <summary>Gets or sets the parent sheet length.</summary>
    public decimal? ParentSheetLength { get; set; } = null;
    /// <summary>Gets or sets the parent sheet width.</summary>
    public decimal? ParentSheetWidth { get; set; } = null;
    /// <summary>Gets or sets the basis weight.</summary>
    public decimal? BasisWeight { get; set; } = null;
    /// <summary>Gets or sets the M weight.</summary>
    public decimal? MWeight { get; set; } = null;
    /// <summary>Gets or sets the caliper.</summary>
    public decimal? Caliper { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is coated.</summary>
    public bool? Coated { get; set; } = null;
    /// <summary>Gets or sets the cost per CWT.</summary>
    public decimal? CostPerCwt { get; set; } = null;
    /// <summary>Gets or sets the cost per M sheets.</summary>
    public decimal? CostPerMSheets { get; set; } = null;
    /// <summary>Gets or sets the paper weight.</summary>
    public decimal? PaperWeight { get; set; } = null;
    /// <summary>Gets or sets the paper markup.</summary>
    public decimal? PaperMarkup { get; set; } = null;
    /// <summary>Gets or sets the weight per square foot.</summary>
    public decimal? WeightPerSqFt { get; set; } = null;
    /// <summary>Gets or sets the cost per square foot.</summary>
    public decimal? CostPerSqFt { get; set; } = null;
    /// <summary>Gets or sets the parent roll length.</summary>
    public decimal? ParentRollLength { get; set; } = null;
    /// <summary>Gets or sets the parent roll width.</summary>
    public decimal? ParentRollWidth { get; set; } = null;
    /// <summary>Gets or sets the roll weight.</summary>
    public decimal? RollWeight { get; set; } = null;
    /// <summary>Gets or sets the cost per pound.</summary>
    public decimal? CostPerPound { get; set; } = null;
    /// <summary>Gets or sets the item comment.</summary>
    public string? ItemComment { get; set; } = null;

}