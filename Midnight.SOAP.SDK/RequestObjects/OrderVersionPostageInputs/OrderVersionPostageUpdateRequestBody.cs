using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for updating an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageUpdate")]
public class OrderVersionPostageUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage update request.
    /// </summary>
    public required OrderVersionPostageUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version postage in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageUpdateInputParameter
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public required int OrderVersionPostageID { get; set; }

    /// <summary>Gets or sets the postage affix ID.</summary>
    public int? PostageAffixID { get; set; }
    public bool ShouldSerializePostageAffixID() => PostageAffixID.HasValue;

    /// <summary>Gets or sets the postage affix name.</summary>
    public string? PostageAffixName { get; set; }
    public bool ShouldSerializePostageAffixName() => IsSet(PostageAffixName);

    /// <summary>Gets or sets the postage quantity.</summary>
    public int? PostageQuantity { get; set; }
    public bool ShouldSerializePostageQuantity() => PostageQuantity.HasValue;

    /// <summary>Gets or sets the postage rate.</summary>
    public decimal? PostageRate { get; set; }
    public bool ShouldSerializePostageRate() => PostageRate.HasValue;

    /// <summary>Gets or sets the postage total.</summary>
    public decimal? PostageTotal { get; set; }
    public bool ShouldSerializePostageTotal() => PostageTotal.HasValue;

    /// <summary>Gets or sets the date used.</summary>
    public string? DateUsed { get; set; }
    public bool ShouldSerializeDateUsed() => IsSet(DateUsed);

    /// <summary>Gets or sets the mail class ID.</summary>
    public int? MailClassID { get; set; }
    public bool ShouldSerializeMailClassID() => MailClassID.HasValue;

    /// <summary>Gets or sets the total weight.</summary>
    public decimal? TotalWeight { get; set; }
    public bool ShouldSerializeTotalWeight() => TotalWeight.HasValue;

    /// <summary>Gets or sets the form number.</summary>
    public string? FormNo { get; set; }
    public bool ShouldSerializeFormNo() => IsSet(FormNo);

    /// <summary>Gets or sets the lot.</summary>
    public string? Lot { get; set; }
    public bool ShouldSerializeLot() => IsSet(Lot);

    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNo { get; set; }
    public bool ShouldSerializePermitNo() => IsSet(PermitNo);

    /// <summary>Gets or sets the non-profit information.</summary>
    public string? NonProfit { get; set; }
    public bool ShouldSerializeNonProfit() => IsSet(NonProfit);

    /// <summary>Gets or sets the post office.</summary>
    public string? PostOffice { get; set; }
    public bool ShouldSerializePostOffice() => IsSet(PostOffice);

    /// <summary>Gets or sets the post office city.</summary>
    public string? POCity { get; set; }
    public bool ShouldSerializePOCity() => IsSet(POCity);

    /// <summary>Gets or sets the post office zip code.</summary>
    public string? POZip { get; set; }
    public bool ShouldSerializePOZip() => IsSet(POZip);

    /// <summary>Gets or sets the weight status.</summary>
    public string? WTStatus { get; set; }
    public bool ShouldSerializeWTStatus() => IsSet(WTStatus);

    /// <summary>Gets or sets the processing category.</summary>
    public int? ProcessingCategory { get; set; }
    public bool ShouldSerializeProcessingCategory() => ProcessingCategory.HasValue;

    /// <summary>Gets or sets the FTtr1 value.</summary>
    public string? FTtr1 { get; set; }
    public bool ShouldSerializeFTtr1() => IsSet(FTtr1);

    /// <summary>Gets or sets the FTtr2 value.</summary>
    public string? FTtr2 { get; set; }
    public bool ShouldSerializeFTtr2() => IsSet(FTtr2);

    /// <summary>Gets or sets the number of sacks.</summary>
    public int? Sacks { get; set; }
    public bool ShouldSerializeSacks() => Sacks.HasValue;

    /// <summary>Gets or sets the number of pallets.</summary>
    public int? Pallets { get; set; }
    public bool ShouldSerializePallets() => Pallets.HasValue;

    /// <summary>Gets or sets the flat tray value.</summary>
    public string? FlatTr { get; set; }
    public bool ShouldSerializeFlatTr() => IsSet(FlatTr);

    /// <summary>Gets or sets other information.</summary>
    public string? Other { get; set; }
    public bool ShouldSerializeOther() => IsSet(Other);

    /// <summary>Gets or sets the tare weight.</summary>
    public decimal? TareWt { get; set; }
    public bool ShouldSerializeTareWt() => TareWt.HasValue;

    /// <summary>Gets or sets a value indicating whether the postage is precanceled.</summary>
    public bool? Precanceled { get; set; }
    public bool ShouldSerializePrecanceled() => Precanceled.HasValue;

    /// <summary>Gets or sets the postage markup type.</summary>
    public string? PostageMarkupType { get; set; }
    public bool ShouldSerializePostageMarkupType() => IsSet(PostageMarkupType);

    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; }
    public bool ShouldSerializePostageMarkupValue() => PostageMarkupValue.HasValue;

    /// <summary>Gets or sets the postage sell rate.</summary>
    public decimal? PostageSellRate { get; set; }
    public bool ShouldSerializePostageSellRate() => PostageSellRate.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}