
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("UnitMeasureList")]
public class UnitMeasureListRequestBody
{
    public required UnitMeasureListInputParameter InputParameter { get; set; }
}

public class UnitMeasureListInputParameter
{
    public string? UnitMeasureCode { get; set; }
    public string? UnitMeasureName { get; set; }
    public decimal? CalculationValue { get; set; }
}