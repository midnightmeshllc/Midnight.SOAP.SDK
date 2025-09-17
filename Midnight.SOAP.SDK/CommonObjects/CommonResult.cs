using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.CommonObjects;

/// <summary>
/// Represents a common result returned by the Midnight SOAP API.
/// </summary>
public class CommonResult
{
    /// <summary>Gets or sets the return code.</summary>
    public int ReturnCode { get; set; }
    /// <summary>Gets or sets the list of return errors.</summary>
    [XmlElement("ReturnErrors")]
    public List<ReturnError> ReturnErrors { get; set; } = new List<ReturnError>();
}

/// <summary>
/// Represents an error returned by the Midnight SOAP API.
/// </summary>
public class ReturnError
{
    /// <summary>Gets or sets the error message.</summary>
    [XmlElement("Error")]
    public string? Error { get; set; } = null;
}