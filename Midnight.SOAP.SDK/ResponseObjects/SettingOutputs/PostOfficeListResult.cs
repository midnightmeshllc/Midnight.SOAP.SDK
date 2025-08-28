using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a post office list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PostOfficeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of post offices returned by the request.
    /// </summary>
    [XmlArray("PostOffices")]
    [XmlArrayItem("PostOffice")]
    public List<PostOffice> PostOffices { get; set; } = new List<PostOffice>();
}

/// <summary>
/// Represents a post office in the Midnight SOAP API.
/// </summary>
public class PostOffice
{
    /// <summary>Gets or sets the post office ID.</summary>
    public int? PostOfficeID { get; set; }
    /// <summary>Gets or sets the name of the post office.</summary>
    public string? Name { get; set; }
}