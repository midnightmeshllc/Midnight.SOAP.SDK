using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for updating a proof in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestUpdate")]
public class ProofUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof update request.
    /// </summary>
    public required ProofUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating a proof in the Midnight SOAP API.
/// </summary>
public class ProofUpdateInputParameter
{
    /// <summary>Gets or sets the list of proof updates.</summary>
    [XmlArray("Requests")]
    [XmlArrayItem("Request")]
    public required List<ProofUpdate> Requests { get; set; } = new List<ProofUpdate>();
}

/// <summary>
/// Represents a proof update in the Midnight SOAP API.
/// </summary>
public class ProofUpdate
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }

    /// <summary>Gets or sets the request date.</summary>
    public string? RequestDate { get; set; }
    public bool ShouldSerializeRequestDate() => IsSet(RequestDate);

    /// <summary>Gets or sets the request status code.</summary>
    public string? RequestStatusCode { get; set; }
    public bool ShouldSerializeRequestStatusCode() => IsSet(RequestStatusCode);

    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; }
    public bool ShouldSerializeEstimateID() => EstimateID.HasValue;

    /// <summary>Gets or sets the estimate detail ID.</summary>
    public int? EstimateDetailID { get; set; }
    public bool ShouldSerializeEstimateDetailID() => EstimateDetailID.HasValue;

    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    public bool ShouldSerializeVersionID() => VersionID.HasValue;

    /// <summary>Gets or sets the order version detail ID.</summary>
    public int? OrderVersionDetailID { get; set; }
    public bool ShouldSerializeOrderVersionDetailID() => OrderVersionDetailID.HasValue;

    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
    public bool ShouldSerializeDescription() => IsSet(Description);

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}