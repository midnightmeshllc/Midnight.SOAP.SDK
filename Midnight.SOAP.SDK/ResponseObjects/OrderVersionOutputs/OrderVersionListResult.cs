using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

/// <summary>
/// Represents the result of a list request for order versions in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order versions returned by the request.
    /// </summary>
    [XmlArray("OrderVersions")]
    [XmlArrayItem("OrderVersion")]
    public List<OrderVersion> OrderVersions { get; set; } = new List<OrderVersion>();
}

/// <summary>
/// Represents an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersion : OrderVersion_UserDefinedFields
{
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the suffix.</summary>
    public int? Suffix { get; set; }
    /// <summary> Gets or sets the identifier representing the urgency level. </summary>
    public int? UrgencyID { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; }
    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the subtotal.</summary>
    public decimal? SubTotal { get; set; }
    /// <summary>Gets or sets the tax amount.</summary>
    public decimal? TaxAmt { get; set; }
    /// <summary>Gets or sets the postage.</summary>
    public decimal? Postage { get; set; }
    /// <summary>Gets or sets the total due.</summary>
    public decimal? TotalDue { get; set; }
    /// <summary>Gets or sets the mail geography ID.</summary>
    public int? MailGeographyID { get; set; }
    /// <summary>Gets or sets the mail geography name.</summary>
    public string? MailGeographyName { get; set; }
    /// <summary>Gets or sets the mail sort ID.</summary>
    public int? MailSortID { get; set; }
    /// <summary>Gets or sets the mail sort name.</summary>
    public string? MailSortName { get; set; }
    /// <summary>Gets or sets the mail class ID.</summary>
    public int? MailClassID { get; set; }
    /// <summary>Gets or sets the mail class name.</summary>
    public string? MailClassName { get; set; }
    /// <summary>Gets or sets the mail category ID.</summary>
    public int? MailCategoryID { get; set; }
    /// <summary>Gets or sets the mail category name.</summary>
    public string? MailCategoryName { get; set; }
    /// <summary>Gets or sets the post office ID.</summary>
    public int? PostOfficeID { get; set; }
    /// <summary>Gets or sets the post office name.</summary>
    public string? PostOfficeName { get; set; }
    /// <summary>Gets or sets the postage affix ID.</summary>
    public int? PostageAffixID { get; set; }
    /// <summary>Gets or sets the postage affix name.</summary>
    public string? PostageAffixName { get; set; }
    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNumber { get; set; }
    /// <summary>Gets or sets the permit holder.</summary>
    public string? PermitHolder { get; set; }
    /// <summary>Gets or sets the meter number.</summary>
    public string? MeterNumber { get; set; }
    /// <summary>Gets or sets the postage required.</summary>
    public decimal? PostageRequired { get; set; }
    /// <summary>Gets or sets the postage due.</summary>
    public string? PostageDue { get; set; }
    /// <summary>Gets or sets the postage status ID.</summary>
    public int? PostageStatusID { get; set; }
    /// <summary>Gets or sets the data processing out time.</summary>
    public string? DataProcessingOutTime { get; set; }
    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; }
    /// <summary>Gets or sets the thickness.</summary>
    public decimal? Thickness { get; set; }
    /// <summary>Gets or sets the height.</summary>
    public decimal? Height { get; set; }
    /// <summary>Gets or sets the width.</summary>
    public decimal? Width { get; set; }
    /// <summary>Gets or sets the data processing status ID.</summary>
    public int? DataProcessingStatusID { get; set; }
    /// <summary>Gets or sets the data processing status name.</summary>
    public string? DataProcessingStatusName { get; set; }
    /// <summary>Gets or sets the data processing actual quantity.</summary>
    public int? DataProcessingActualQuantity { get; set; }
    /// <summary>Gets or sets the data processing actual billed amount.</summary>
    public decimal? DataProcessingActualBilled { get; set; }
    /// <summary>Gets or sets the version drop date.</summary>
    public string? VersionDropDate { get; set; }
    /// <summary>Gets or sets the version drop quantity.</summary>
    public int? VersionDropQuantity { get; set; }
    /// <summary>Gets or sets the version drop name.</summary>
    public string? VersionDropName { get; set; }
    /// <summary>Gets or sets the version drop actual date.</summary>
    public string? VersionDropActualDate { get; set; }
    /// <summary>Gets or sets the Canadian records ID.</summary>
    public int? CanadianRecordsID { get; set; }
    /// <summary>Gets or sets the Canadian records name.</summary>
    public string? CanadianRecordsName { get; set; }
    /// <summary>Gets or sets the foreign records ID.</summary>
    public int? ForeignRecordsID { get; set; }
    /// <summary>Gets or sets the foreign records name.</summary>
    public string? ForeignRecordsName { get; set; }
    /// <summary>Gets or sets the unmailables ID.</summary>
    public int? UnmailablesID { get; set; }
    /// <summary>Gets or sets the unmailables name.</summary>
    public string? UnmailablesName { get; set; }
    /// <summary>Gets or sets the version comment.</summary>
    public string? VersionComment { get; set; }
    /// <summary>Gets or sets the DP in start date.</summary>
    public string? DPInStartDate { get; set; }
    /// <summary>Gets or sets the DP out date.</summary>
    public string? DPOutDate { get; set; }
    /// <summary>Gets or sets the DP initials.</summary>
    public string? DPInitials { get; set; }
    /// <summary>Gets or sets the data checked date.</summary>
    public string? DataCheckedDate { get; set; }
    /// <summary>Gets or sets the ghost code.</summary>
    public string? GhostCode { get; set; }
    /// <summary>Gets or sets the non-profit authorization code.</summary>
    public string? nonProfitAuthCode { get; set; }
    /// <summary>Gets or sets the mailer code.</summary>
    public string? MailerCode { get; set; }
    /// <summary>Gets or sets the customer registration code.</summary>
    public string? CustRegCode { get; set; }
}