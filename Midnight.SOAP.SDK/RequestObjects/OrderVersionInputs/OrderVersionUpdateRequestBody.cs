using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for updating an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionUpdate")]
public class OrderVersionUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version update request.
    /// </summary>
    public required OrderVersionUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionUpdateInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }

    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; }
    public bool ShouldSerializeVersionName() => IsSet(VersionName);

    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; }
    public bool ShouldSerializeQuantity() => Quantity.HasValue;

    /// <summary>Gets or sets the DP in start date.</summary>
    public string? DPInStartDate { get; set; }
    public bool ShouldSerializeDPInStartDate() => IsSet(DPInStartDate);

    /// <summary>Gets or sets the DP out date.</summary>
    public string? DPOutDate { get; set; }
    public bool ShouldSerializeDPOutDate() => IsSet(DPOutDate);

    /// <summary>Gets or sets the DP out time.</summary>
    public string? DPOutTime { get; set; }
    public bool ShouldSerializeDPOutTime() => IsSet(DPOutTime);

    /// <summary>Gets or sets the PO drop.</summary>
    public int? PODrop { get; set; }
    public bool ShouldSerializePODrop() => PODrop.HasValue;

    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; }
    public bool ShouldSerializeWeight() => Weight.HasValue;

    /// <summary>Gets or sets the thickness.</summary>
    public decimal? Thickness { get; set; }
    public bool ShouldSerializeThickness() => Thickness.HasValue;

    /// <summary>Gets or sets the height.</summary>
    public decimal? Height { get; set; }
    public bool ShouldSerializeHeight() => Height.HasValue;

    /// <summary>Gets or sets the width.</summary>
    public decimal? Width { get; set; }
    public bool ShouldSerializeWidth() => Width.HasValue;

    /// <summary>Gets or sets the number of Canadian records.</summary>
    public int? CanadianRecords { get; set; }
    public bool ShouldSerializeCanadianRecords() => CanadianRecords.HasValue;

    /// <summary>Gets or sets the number of foreign records.</summary>
    public int? ForeignRecords { get; set; }
    public bool ShouldSerializeForeignRecords() => ForeignRecords.HasValue;

    /// <summary>Gets or sets the number of unmailables.</summary>
    public int? Unmailables { get; set; }
    public bool ShouldSerializeUnmailables() => Unmailables.HasValue;

    /// <summary>Gets or sets the actual billed value.</summary>
    public int? ActualBilled { get; set; }
    public bool ShouldSerializeActualBilled() => ActualBilled.HasValue;

    /// <summary>Gets or sets the DP initials.</summary>
    public string? DPInitials { get; set; }
    public bool ShouldSerializeDPInitials() => IsSet(DPInitials);

    /// <summary>Gets or sets the data checked date.</summary>
    public string? DataCheckedDate { get; set; }
    public bool ShouldSerializeDataCheckedDate() => IsSet(DataCheckedDate);

    /// <summary>Gets or sets the DP actual quantity.</summary>
    public int? DPActualQuantity { get; set; }
    public bool ShouldSerializeDPActualQuantity() => DPActualQuantity.HasValue;

    /// <summary>Gets or sets the mail sort.</summary>
    public int? MailSort { get; set; }
    public bool ShouldSerializeMailSort() => MailSort.HasValue;

    /// <summary>Gets or sets the mail class.</summary>
    public int? MailClass { get; set; }
    public bool ShouldSerializeMailClass() => MailClass.HasValue;

    /// <summary>Gets or sets the postage affix.</summary>
    public string? PostageAffix { get; set; }
    public bool ShouldSerializePostageAffix() => IsSet(PostageAffix);

    /// <summary>Gets or sets the postage required.</summary>
    public decimal? PostageRequired { get; set; }
    public bool ShouldSerializePostageRequired() => PostageRequired.HasValue;

    /// <summary>Gets or sets the mail geography.</summary>
    public string? MailGeography { get; set; }
    public bool ShouldSerializeMailGeography() => IsSet(MailGeography);

    /// <summary>Gets or sets the mail category.</summary>
    public string? MailCategory { get; set; }
    public bool ShouldSerializeMailCategory() => IsSet(MailCategory);

    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNumber { get; set; }
    public bool ShouldSerializePermitNumber() => IsSet(PermitNumber);

    /// <summary>Gets or sets the postage due.</summary>
    public string? PostageDue { get; set; }
    public bool ShouldSerializePostageDue() => IsSet(PostageDue);

    /// <summary>Gets or sets the ghost code.</summary>
    public string? GhostCode { get; set; }
    public bool ShouldSerializeGhostCode() => IsSet(GhostCode);

    /// <summary>Gets or sets the non-profit authorization code.</summary>
    public string? NonProfitAuthCode { get; set; }
    public bool ShouldSerializeNonProfitAuthCode() => IsSet(NonProfitAuthCode);

    /// <summary>Gets or sets the permit holder.</summary>
    public string? PermitHolder { get; set; }
    public bool ShouldSerializePermitHolder() => IsSet(PermitHolder);

    /// <summary>Gets or sets the postage status.</summary>
    public int? PostageStatus { get; set; }
    public bool ShouldSerializePostageStatus() => PostageStatus.HasValue;

    /// <summary>Gets or sets the mailer code.</summary>
    public string? MailerCode { get; set; }
    public bool ShouldSerializeMailerCode() => IsSet(MailerCode);

    /// <summary>Gets or sets the customer registration code.</summary>
    public string? CustRegCode { get; set; }
    public bool ShouldSerializeCustRegCode() => IsSet(CustRegCode);

    /// <summary>Gets or sets the meter number.</summary>
    public string? MeterNumber { get; set; }
    public bool ShouldSerializeMeterNumber() => IsSet(MeterNumber);

    /// <summary>Gets or sets the order version status.</summary>
    public int? OrderVersionStatus { get; set; }
    public bool ShouldSerializeOrderVersionStatus() => OrderVersionStatus.HasValue;

    /// <summary>Gets or sets the version job type.</summary>
    public int? VersionJobType { get; set; }
    public bool ShouldSerializeVersionJobType() => VersionJobType.HasValue;

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Gets or sets the urgency ID.</summary>
    public int? UrgencyID { get; set; }
    public bool ShouldSerializeUrgencyID() => UrgencyID.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}