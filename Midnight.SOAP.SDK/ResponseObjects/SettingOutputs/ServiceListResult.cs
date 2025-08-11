
using Midnight.SOAP.SDK.CommonObjects;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class ServiceListResult : CommonResult
{
    [XmlArray("Services")]
    [XmlArrayItem("Service")]
    public List<ServiceSetting> Services { get; set; } = new List<ServiceSetting>();
}

public class ServiceSetting
{
    public int? ServiceID { get; set; }
    public int? ServiceTypeID { get; set; }
    public string? ServiceTypeName { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }

    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    [XmlIgnore]
    public bool Taxable
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TaxableRaw)) return false;
            return string.Equals(TaxableRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TaxableRaw == "1";
        }
    }

    public decimal? Price { get; set; }
    public decimal? MinimumPrice { get; set; }
    public decimal? RunRate { get; set; }
    public int? WizardNumber { get; set; }
    public int? MachineDepartmentID { get; set; }
    public string? MachineDepartmentName { get; set; }
    public string? GLID { get; set; }
    public string? ItemCode { get; set; }

    [XmlElement("Schedule")]
    public string? ScheduleRaw { get; set; }
    [XmlIgnore]
    public bool Schedule
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ScheduleRaw)) return false;
            return string.Equals(ScheduleRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ScheduleRaw == "1";
        }
    }

    public int? ScheduleDays { get; set; }

    [XmlElement("Outside")]
    public string? OutsideRaw { get; set; }
    [XmlIgnore]
    public bool Outside
    {
        get
        {
            if (string.IsNullOrWhiteSpace(OutsideRaw)) return false;
            return string.Equals(OutsideRaw, "true", StringComparison.OrdinalIgnoreCase)
                || OutsideRaw == "1";
        }
    }

    public string? ItemizationCode { get; set; }

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

    public string? SizeDescr { get; set; }
    public decimal? LaborRate { get; set; }
    public decimal? MaterialRate { get; set; }
    public decimal? RunRateCost { get; set; }
    public decimal? MakeReadyHrs { get; set; }
    public decimal? MakeReadyCost { get; set; }
    public decimal? FoldFinishedSize { get; set; }
    public decimal? FoldTravelDirection { get; set; }
    public decimal? FoldGap { get; set; }
    public int? FoldFtPerHr { get; set; }

    [XmlElement("CostService")]
    public string? CostServiceRaw { get; set; }
    [XmlIgnore]
    public bool CostService
    {
        get
        {
            if (string.IsNullOrWhiteSpace(CostServiceRaw)) return false;
            return string.Equals(CostServiceRaw, "true", StringComparison.OrdinalIgnoreCase)
                || CostServiceRaw == "1";
        }
    }

    public int? CostServiceTypeID { get; set; }
    public string? CostServiceTypeName { get; set; }

    [XmlElement("PrintService")]
    public string? PrintServiceRaw { get; set; }
    [XmlIgnore]
    public bool PrintService
    {
        get
        {
            if (string.IsNullOrWhiteSpace(PrintServiceRaw)) return false;
            return string.Equals(PrintServiceRaw, "true", StringComparison.OrdinalIgnoreCase)
                || PrintServiceRaw == "1";
        }
    }

    public int? MachineID { get; set; }
    public string? MachineName { get; set; }
    public int? HelpersCount { get; set; }
}