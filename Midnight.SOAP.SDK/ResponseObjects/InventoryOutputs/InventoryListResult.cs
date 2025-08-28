using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

/// <summary>
/// Represents the result of an inventory list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of inventory items returned by the request.
    /// </summary>
    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
}

/// <summary>
/// Represents an inventory item in the Midnight SOAP API.
/// </summary>
public class InventoryItem : UserDefinedFields
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the item type description.</summary>
    public string? ItemTypeDescription { get; set; }
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

    /// <summary>Gets or sets the raw value indicating if the item is discontinued.</summary>
    [XmlElement("Discontinued")]
    public string? DiscontinuedRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is discontinued.</summary>
    [XmlIgnore]
    public bool Discontinued
    {
        get
        {
            if (string.IsNullOrWhiteSpace(DiscontinuedRaw)) return false;
            return string.Equals(DiscontinuedRaw, "true", StringComparison.OrdinalIgnoreCase)
                || DiscontinuedRaw == "1";
        }
    }

    /// <summary>Gets or sets the raw value indicating if the item is a kit.</summary>
    [XmlElement("Kit")]
    public string? KitRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is a kit.</summary>
    [XmlIgnore]
    public bool Kit
    {
        get
        {
            if (string.IsNullOrWhiteSpace(KitRaw)) return false;
            return string.Equals(KitRaw, "true", StringComparison.OrdinalIgnoreCase)
                || KitRaw == "1";
        }
    }

    /// <summary>Gets or sets the raw value indicating if the item is global.</summary>
    [XmlElement("Global")]
    public string? GlobalRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is global.</summary>
    [XmlIgnore]
    public bool Global
    {
        get
        {
            if (string.IsNullOrWhiteSpace(GlobalRaw)) return false;
            return string.Equals(GlobalRaw, "true", StringComparison.OrdinalIgnoreCase)
                || GlobalRaw == "1";
        }
    }

    /// <summary>Gets or sets the UPC code.</summary>
    public string? UPCCode { get; set; }
    /// <summary>Gets or sets the unit value.</summary>
    public decimal? UnitValue { get; set; }
    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; }
    /// <summary>Gets or sets the unit measure name.</summary>
    public string? UnitMeasureName { get; set; }
    /// <summary>Gets or sets the reorder point.</summary>
    public int? ReOrderPoint { get; set; }
    /// <summary>Gets or sets the reorder quantity.</summary>
    public int? ReOrderQuantity { get; set; }
    /// <summary>Gets or sets the lead time.</summary>
    public string? LeadTime { get; set; }
    /// <summary>Gets or sets the default quantity per container.</summary>
    public int? DefaultQuantitytPerContainer { get; set; }

    /// <summary>Gets or sets the raw value indicating if the item is a PO item.</summary>
    [XmlElement("POItem")]
    public string? POItemRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is a PO item.</summary>
    [XmlIgnore]
    public bool POItem
    {
        get
        {
            if (string.IsNullOrWhiteSpace(POItemRaw)) return false;
            return string.Equals(POItemRaw, "true", StringComparison.OrdinalIgnoreCase)
                || POItemRaw == "1";
        }
    }

    /// <summary>Gets or sets the raw value indicating if the item is print on demand.</summary>
    [XmlElement("PrintOnDemand")]
    public string? PrintOnDemandRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is print on demand.</summary>
    [XmlIgnore]
    public bool PrintOnDemand
    {
        get
        {
            if (string.IsNullOrWhiteSpace(PrintOnDemandRaw)) return false;
            return string.Equals(PrintOnDemandRaw, "true", StringComparison.OrdinalIgnoreCase)
                || PrintOnDemandRaw == "1";
        }
    }

    /// <summary>Gets or sets the raw value indicating if the item is a digital asset.</summary>
    [XmlElement("DigitalAsset")]
    public string? DigitalAssetRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is a digital asset.</summary>
    [XmlIgnore]
    public bool DigitalAsset
    {
        get
        {
            if (string.IsNullOrWhiteSpace(DigitalAssetRaw)) return false;
            return string.Equals(DigitalAssetRaw, "true", StringComparison.OrdinalIgnoreCase)
                || DigitalAssetRaw == "1";
        }
    }

    /// <summary>Gets or sets the raw value indicating if the item is serialized.</summary>
    [XmlElement("Serialized")]
    public string? SerializedRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is serialized.</summary>
    [XmlIgnore]
    public bool Serialized
    {
        get
        {
            if (string.IsNullOrWhiteSpace(SerializedRaw)) return false;
            return string.Equals(SerializedRaw, "true", StringComparison.OrdinalIgnoreCase)
                || SerializedRaw == "1";
        }
    }

    /// <summary>Gets or sets the vendor.</summary>
    public string? Vendor { get; set; }
    /// <summary>Gets or sets the color.</summary>
    public string? Color { get; set; }

    /// <summary>Gets or sets the raw value indicating if the item is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

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

    /// <summary>Gets or sets the raw value indicating if the item is coated.</summary>
    [XmlElement("Coated")]
    public string? CoatedRaw { get; set; }
    /// <summary>Gets a value indicating whether the item is coated.</summary>
    [XmlIgnore]
    public bool Coated
    {
        get
        {
            if (string.IsNullOrWhiteSpace(CoatedRaw)) return false;
            return string.Equals(CoatedRaw, "true", StringComparison.OrdinalIgnoreCase)
                || CoatedRaw == "1";
        }
    }

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
    /// <summary>Gets or sets the item quantity.</summary>
    public int? ItemQuantity { get; set; }
    /// <summary>Gets or sets the on hand quantity.</summary>
    public int? OnHandQuantity { get; set; }
    /// <summary>Gets or sets the reserved quantity.</summary>
    public int? ReservedQuantity { get; set; }
    /// <summary>Gets or sets the item comment.</summary>
    public string? ItemComment { get; set; }
    /// <summary>Gets or sets the creation date and time.</summary>
    public DateTime? CreateDateTime { get; set; }
}