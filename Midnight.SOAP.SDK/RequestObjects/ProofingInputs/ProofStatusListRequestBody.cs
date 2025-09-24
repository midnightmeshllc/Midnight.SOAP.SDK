using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for listing proof statuses in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestStatusList")]
public class ProofStatusListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof status list request.
    /// </summary>
    public required ProofStatusListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing proof statuses in the Midnight SOAP API.
/// </summary>
public class ProofStatusListInputParameter
{
    /// <summary>Gets or sets the code.</summary>
    [XmlElement(IsNullable = true)]
    public string? Code { get; set; }
    /// <summary>Gets or sets the name.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the status is active.</summary>
    public bool Active { get; set; } = true;
}