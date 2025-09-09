using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of an operation list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OperationListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of operations returned by the request.
    /// </summary>
    [XmlArray("Operations")]
    [XmlArrayItem("Operation")]
    public List<Operation> Operations { get; set; } = new List<Operation>();
}

/// <summary>
/// Represents an operation in the Midnight SOAP API.
/// </summary>
public class Operation
{
    /// <summary>Gets or sets the operation code.</summary>
    public string? OperationCode { get; set; }
    /// <summary>Gets or sets the description of the operation.</summary>
    public string? Description { get; set; }

    /// <summary>Gets or sets the raw value indicating if the operation is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the operation is active.</summary>
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