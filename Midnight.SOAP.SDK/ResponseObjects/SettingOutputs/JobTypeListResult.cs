using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a job type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of job types returned by the request.
    /// </summary>
    [XmlArray("JobTypes")]
    [XmlArrayItem("JobType")]
    public List<JobType> JobTypes { get; set; } = new List<JobType>();
}

/// <summary>
/// Represents a job type in the Midnight SOAP API.
/// </summary>
public class JobType
{
    /// <summary>Gets or sets the job type ID.</summary>
    public int? JobTypeID { get; set; }
    /// <summary>Gets or sets the job type description.</summary>
    public string? JobTypeDescription { get; set; }
}