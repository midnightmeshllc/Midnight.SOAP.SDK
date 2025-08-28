using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of adding an attachment to an order in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderAddAttachmentResult : CommonResult
{
}
