using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a job frequency list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobFrequencyListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of job frequencies returned by the request.
    /// </summary>
    [XmlArray("JobFrequencies")]
    [XmlArrayItem("JobFrequency")]
    public List<JobFrequency> JobFrequencies { get; set; } = new List<JobFrequency>();
}

/// <summary>
/// Represents a job frequency in the Midnight SOAP API.
/// </summary>
public class JobFrequency
{
    /// <summary>Gets or sets the job frequency ID.</summary>
    public int? JobFrequencyID { get; set; }
    /// <summary>Gets or sets the job frequency description.</summary>
    public string? JobFrequencyDescription { get; set; }
}