using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionUpdate")]
public class OrderVersionUpdateRequestBody
{
    public required OrderVersionUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionUpdateInputParameter
{
    public int VersionID { get; set; }
    public string? VersionName { get; set; }
    public int? Quantity { get; set; }
    public string? DPInStartDate { get; set; }
    public string? DPOutDate { get; set; }
    public string? DPOutTime { get; set; }
    public int? PODrop { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Thickness { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public int? CanadianRecords { get; set; }
    public int? ForeignRecords { get; set; }
    public int? Unmailables { get; set; }
    public int? ActualBilled { get; set; }
    public string? DPInitials { get; set; }
    public string? DataCheckedDate { get; set; }
    public int? DPActualQuantity { get; set; }
    public int? MailSort { get; set; }
    public int? MailClass { get; set; }
    public int? PostageAffix { get; set; }
    public decimal? PostageRequired { get; set; }
    public int? MailGeography { get; set; }
    public int? MailCategory { get; set; }
    public string? PermitNumber { get; set; }
    public string? PostageDue { get; set; }
    public string? GhostCode { get; set; }
    public string? NonProfitAuthCode { get; set; }
    public string? PermitHolder { get; set; }
    public int? PostageStatus { get; set; }
    public string? MailerCode { get; set; }
    public string? CustRegCode { get; set; }
    public string? MeterNumber { get; set; }
    public int? OrderVersionStatus { get; set; }
    public int? VersionJobType { get; set; }
    public string? Comment { get; set; }
    public int? UrgencyID { get; set; }
}