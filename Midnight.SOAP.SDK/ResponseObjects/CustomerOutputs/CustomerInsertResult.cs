using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of inserting a customer in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted customer.
    /// </summary>
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
}
