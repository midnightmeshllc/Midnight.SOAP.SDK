using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of updating a proof request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofUpdateResult
{
    /// <summary>
    /// Gets or sets the list of update results.
    /// </summary>
    [XmlElement("Results")]
    public List<Result> Results { get; set; } = new List<Result>();
}

/// <summary>
/// Represents an individual update result for a proof request in the Midnight SOAP API.
/// </summary>
public class Result : CommonResult
{
}