namespace Midnight.SOAP.SDK.Models;

public class InventoryModel
{
    public List<Items>? Items { get; set; }
}

public class Items
{
    public int ItemID { get; set; } = 0;
    public int? CustomerID { get; set; } = 0;
    public bool Active { get; set; } = true;
    public string? CustomerName { get; set; } = string.Empty;
    public string? ItemTypeDescription { get; set; } = string.Empty;
    public string? ItemCode { get; set; } = string.Empty;
    public string? ItemName { get; set; } = string.Empty;
    public string? ItemDescription { get; set; } = string.Empty;
    public string? CustomerPartNumber { get; set; } = string.Empty;
    public string? VersionNumber { get; set; } = string.Empty;
    public string? Lot { get; set; } = string.Empty;
    public string? ExpirationDate { get; set; } = string.Empty;
    public bool Discontinued { get; set; } = false;
    public bool Kit { get; set; } = false;
    public bool Global { get; set; } = true;
    public string? UPCCode { get; set; } = string.Empty;
    public decimal? UnitValue { get; set; } = decimal.Zero;
    public string? UnitMeasureCode { get; set; } = string.Empty;
    public string? UnitMeasureName { get; set; } = string.Empty;
    public int? ReOrderPoint { get; set; } = 0;
    public int? ReOrderQuantity { get; set; } = 0;
    public string? LeadTime { get; set; } = "30";
    public string? DefaultQuantityPerContainer { get; set; } = "0";
    public bool POItem { get; set; } = false;
    public bool PrintOnDemand { get; set; } = false;
    public bool DigitalAsset { get; set; } = false;
    public bool Serialized { get; set; } = false;
    public string? Vendor { get; set; } = string.Empty;
    public string? Color { get; set; } = string.Empty;
    public decimal? UnitCost { get; set; } = decimal.Zero;
    public decimal? ParentSheetLength { get; set; } = decimal.Zero;
    public decimal? ParentSheetWidth { get; set; } = decimal.Zero;
    public decimal? BasisWeight { get; set; } = decimal.Zero;
    public decimal? MWeight { get; set; } = decimal.Zero;
    public decimal? Caliper { get; set; } = decimal.Zero;
    public bool Coated { get; set; } = false;
    public decimal? CostPerCwt { get; set; } = decimal.Zero;
    public decimal? CostPerMSheets { get; set; } = decimal.Zero;
    public decimal? PaperWeight { get; set; } = decimal.Zero;
    public decimal? PaperMarkup { get; set; } = decimal.Zero;
    public decimal? WeightPerSqFt { get; set; } = decimal.Zero;
    public decimal? ParentRollLength { get; set; } = decimal.Zero;
    public decimal? ParentRollWidth { get; set; } = decimal.Zero;
    public decimal? RollWeight { get; set; } = decimal.Zero;
    public decimal? CostPerPound { get; set; } = decimal.Zero;
    public int? ItemQuantity { get; set; } = 0;
    public int? OnHandQuantity { get; set; } = 0;
    public int? ReservedQuantity { get; set; } = 0;
    public string? ItemComment { get; set; } = string.Empty;

    // UDF 1 - 30 not currently in use for anything

    public string? CreateDateTime { get; set; } = string.Empty;

    public List<Lots>? Lots { get; set; }
    public List<Locations>? Locations { get; set; }
}

public class Lots
{
    public int ItemLotID { get; set; } = 0;
    public string? ItemLotNumber { get; set; } = string.Empty;
    public int? ItemID { get; set; } = 0;
    public int? VendorID { get; set; } = 0;
    public string? VendorName { get; set; } = string.Empty;
    public string? InvoiceNumber { get; set; } = string.Empty;
    public string? EnterDate { get; set; } = string.Empty;
    public decimal? ItemCost { get; set; } = decimal.Zero;
    public string? ExpirationDate { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
    public decimal? Weight { get; set; } = decimal.Zero;
    public decimal? TareWeight { get; set; } = decimal.Zero;
    public int? Quantity { get; set; } = 0;
}

public class Locations
{
    public int ItemID { get; set; } = 0;
    public string? ItemCode { get; set; } = string.Empty;
    public int? ItemLotID { get; set; } = 0;
    public string? ItemLotNumber { get; set; } = string.Empty;
    public int? WarehouseID { get; set; } = 0;
    public string? WarehouseName { get; set; } = string.Empty;
    public int? WarehouseLocationID { get; set; } = 0;
    public string? WarehouseLocationDescription { get; set; } = string.Empty;
    public int? Quantity { get; set; } = 0;
}

public class Receipts
{

}

public class Transactions
{

}

public class Substitutes
{

}
