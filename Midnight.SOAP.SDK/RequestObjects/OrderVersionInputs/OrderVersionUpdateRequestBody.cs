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
    [XmlElement(IsNullable = true)]
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? Quantity { get; set; }
    /// <summary>Gets or sets the DP in start date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DPInStartDate { get; set; }
    /// <summary>Gets or sets the DP out date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DPOutDate { get; set; }
    /// <summary>Gets or sets the DP out time.</summary>
    [XmlElement(IsNullable = true)]
    public string? DPOutTime { get; set; }
    /// <summary>Gets or sets the PO drop.</summary>
    [XmlElement(IsNullable = true)]
    public int? PODrop { get; set; }
    /// <summary>Gets or sets the weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Weight { get; set; }
    /// <summary>Gets or sets the thickness.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Thickness { get; set; }
    /// <summary>Gets or sets the height.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Height { get; set; }
    /// <summary>Gets or sets the width.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Width { get; set; }
    /// <summary>Gets or sets the number of Canadian records.</summary>
    [XmlElement(IsNullable = true)]
    public int? CanadianRecords { get; set; }
    /// <summary>Gets or sets the number of foreign records.</summary>
    [XmlElement(IsNullable = true)]
    public int? ForeignRecords { get; set; }
    /// <summary>Gets or sets the number of unmailables.</summary>
    [XmlElement(IsNullable = true)]
    public int? Unmailables { get; set; }
    /// <summary>Gets or sets the actual billed value.</summary>
    [XmlElement(IsNullable = true)]
    public int? ActualBilled { get; set; }
    /// <summary>Gets or sets the DP initials.</summary>
    [XmlElement(IsNullable = true)]
    public string? DPInitials { get; set; }
    /// <summary>Gets or sets the data checked date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DataCheckedDate { get; set; }
    /// <summary>Gets or sets the DP actual quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? DPActualQuantity { get; set; }
    /// <summary>Gets or sets the mail sort.</summary>
    [XmlElement(IsNullable = true)]
    public int? MailSort { get; set; }
    /// <summary>Gets or sets the mail class.</summary>
    [XmlElement(IsNullable = true)]
    public int? MailClass { get; set; }
    /// <summary>Gets or sets the postage affix.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageAffix { get; set; }
    /// <summary>Gets or sets the postage required.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageRequired { get; set; }
    /// <summary>Gets or sets the mail geography.</summary>
    [XmlElement(IsNullable = true)]
    public string? MailGeography { get; set; }
    /// <summary>Gets or sets the mail category.</summary>
    [XmlElement(IsNullable = true)]
    public string? MailCategory { get; set; }
    /// <summary>Gets or sets the permit number.</summary>
    [XmlElement(IsNullable = true)]
    public string? PermitNumber { get; set; }
    /// <summary>Gets or sets the postage due.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageDue { get; set; }
    /// <summary>Gets or sets the ghost code.</summary>
    [XmlElement(IsNullable = true)]
    public string? GhostCode { get; set; }
    /// <summary>Gets or sets the non-profit authorization code.</summary>
    [XmlElement(IsNullable = true)]
    public string? NonProfitAuthCode { get; set; }
    /// <summary>Gets or sets the permit holder.</summary>
    [XmlElement(IsNullable = true)]
    public string? PermitHolder { get; set; }
    /// <summary>Gets or sets the postage status.</summary>
    [XmlElement(IsNullable = true)]
    public int? PostageStatus { get; set; }
    /// <summary>Gets or sets the mailer code.</summary>
    [XmlElement(IsNullable = true)]
    public string? MailerCode { get; set; }
    /// <summary>Gets or sets the customer registration code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustRegCode { get; set; }
    /// <summary>Gets or sets the meter number.</summary>
    [XmlElement(IsNullable = true)]
    public string? MeterNumber { get; set; }
    /// <summary>Gets or sets the order version status.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderVersionStatus { get; set; }
    /// <summary>Gets or sets the version job type.</summary>
    [XmlElement(IsNullable = true)]
    public int? VersionJobType { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comment { get; set; }
    /// <summary>Gets or sets the urgency ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? UrgencyID { get; set; }
}