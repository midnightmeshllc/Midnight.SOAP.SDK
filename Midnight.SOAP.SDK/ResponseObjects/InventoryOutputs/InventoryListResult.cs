
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class InventoryListResult : CommonResult
{
    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
}

public class InventoryItem : UserDefinedFields
{
    public int ItemID { get; set; }
    public int CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public string? ItemTypeDescription { get; set; }
    public string? ItemCode { get; set; }
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public string? CustomerPartNumber { get; set; }
    public string? VersionNumber { get; set; }
    public string? Lot { get; set; }
    public string? ExpirationDate { get; set; }

    [XmlElement("Discontinued")]
    public string? DiscontinuedRaw { get; set; }
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

    [XmlElement("Kit")]
    public string? KitRaw { get; set; }
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

    [XmlElement("Global")]
    public string? GlobalRaw { get; set; }
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

    public string? UPCCode { get; set; }
    public decimal? UnitValue { get; set; }
    public string? UnitMeasureCode { get; set; }
    public string? UnitMeasureName { get; set; }
    public int? ReOrderPoint { get; set; }
    public int? ReOrderQuantity { get; set; }
    public string? LeadTime { get; set; }
    public int? DefaultQuantitytPerContainer { get; set; }

    [XmlElement("POItem")]
    public string? POItemRaw { get; set; }
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

    [XmlElement("PrintOnDemand")]
    public string? PrintOnDemandRaw { get; set; }
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

    [XmlElement("DigitalAsset")]
    public string? DigitalAssetRaw { get; set; }
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

    [XmlElement("Serialized")]
    public string? SerializedRaw { get; set; }
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

    public string? Vendor { get; set; }
    public string? Color { get; set; }

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
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

    public string? MaterialType { get; set; }
    public decimal? UnitCost { get; set; }
    public string? CoverText { get; set; }
    public decimal? ParentSheetLength { get; set; }
    public decimal? ParentSheetWidth { get; set; }
    public decimal? BasisWeight { get; set; }
    public decimal? MWeight { get; set; }
    public decimal? Caliper { get; set; }

    [XmlElement("Coated")]
    public string? CoatedRaw { get; set; }
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

    public decimal? CostPerCwt { get; set; }
    public decimal? CostPerMSheets { get; set; }
    public decimal? PaperWeight { get; set; }
    public decimal? PaperMarkup { get; set; }
    public decimal? WeightPerSqFt { get; set; }
    public decimal? CostPerSqFt { get; set; }
    public decimal? ParentRollLength { get; set; }
    public decimal? ParentRollWidth { get; set; }
    public decimal? RollWeight { get; set; }
    public decimal? CostPerPound { get; set; }
    public int? ItemQuantity { get; set; }
    public int? OnHandQuantity { get; set; }
    public int? ReservedQuantity { get; set; }
    public string? ItemComment { get; set; }
    public DateTime? CreateDateTime { get; set; }
}