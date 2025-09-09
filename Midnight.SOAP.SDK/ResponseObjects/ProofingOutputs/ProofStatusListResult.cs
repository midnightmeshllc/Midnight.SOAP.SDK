using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of a proof status list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofStatusListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of request statuses returned by the request.
    /// </summary>
    [XmlArray("RequestStatuses")]
    [XmlArrayItem("RequestStatus")]
    public List<RequestStatus> RequestStatuses { get; set; } = new List<RequestStatus>();
}

/// <summary>
/// Represents a request status in the Midnight SOAP API.
/// </summary>
public class RequestStatus
{
    /// <summary>Gets or sets the status code.</summary>
    public string? Code { get; set; }
    /// <summary>Gets or sets the name of the status.</summary>
    public string? Name { get; set; }

    /// <summary>Gets or sets the raw value indicating if the status is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the status is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}