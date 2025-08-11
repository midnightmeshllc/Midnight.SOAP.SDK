
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class UnitMeasureListResult : CommonResult
{
    [XmlArray("UnitMeasures")]
    [XmlArrayItem("UnitMeasure")]
    public List<UnitMeasure> UnitMeasures { get; set; } = new List<UnitMeasure>();
}

public class UnitMeasure
{
    public string? UnitMeasureCode { get; set; }
    public string? UnitMeasureName { get; set; }
    public decimal? CalculationValue { get; set; }
}