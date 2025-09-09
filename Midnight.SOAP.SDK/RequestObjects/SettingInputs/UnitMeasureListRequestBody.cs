using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing unit measures in the Midnight SOAP API.
/// </summary>
[XmlRoot("UnitMeasureList")]
public class UnitMeasureListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the unit measure list request.
    /// </summary>
    public required UnitMeasureListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing unit measures in the Midnight SOAP API.
/// </summary>
public class UnitMeasureListInputParameter
{
    /// <summary>Gets or sets the unit measure code.</summary>
    public string? UnitMeasureCode { get; set; }
    /// <summary>Gets or sets the unit measure name.</summary>
    public string? UnitMeasureName { get; set; }
    /// <summary>Gets or sets the calculation value.</summary>
    public decimal? CalculationValue { get; set; }
}