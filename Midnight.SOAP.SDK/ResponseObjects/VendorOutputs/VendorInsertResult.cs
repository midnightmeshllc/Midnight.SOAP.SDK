using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;

/// <summary>
/// Represents the result of a vendor insert operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class VendorInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted vendor.
    /// </summary>
    [XmlElement("VendorID")]
    public int VendorID { get; set; }
    /// <summary>
    /// Gets or sets the creation date and time of the vendor record.
    /// </summary>
    [XmlElement("CreateDateTime")]
    public string? CreateDateTime { get; set; }
}
