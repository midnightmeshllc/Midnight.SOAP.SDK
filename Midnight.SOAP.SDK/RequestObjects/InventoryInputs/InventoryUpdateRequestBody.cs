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
    [XmlElement(IsNullable = true)]
    public string? ItemTypeName { get; set; }
    /// <summary>Gets or sets the item name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ItemName { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    [XmlElement(IsNullable = true)]
    public string? ItemDescription { get; set; }
    /// <summary>Gets or sets the customer part number.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerPartNumber { get; set; }
    /// <summary>Gets or sets the version number.</summary>
    [XmlElement(IsNullable = true)]
    public string? VersionNumber { get; set; }
    /// <summary>Gets or sets the lot.</summary>
    [XmlElement(IsNullable = true)]
    public string? Lot { get; set; }
    /// <summary>Gets or sets the expiration date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ExpirationDate { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is discontinued.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Discontinued { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a kit.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Kit { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is global.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Global { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is active.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Active { get; set; }
    /// <summary>Gets or sets the UPC code.</summary>
    [XmlElement(IsNullable = true)]
    public string? UPCCode { get; set; }
    /// <summary>Gets or sets the unit value.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UnitValue { get; set; }
    /// <summary>Gets or sets the unit measure code.</summary>
    [XmlElement(IsNullable = true)]
    public string? UnitMeasureCode { get; set; }
    /// <summary>Gets or sets the reorder point.</summary>
    [XmlElement(IsNullable = true)]
    public int? ReOrderPoint { get; set; }
    /// <summary>Gets or sets the reorder quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? ReOrderQuantity { get; set; }
    /// <summary>Gets or sets the lead time.</summary>
    [XmlElement(IsNullable = true)]
    public int? LeadTime { get; set; }
    /// <summary>Gets or sets the default quantity per container.</summary>
    [XmlElement(IsNullable = true)]
    public int? DefaultQuantityPerContainer { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a PO item.</summary>
    [XmlElement(IsNullable = true)]
    public bool? POItem { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is print on demand.</summary>
    [XmlElement(IsNullable = true)]
    public bool? PrintOnDemand { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a digital asset.</summary>
    [XmlElement(IsNullable = true)]
    public bool? DigitalAsset { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is serialized.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Serialized { get; set; }
    /// <summary>Gets or sets the vendor.</summary>
    [XmlElement(IsNullable = true)]
    public string? Vendor { get; set; }
    /// <summary>Gets or sets the color.</summary>
    [XmlElement(IsNullable = true)]
    public string? Color { get; set; }
    /// <summary>Gets or sets the material type.</summary>
    [XmlElement(IsNullable = true)]
    public string? MaterialType { get; set; }
    /// <summary>Gets or sets the unit cost.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UnitCost { get; set; }
    /// <summary>Gets or sets the cover text.</summary>
    [XmlElement(IsNullable = true)]
    public string? CoverText { get; set; }
    /// <summary>Gets or sets the parent sheet length.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ParentSheetLength { get; set; }
    /// <summary>Gets or sets the parent sheet width.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ParentSheetWidth { get; set; }
    /// <summary>Gets or sets the basis weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? BasisWeight { get; set; }
    /// <summary>Gets or sets the M weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? MWeight { get; set; }
    /// <summary>Gets or sets the caliper.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Caliper { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is coated.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Coated { get; set; }
    /// <summary>Gets or sets the cost per CWT.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? CostPerCwt { get; set; }
    /// <summary>Gets or sets the cost per M sheets.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? CostPerMSheets { get; set; }
    /// <summary>Gets or sets the paper weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PaperWeight { get; set; }
    /// <summary>Gets or sets the paper markup.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PaperMarkup { get; set; }
    /// <summary>Gets or sets the weight per square foot.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? WeightPerSqFt { get; set; }
    /// <summary>Gets or sets the cost per square foot.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? CostPerSqFt { get; set; }
    /// <summary>Gets or sets the parent roll length.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ParentRollLength { get; set; }
    /// <summary>Gets or sets the parent roll width.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ParentRollWidth { get; set; }
    /// <summary>Gets or sets the roll weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? RollWeight { get; set; }
    /// <summary>Gets or sets the cost per pound.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? CostPerPound { get; set; }
    /// <summary>Gets or sets the item comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? ItemComment { get; set; }

}