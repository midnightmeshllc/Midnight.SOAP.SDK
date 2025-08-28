using Midnight.SOAP.SDK.CommonObjects;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a service list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ServiceListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of services returned by the request.
    /// </summary>
    [XmlArray("Services")]
    [XmlArrayItem("Service")]
    public List<ServiceSetting> Services { get; set; } = new List<ServiceSetting>();
}

/// <summary>
/// Represents a service setting in the Midnight SOAP API.
/// </summary>
public class ServiceSetting
{
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service type ID.</summary>
    public int? ServiceTypeID { get; set; }
    /// <summary>Gets or sets the service type name.</summary>
    public string? ServiceTypeName { get; set; }
    /// <summary>Gets or sets the service code.</summary>
    public string? Code { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    public string? Name { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is taxable.</summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is taxable.</summary>
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

    /// <summary>Gets or sets the price.</summary>
    public decimal? Price { get; set; }
    /// <summary>Gets or sets the minimum price.</summary>
    public decimal? MinimumPrice { get; set; }
    /// <summary>Gets or sets the run rate.</summary>
    public decimal? RunRate { get; set; }
    /// <summary>Gets or sets the wizard number.</summary>
    public int? WizardNumber { get; set; }
    /// <summary>Gets or sets the machine department ID.</summary>
    public int? MachineDepartmentID { get; set; }
    /// <summary>Gets or sets the machine department name.</summary>
    public string? MachineDepartmentName { get; set; }
    /// <summary>Gets or sets the GLID.</summary>
    public string? GLID { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is scheduled.</summary>
    [XmlElement("Schedule")]
    public string? ScheduleRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is scheduled.</summary>
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

    /// <summary>Gets or sets the number of schedule days.</summary>
    public int? ScheduleDays { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is outside.</summary>
    [XmlElement("Outside")]
    public string? OutsideRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is outside.</summary>
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

    /// <summary>Gets or sets the itemization code.</summary>
    public string? ItemizationCode { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is active.</summary>
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

    /// <summary>Gets or sets the size description.</summary>
    public string? SizeDescr { get; set; }
    /// <summary>Gets or sets the labor rate.</summary>
    public decimal? LaborRate { get; set; }
    /// <summary>Gets or sets the material rate.</summary>
    public decimal? MaterialRate { get; set; }
    /// <summary>Gets or sets the run rate cost.</summary>
    public decimal? RunRateCost { get; set; }
    /// <summary>Gets or sets the make ready hours.</summary>
    public decimal? MakeReadyHrs { get; set; }
    /// <summary>Gets or sets the make ready cost.</summary>
    public decimal? MakeReadyCost { get; set; }
    /// <summary>Gets or sets the fold finished size.</summary>
    public decimal? FoldFinishedSize { get; set; }
    /// <summary>Gets or sets the fold travel direction.</summary>
    public decimal? FoldTravelDirection { get; set; }
    /// <summary>Gets or sets the fold gap.</summary>
    public decimal? FoldGap { get; set; }
    /// <summary>Gets or sets the fold feet per hour.</summary>
    public int? FoldFtPerHr { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is a cost service.</summary>
    [XmlElement("CostService")]
    public string? CostServiceRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is a cost service.</summary>
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

    /// <summary>Gets or sets the cost service type ID.</summary>
    public int? CostServiceTypeID { get; set; }
    /// <summary>Gets or sets the cost service type name.</summary>
    public string? CostServiceTypeName { get; set; }

    /// <summary>Gets or sets the raw value indicating if the service is a print service.</summary>
    [XmlElement("PrintService")]
    public string? PrintServiceRaw { get; set; }
    /// <summary>Gets a value indicating whether the service is a print service.</summary>
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

    /// <summary>Gets or sets the machine ID.</summary>
    public int? MachineID { get; set; }
    /// <summary>Gets or sets the machine name.</summary>
    public string? MachineName { get; set; }
    /// <summary>Gets or sets the helpers count.</summary>
    public int? HelpersCount { get; set; }
}