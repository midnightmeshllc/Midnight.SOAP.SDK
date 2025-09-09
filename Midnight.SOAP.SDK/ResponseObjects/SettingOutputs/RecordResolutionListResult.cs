using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a record resolution list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class RecordResolutionListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of record resolutions returned by the request.
    /// </summary>
    [XmlArray("RecordResolutions")]
    [XmlArrayItem("RecordResolution")]
    public List<RecordResolution> RecordResolutions { get; set; } = new List<RecordResolution>();
}

/// <summary>
/// Represents a record resolution in the Midnight SOAP API.
/// </summary>
public class RecordResolution
{
    /// <summary>Gets or sets the record resolution ID.</summary>
    public int? RecordResolutionID { get; set; }
    /// <summary>Gets or sets the name of the record resolution.</summary>
    public string? Name { get; set; }
}