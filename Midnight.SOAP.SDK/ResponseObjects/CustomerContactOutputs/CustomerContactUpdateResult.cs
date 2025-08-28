using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

/// <summary>
/// Represents the result of updating a customer contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerContactUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated contact.
    /// </summary>
    public int? ContactID { get; set; }
}
