using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a postage status list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PostageStatusListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of postage statuses returned by the request.
    /// </summary>
    [XmlArray("PostageStatuses")]
    [XmlArrayItem("PostageStatus")]
    public List<PostageStatus> PostageStatuses { get; set; } = new List<PostageStatus>();
}

/// <summary>
/// Represents a postage status in the Midnight SOAP API.
/// </summary>
public class PostageStatus
{
    /// <summary>Gets or sets the postage status ID.</summary>
    public int? PostageStatusID { get; set; }
    /// <summary>Gets or sets the name of the postage status.</summary>
    public string? Name { get; set; }
}