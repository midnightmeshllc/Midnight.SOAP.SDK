using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a unit measure list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class UnitMeasureListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of unit measures returned by the request.
    /// </summary>
    [XmlArray("UnitMeasures")]
    [XmlArrayItem("UnitMeasure")]
    public List<UnitMeasure> UnitMeasures { get; set; } = new List<UnitMeasure>();
}

/// <summary>
/// Represents a unit measure in the Midnight SOAP API.
/// </summary>
public class UnitMeasure
{
    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; }
    /// <summary>Gets or sets the unit measure name.</summary>
    public string? UnitMeasureName { get; set; }
    /// <summary>Gets or sets the calculation value for the unit measure.</summary>
    public decimal? CalculationValue { get; set; }
}