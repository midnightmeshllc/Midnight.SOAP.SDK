using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of adding an approver to a proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofAddApproverResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the request approver.
    /// </summary>
    [XmlElement("RequestApproverID")]
    public int RequestApproverID { get; set; }
}
