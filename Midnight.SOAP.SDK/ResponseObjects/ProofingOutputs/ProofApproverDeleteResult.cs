using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of deleting an approver from a proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofApproverDeleteResult : CommonResult
{
}
