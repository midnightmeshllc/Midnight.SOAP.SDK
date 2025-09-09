using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing job types in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobTypeList")]
public class JobTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the job type list request.
    /// </summary>
    public required JobTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing job types in the Midnight SOAP API.
/// </summary>
public class JobTypeListInputParameter
{
    /// <summary>Gets or sets the job type ID.</summary>
    public int? JobTypeID { get; set; }
    /// <summary>Gets or sets the job type description.</summary>
    public string? JobTypeDescription { get; set; }
    /// <summary>Gets or sets a value indicating whether the job type is active.</summary>
    public bool Active { get; set; } = true;
}