using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for deleting a proof in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestDelete")]
public class ProofDeleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof delete request.
    /// </summary>
    public required ProofDeleteInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for deleting a proof in the Midnight SOAP API.
/// </summary>
public class ProofDeleteInputParameter
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }
}