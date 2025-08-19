using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionUpdate")]
public class OrderVersionUpdateRequestBody
{
    public required OrderVersionUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionUpdateInputParameter : UserDefinedFields
{
    public required int VersionID { get; set; }
    public string? VersionName { get; set; } = null;
    public int? Quantity { get; set; } = null;
    public string? DPInStartDate { get; set; } = null;
    public string? DPOutDate { get; set; } = null;
    public string? DPOutTime { get; set; } = null;
    public int? PODrop { get; set; } = null;
    public decimal? Weight { get; set; } = null;
    public decimal? Thickness { get; set; } = null;
    public decimal? Height { get; set; } = null;
    public decimal? Width { get; set; } = null;
    public int? CanadianRecords { get; set; } = null;
    public int? ForeignRecords { get; set; } = null;
    public int? Unmailables { get; set; } = null;
    public int? ActualBilled { get; set; } = null;
    public string? DPInitials { get; set; } = null;
    public string? DataCheckedDate { get; set; } = null;
    public int? DPActualQuantity { get; set; } = null;
    public int? MailSort { get; set; } = null;
    public int? MailClass { get; set; } = null;
    public string? PostageAffix { get; set; } = null;
    public decimal? PostageRequired { get; set; } = null;
    public string? MailGeography { get; set; } = null;
    public string? MailCategory { get; set; } = null;
    public string? PermitNumber { get; set; } = null;
    public string? PostageDue { get; set; } = null;
    public string? GhostCode { get; set; } = null;
    public string? NonProfitAuthCode { get; set; } = null;
    public string? PermitHolder { get; set; } = null;
    public int? PostageStatus { get; set; } = null;
    public string? MailerCode { get; set; } = null;
    public string? CustRegCode { get; set; } = null;
    public string? MeterNumber { get; set; } = null;
    public int? OrderVersionStatus { get; set; } = null;
    public int? VersionJobType { get; set; } = null;
    public string? Comment { get; set; } = null;
    public int? UrgencyID { get; set; } = null;
}