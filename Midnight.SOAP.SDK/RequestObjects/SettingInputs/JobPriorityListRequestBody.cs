using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing job priorities in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobPriorityList")]
public class JobPriorityListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the job priority list request.
    /// </summary>
    public required JobPriorityListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing job priorities in the Midnight SOAP API.
/// </summary>
public class JobPriorityListInputParameter
{
    /// <summary>Gets or sets the job priority ID.</summary>
    public int? JobPriorityID { get; set; } = null;
    /// <summary>Gets or sets the job priority description.</summary>
    public string? JobPriorityDescription { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the job priority is active.</summary>
    public bool Active { get; set; }
}