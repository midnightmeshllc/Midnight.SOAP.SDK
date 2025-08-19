using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

[XmlRoot("InventoryUpdate")]
public class InventoryUpdateRequestBody
{
    public required InventoryUpdateInputParameter InputParameter { get; set; }
}

public class InventoryUpdateInputParameter : UserDefinedFields
{
    public int ItemID { get; set; }
    public int CustomerID { get; set; }
    public string? ItemTypeName { get; set; }
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public string? CustomerPartNumber { get; set; }
    public string? VersionNumber { get; set; }
    public string? Lot { get; set; }
    public string? ExpirationDate { get; set; }
    public bool? Discontinued { get; set; }
    public bool? Kit { get; set; }
    public bool? Global { get; set; }
    public bool? Active { get; set; }
    public string? UPCCode { get; set; }
    public decimal? UnitValue { get; set; }
    public string? UnitMeasureCode { get; set; }
    public int? ReOrderPoint { get; set; }
    public int? ReOrderQuantity { get; set; }
    public int? LeadTime { get; set; }
    public int? DefaultQuantityPerContainer { get; set; }
    public bool? POItem { get; set; }
    public bool? PrintOnDemand { get; set; }
    public bool? DigitalAsset { get; set; }
    public bool? Serialized { get; set; }
    public string? Vendor { get; set; }
    public string? Color { get; set; }
    public string? MaterialType { get; set; }
    public decimal? UnitCost { get; set; }
    public string? CoverText { get; set; }
    public decimal? ParentSheetLength { get; set; }
    public decimal? ParentSheetWidth { get; set; }
    public decimal? BasisWeight { get; set; }
    public decimal? MWeight { get; set; }
    public decimal? Caliper { get; set; }
    public bool? Coated { get; set; }
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
    public string? ItemComment { get; set; }

}