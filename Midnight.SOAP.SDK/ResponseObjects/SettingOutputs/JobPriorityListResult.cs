using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a job priority list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobPriorityListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of job priorities returned by the request.
    /// </summary>
    [XmlArray("JobPriorities")]
    [XmlArrayItem("JobPriority")]
    public List<JobPriority> JobPriorities { get; set; } = new List<JobPriority>();
}

/// <summary>
/// Represents a job priority in the Midnight SOAP API.
/// </summary>
public class JobPriority
{
    /// <summary>Gets or sets the job priority ID.</summary>
    public int? JobPriorityID { get; set; }
    /// <summary>Gets or sets the job priority description.</summary>
    public string? JobPriorityDescription { get; set; }
}