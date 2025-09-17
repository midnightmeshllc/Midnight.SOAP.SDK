using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing job frequencies in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobFrequencyList")]
public class JobFrequencyListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the job frequency list request.
    /// </summary>
    public required JobFrequencyListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing job frequencies in the Midnight SOAP API.
/// </summary>
public class JobFrequencyListInputParameter
{
    /// <summary>Gets or sets the job frequency ID.</summary>
    public int? JobFrequencyID { get; set; } = null;
    /// <summary>Gets or sets the job frequency description.</summary>
    public string? JobFrequencyDescription { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the job frequency is active.</summary>
    public bool Active { get; set; } = true;
}