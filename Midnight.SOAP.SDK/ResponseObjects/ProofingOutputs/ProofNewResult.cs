using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of creating a new proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new proof request.
    /// </summary>
    [XmlElement("RequestID")]
    public int RequestID { get; set; }
}
