using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for creating a new proof in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestNew")]
public class ProofNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof new request.
    /// </summary>
    public required ProofNewInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new proof in the Midnight SOAP API.
/// </summary>
public class ProofNewInputParameter
{
    /// <summary>Gets or sets the list of requests.</summary>
    public required List<RequestNew> Requests { get; set; } = new List<RequestNew>();
}

/// <summary>
/// Represents a new proof request in the Midnight SOAP API.
/// </summary>
public class RequestNew
{
    /// <summary>Gets or sets the request date.</summary>
    public required string RequestDate { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; } = null;
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; } = null;
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int? OrderVersionDetailID { get; set; } = null;
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
}