using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of adding an attachment to a proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofAddAtachmentResult : CommonResult
{
}
