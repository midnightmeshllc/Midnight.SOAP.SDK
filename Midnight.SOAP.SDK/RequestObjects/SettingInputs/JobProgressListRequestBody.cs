using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing job progress codes in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobProgressList")]
public class JobProgressListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the job progress list request.
    /// </summary>
    public required JobProgressListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing job progress codes in the Midnight SOAP API.
/// </summary>
public class JobProgressListInputParameter
{
    /// <summary>Gets or sets the job progress code.</summary>
    public string? JobProgressCode { get; set; }
    /// <summary>Gets or sets the job progress name.</summary>
    public string? JobProgressName { get; set; }
    /// <summary>Gets or sets the job progress sort order.</summary>
    public int? JobProgressSort { get; set; }
    /// <summary>Gets or sets a value indicating whether the job progress code is active.</summary>
    public bool Active { get; set; } = true;
}