using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;

/// <summary>
/// Represents the result of a DJB job status list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class DJBJobStatusListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of DJB job statuses returned by the request.
    /// </summary>
    [XmlArray("DJBJobStatuses")]
    [XmlArrayItem("DJBJobStatus")]
    public List<DJBJobStatus> DJBJobStatuses { get; set; } = new List<DJBJobStatus>();
}

/// <summary>
/// Represents a DJB job status in the Midnight SOAP API.
/// </summary>
public class DJBJobStatus
{
    /// <summary>Gets or sets the DJB job status ID.</summary>
    [XmlElement("DJBJobStatusID")]
    public int DJBJobStatusID { get; set; }
    /// <summary>Gets or sets the status description.</summary>
    [XmlElement("Status")]
    public string Status { get; set; } = string.Empty;
}