using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

/// <summary>
/// Represents the request body for creating a new inventory item in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryNew")]
public class InventoryNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory new request.
    /// </summary>
    public required InventoryNewInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new inventory item in the Midnight SOAP API.
/// </summary>
public class InventoryNewInputParameter
{
    /// <summary>Gets or sets the list of items to add.</summary>
    public List<Item> Items { get; set; } = new();
}

/// <summary>
/// Represents an inventory item to add in the Midnight SOAP API.
/// </summary>
public class Item : UserDefinedFields
{
    /// <summary>Gets or sets the customer ID.</summary>
    public int CustomerID { get; set; }
    /// <summary>Gets or sets the item type name.</summary>
    public string? ItemTypeName { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the item name.</summary>
    public string? ItemName { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    public string? ItemDescription { get; set; }
    /// <summary>Gets or sets the customer part number.</summary>
    public string? CustomerPartNumber { get; set; }
    /// <summary>Gets or sets the version number.</summary>
    public string? VersionNumber { get; set; }
    /// <summary>Gets or sets the lot.</summary>
    public string? Lot { get; set; }
    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is discontinued.</summary>
    public bool? Discontinued { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a kit.</summary>
    public bool? Kit { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is global.</summary>
    public bool? Global { get; set; }
    /// <summary>Gets or sets the UPC code.</summary>
    public string? UPCCode { get; set; }
    /// <summary>Gets or sets the unit value.</summary>
    public decimal? UnitValue { get; set; }
    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; }
    /// <summary>Gets or sets the reorder point.</summary>
    public int? ReOrderPoint { get; set; }
    /// <summary>Gets or sets the reorder quantity.</summary>
    public int? ReOrderQuantity { get; set; }
    /// <summary>Gets or sets the lead time.</summary>
    public int? LeadTime { get; set; }
    /// <summary>Gets or sets the default quantity per container.</summary>
    public int? DefaultQuantityPerContainer { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a PO item.</summary>
    public bool? POItem { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is print on demand.</summary>
    public bool? PrintOnDemand { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is a digital asset.</summary>
    public bool? DigitalAsset { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is serialized.</summary>
    public bool? Serialized { get; set; }
    /// <summary>Gets or sets the vendor.</summary>
    public string? Vendor { get; set; }
    /// <summary>Gets or sets the color.</summary>
    public string? Color { get; set; }
    /// <summary>Gets or sets the material type.</summary>
    public string? MaterialType { get; set; }
    /// <summary>Gets or sets the unit cost.</summary>
    public decimal? UnitCost { get; set; }
    /// <summary>Gets or sets the cover text.</summary>
    public string? CoverText { get; set; }
    /// <summary>Gets or sets the parent sheet length.</summary>
    public decimal? ParentSheetLength { get; set; }
    /// <summary>Gets or sets the parent sheet width.</summary>
    public decimal? ParentSheetWidth { get; set; }
    /// <summary>Gets or sets the basis weight.</summary>
    public decimal? BasisWeight { get; set; }
    /// <summary>Gets or sets the M weight.</summary>
    public decimal? MWeight { get; set; }
    /// <summary>Gets or sets the caliper.</summary>
    public decimal? Caliper { get; set; }
    /// <summary>Gets or sets a value indicating whether the item is coated.</summary>
    public bool? Coated { get; set; }
    /// <summary>Gets or sets the cost per CWT.</summary>
    public decimal? CostPerCwt { get; set; }
    /// <summary>Gets or sets the cost per M sheets.</summary>
    public decimal? CostPerMSheets { get; set; }
    /// <summary>Gets or sets the paper weight.</summary>
    public decimal? PaperWeight { get; set; }
    /// <summary>Gets or sets the paper markup.</summary>
    public decimal? PaperMarkup { get; set; }
    /// <summary>Gets or sets the weight per square foot.</summary>
    public decimal? WeightPerSqFt { get; set; }
    /// <summary>Gets or sets the cost per square foot.</summary>
    public decimal? CostPerSqFt { get; set; }
    /// <summary>Gets or sets the parent roll length.</summary>
    public decimal? ParentRollLength { get; set; }
    /// <summary>Gets or sets the parent roll width.</summary>
    public decimal? ParentRollWidth { get; set; }
    /// <summary>Gets or sets the roll weight.</summary>
    public decimal? RollWeight { get; set; }
    /// <summary>Gets or sets the cost per pound.</summary>
    public decimal? CostPerPound { get; set; }
    /// <summary>Gets or sets the item comment.</summary>
    public string? ItemComment { get; set; }
    /// <summary>Gets or sets the list of item adds.</summary>
    public List<ItemAdd> ItemAdds { get; set; } = new List<ItemAdd>();
}

/// <summary>
/// Represents an item add entry for inventory in the Midnight SOAP API.
/// </summary>
public class ItemAdd
{
    /// <summary>Gets or sets the warehouse location ID.</summary>
    public int WarehouseLocationID { get; set; }
    /// <summary>Gets or sets the quantity to add.</summary>
    public int ItemAddQuantity { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int OrderID { get; set; }
    /// <summary>Gets or sets the item add comment.</summary>
    public string? ItemAddComment { get; set; }
}