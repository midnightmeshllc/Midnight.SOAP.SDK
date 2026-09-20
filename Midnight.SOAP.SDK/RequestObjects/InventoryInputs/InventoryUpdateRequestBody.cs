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
    public string? ItemTypeName { get; set; }
    public bool ShouldSerializeItemTypeName() => IsSet(ItemTypeName);

    /// <summary>Gets or sets the item name.</summary>
    public string? ItemName { get; set; }
    public bool ShouldSerializeItemName() => IsSet(ItemName);

    /// <summary>Gets or sets the item description.</summary>
    public string? ItemDescription { get; set; }
    public bool ShouldSerializeItemDescription() => IsSet(ItemDescription);

    /// <summary>Gets or sets the customer part number.</summary>
    public string? CustomerPartNumber { get; set; }
    public bool ShouldSerializeCustomerPartNumber() => IsSet(CustomerPartNumber);

    /// <summary>Gets or sets the version number.</summary>
    public string? VersionNumber { get; set; }
    public bool ShouldSerializeVersionNumber() => IsSet(VersionNumber);

    /// <summary>Gets or sets the lot.</summary>
    public string? Lot { get; set; }
    public bool ShouldSerializeLot() => IsSet(Lot);

    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; }
    public bool ShouldSerializeExpirationDate() => IsSet(ExpirationDate);

    /// <summary>Gets or sets a value indicating whether the item is discontinued.</summary>
    public bool? Discontinued { get; set; }
    public bool ShouldSerializeDiscontinued() => Discontinued.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is a kit.</summary>
    public bool? Kit { get; set; }
    public bool ShouldSerializeKit() => Kit.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is global.</summary>
    public bool? Global { get; set; }
    public bool ShouldSerializeGlobal() => Global.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is active.</summary>
    public bool? Active { get; set; }
    public bool ShouldSerializeActive() => Active.HasValue;

    /// <summary>Gets or sets the UPC code.</summary>
    public string? UPCCode { get; set; }
    public bool ShouldSerializeUPCCode() => IsSet(UPCCode);

    /// <summary>Gets or sets the unit value.</summary>
    public decimal? UnitValue { get; set; }
    public bool ShouldSerializeUnitValue() => UnitValue.HasValue;

    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; }
    public bool ShouldSerializeUnitMeasureCode() => IsSet(UnitMeasureCode);

    /// <summary>Gets or sets the reorder point.</summary>
    public int? ReOrderPoint { get; set; }
    public bool ShouldSerializeReOrderPoint() => ReOrderPoint.HasValue;

    /// <summary>Gets or sets the reorder quantity.</summary>
    public int? ReOrderQuantity { get; set; }
    public bool ShouldSerializeReOrderQuantity() => ReOrderQuantity.HasValue;

    /// <summary>Gets or sets the lead time.</summary>
    public int? LeadTime { get; set; }
    public bool ShouldSerializeLeadTime() => LeadTime.HasValue;

    /// <summary>Gets or sets the default quantity per container.</summary>
    public int? DefaultQuantityPerContainer { get; set; }
    public bool ShouldSerializeDefaultQuantityPerContainer() => DefaultQuantityPerContainer.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is a PO item.</summary>
    public bool? POItem { get; set; }
    public bool ShouldSerializePOItem() => POItem.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is print on demand.</summary>
    public bool? PrintOnDemand { get; set; }
    public bool ShouldSerializePrintOnDemand() => PrintOnDemand.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is a digital asset.</summary>
    public bool? DigitalAsset { get; set; }
    public bool ShouldSerializeDigitalAsset() => DigitalAsset.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is serialized.</summary>
    public bool? Serialized { get; set; }
    public bool ShouldSerializeSerialized() => Serialized.HasValue;

    /// <summary>Gets or sets the vendor.</summary>
    public string? Vendor { get; set; }
    public bool ShouldSerializeVendor() => IsSet(Vendor);

    /// <summary>Gets or sets the color.</summary>
    public string? Color { get; set; }
    public bool ShouldSerializeColor() => IsSet(Color);

    /// <summary>Gets or sets the material type.</summary>
    public string? MaterialType { get; set; }
    public bool ShouldSerializeMaterialType() => IsSet(MaterialType);

    /// <summary>Gets or sets the unit cost.</summary>
    public decimal? UnitCost { get; set; }
    public bool ShouldSerializeUnitCost() => UnitCost.HasValue;

    /// <summary>Gets or sets the cover text.</summary>
    public string? CoverText { get; set; }
    public bool ShouldSerializeCoverText() => IsSet(CoverText);

    /// <summary>Gets or sets the parent sheet length.</summary>
    public decimal? ParentSheetLength { get; set; }
    public bool ShouldSerializeParentSheetLength() => ParentSheetLength.HasValue;

    /// <summary>Gets or sets the parent sheet width.</summary>
    public decimal? ParentSheetWidth { get; set; }
    public bool ShouldSerializeParentSheetWidth() => ParentSheetWidth.HasValue;

    /// <summary>Gets or sets the basis weight.</summary>
    public decimal? BasisWeight { get; set; }
    public bool ShouldSerializeBasisWeight() => BasisWeight.HasValue;

    /// <summary>Gets or sets the M weight.</summary>
    public decimal? MWeight { get; set; }
    public bool ShouldSerializeMWeight() => MWeight.HasValue;

    /// <summary>Gets or sets the caliper.</summary>
    public decimal? Caliper { get; set; }
    public bool ShouldSerializeCaliper() => Caliper.HasValue;

    /// <summary>Gets or sets a value indicating whether the item is coated.</summary>
    public bool? Coated { get; set; }
    public bool ShouldSerializeCoated() => Coated.HasValue;

    /// <summary>Gets or sets the cost per CWT.</summary>
    public decimal? CostPerCwt { get; set; }
    public bool ShouldSerializeCostPerCwt() => CostPerCwt.HasValue;

    /// <summary>Gets or sets the cost per M sheets.</summary>
    public decimal? CostPerMSheets { get; set; }
    public bool ShouldSerializeCostPerMSheets() => CostPerMSheets.HasValue;

    /// <summary>Gets or sets the paper weight.</summary>
    public decimal? PaperWeight { get; set; }
    public bool ShouldSerializePaperWeight() => PaperWeight.HasValue;

    /// <summary>Gets or sets the paper markup.</summary>
    public decimal? PaperMarkup { get; set; }
    public bool ShouldSerializePaperMarkup() => PaperMarkup.HasValue;

    /// <summary>Gets or sets the weight per square foot.</summary>
    public decimal? WeightPerSqFt { get; set; }
    public bool ShouldSerializeWeightPerSqFt() => WeightPerSqFt.HasValue;

    /// <summary>Gets or sets the cost per square foot.</summary>
    public decimal? CostPerSqFt { get; set; }
    public bool ShouldSerializeCostPerSqFt() => CostPerSqFt.HasValue;

    /// <summary>Gets or sets the parent roll length.</summary>
    public decimal? ParentRollLength { get; set; }
    public bool ShouldSerializeParentRollLength() => ParentRollLength.HasValue;

    /// <summary>Gets or sets the parent roll width.</summary>
    public decimal? ParentRollWidth { get; set; }
    public bool ShouldSerializeParentRollWidth() => ParentRollWidth.HasValue;

    /// <summary>Gets or sets the roll weight.</summary>
    public decimal? RollWeight { get; set; }
    public bool ShouldSerializeRollWeight() => RollWeight.HasValue;

    /// <summary>Gets or sets the cost per pound.</summary>
    public decimal? CostPerPound { get; set; }
    public bool ShouldSerializeCostPerPound() => CostPerPound.HasValue;

    /// <summary>Gets or sets the item comment.</summary>
    public string? ItemComment { get; set; }
    public bool ShouldSerializeItemComment() => IsSet(ItemComment);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}