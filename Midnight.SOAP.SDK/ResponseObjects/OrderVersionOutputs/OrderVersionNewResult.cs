using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

/// <summary>
/// Represents the result of creating a new order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new order version.
    /// </summary>
    [XmlElement("VersionID")]
    public int VersionID { get; set; }
}
