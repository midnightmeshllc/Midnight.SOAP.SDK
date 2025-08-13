
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

[XmlRoot("Result")]
public class OrderVersionListResult : CommonResult
{
    [XmlArray("OrderVersions")]
    [XmlArrayItem("OrderVersion")]
    public List<OrderVersion> OrderVersions { get; set; } = new List<OrderVersion>();
}

public class OrderVersion : OrderVersion_UserDefinedFields
{
    public int? VersionID { get; set; }
    public int? OrderID { get; set; }
    public int? Suffix { get; set; }
    public int? Quantity { get; set; }
    public string? VersionName { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? TaxAmt { get; set; }
    public decimal? Postage { get; set; }
    public decimal? TotalDue { get; set; }
    public int? MailGeographyID { get; set; }
    public string? MailGeographyName { get; set; }
    public int? MailSortID { get; set; }
    public string? MailSortName { get; set; }
    public int? MailClassID { get; set; }
    public string? MailClassName { get; set; }
    public int? MailCategoryID { get; set; }
    public string? MailCategoryName { get; set; }
    public int? PostOfficeID { get; set; }
    public string? PostOfficeName { get; set; }
    public int? PostageAffixID { get; set; }
    public string? PostageAffixName { get; set; }
    public string? PermitNumber { get; set; }
    public string? PermitHolder { get; set; }
    public string? MeterNumber { get; set; }
    public decimal? PostageRequired { get; set; }
    public string? PostageDue { get; set; }
    public int? PostageStatusID { get; set; }
    public string? DataProcessingOutTime { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Thickness { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public int? DataProcessingStatusID { get; set; }
    public string? DataProcessingStatusName { get; set; }
    public int? DataProcessingActualQuantity { get; set; }
    public decimal? DataProcessingActualBilled { get; set; }
    public string? VersionDropDate { get; set; }
    public int? VersionDropQuantity { get; set; }
    public string? VersionDropName { get; set; }
    public string? VersionDropActualDate { get; set; }
    public int? CanadianRecordsID { get; set; }
    public string? CanadianRecordsName { get; set; }
    public int? ForeignRecordsID { get; set; }
    public string? ForeignRecordsName { get; set; }
    public int? UnmailablesID { get; set; }
    public string? UnmailablesName { get; set; }
    public string? VersionComment { get; set; }
    public string? DPInStartDate { get; set; }
    public string? DPOutDate { get; set; }
    public string? DPInitials { get; set; }
    public string? DataCheckedDate { get; set; }
    public string? GhostCode { get; set; }
    public string? nonProfitAuthCode { get; set; }
    public string? MailerCode { get; set; }
    public string? CustRegCode { get; set; }
}