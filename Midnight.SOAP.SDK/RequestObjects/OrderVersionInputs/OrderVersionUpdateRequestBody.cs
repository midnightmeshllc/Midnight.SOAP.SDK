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
    public string? VersionName { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; } = null;
    /// <summary>Gets or sets the DP in start date.</summary>
    public string? DPInStartDate { get; set; } = null;
    /// <summary>Gets or sets the DP out date.</summary>
    public string? DPOutDate { get; set; } = null;
    /// <summary>Gets or sets the DP out time.</summary>
    public string? DPOutTime { get; set; } = null;
    /// <summary>Gets or sets the PO drop.</summary>
    public int? PODrop { get; set; } = null;
    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; } = null;
    /// <summary>Gets or sets the thickness.</summary>
    public decimal? Thickness { get; set; } = null;
    /// <summary>Gets or sets the height.</summary>
    public decimal? Height { get; set; } = null;
    /// <summary>Gets or sets the width.</summary>
    public decimal? Width { get; set; } = null;
    /// <summary>Gets or sets the number of Canadian records.</summary>
    public int? CanadianRecords { get; set; } = null;
    /// <summary>Gets or sets the number of foreign records.</summary>
    public int? ForeignRecords { get; set; } = null;
    /// <summary>Gets or sets the number of unmailables.</summary>
    public int? Unmailables { get; set; } = null;
    /// <summary>Gets or sets the actual billed value.</summary>
    public int? ActualBilled { get; set; } = null;
    /// <summary>Gets or sets the DP initials.</summary>
    public string? DPInitials { get; set; } = null;
    /// <summary>Gets or sets the data checked date.</summary>
    public string? DataCheckedDate { get; set; } = null;
    /// <summary>Gets or sets the DP actual quantity.</summary>
    public int? DPActualQuantity { get; set; } = null;
    /// <summary>Gets or sets the mail sort.</summary>
    public int? MailSort { get; set; } = null;
    /// <summary>Gets or sets the mail class.</summary>
    public int? MailClass { get; set; } = null;
    /// <summary>Gets or sets the postage affix.</summary>
    public string? PostageAffix { get; set; } = null;
    /// <summary>Gets or sets the postage required.</summary>
    public decimal? PostageRequired { get; set; } = null;
    /// <summary>Gets or sets the mail geography.</summary>
    public string? MailGeography { get; set; } = null;
    /// <summary>Gets or sets the mail category.</summary>
    public string? MailCategory { get; set; } = null;
    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNumber { get; set; } = null;
    /// <summary>Gets or sets the postage due.</summary>
    public string? PostageDue { get; set; } = null;
    /// <summary>Gets or sets the ghost code.</summary>
    public string? GhostCode { get; set; } = null;
    /// <summary>Gets or sets the non-profit authorization code.</summary>
    public string? NonProfitAuthCode { get; set; } = null;
    /// <summary>Gets or sets the permit holder.</summary>
    public string? PermitHolder { get; set; } = null;
    /// <summary>Gets or sets the postage status.</summary>
    public int? PostageStatus { get; set; } = null;
    /// <summary>Gets or sets the mailer code.</summary>
    public string? MailerCode { get; set; } = null;
    /// <summary>Gets or sets the customer registration code.</summary>
    public string? CustRegCode { get; set; } = null;
    /// <summary>Gets or sets the meter number.</summary>
    public string? MeterNumber { get; set; } = null;
    /// <summary>Gets or sets the order version status.</summary>
    public int? OrderVersionStatus { get; set; } = null;
    /// <summary>Gets or sets the version job type.</summary>
    public int? VersionJobType { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
    /// <summary>Gets or sets the urgency ID.</summary>
    public int? UrgencyID { get; set; } = null;
}