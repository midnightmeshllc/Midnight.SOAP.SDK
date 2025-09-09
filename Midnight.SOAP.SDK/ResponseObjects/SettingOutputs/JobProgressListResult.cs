using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a job progress list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobProgressListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of job progress entries returned by the request.
    /// </summary>
    [XmlArray("JobProgressList")]
    [XmlArrayItem("JobProgress")]
    public List<JobProgress> JobProgressList { get; set; } = new List<JobProgress>();
}

/// <summary>
/// Represents a job progress entry in the Midnight SOAP API.
/// </summary>
public class JobProgress
{
    /// <summary>Gets or sets the job progress code.</summary>
    public string? JobProgressCode { get; set; }
    /// <summary>Gets or sets the job progress name.</summary>
    public string? JobProgressName { get; set; }
    /// <summary>Gets or sets the job progress sort order.</summary>
    public int? JobProgressSort { get; set; }
}