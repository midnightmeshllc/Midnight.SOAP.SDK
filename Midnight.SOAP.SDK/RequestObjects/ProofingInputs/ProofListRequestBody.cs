using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for listing proofs in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestList")]
public class ProofListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof list request.
    /// </summary>
    public required ProofListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing proofs in the Midnight SOAP API.
/// </summary>
public class ProofListInputParameter
{
    /// <summary>Gets or sets the request status code.</summary>
    public string? RequestStatusCode { get; set; } = null;
    /// <summary>Gets or sets the request ID.</summary>
    public int? RequestID { get; set; } = null;
    /// <summary>Gets or sets the request date from.</summary>
    public required string RequestDateFrom { get; set; }
    /// <summary>Gets or sets the request date to.</summary>
    public required string RequestDateTo { get; set; }
    /// <summary>Gets or sets the user name.</summary>
    public string? UserName { get; set; } = null;
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; } = null;
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; } = null;
    /// <summary>Gets or sets the estimate detail ID.</summary>
    public int? EstimateDetailID { get; set; } = null;
    /// <summary>Gets or sets the estimate service name.</summary>
    public string? EstimateServiceName { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int? OrderVersionDetailID { get; set; } = null;
    /// <summary>Gets or sets the order service name.</summary>
    public string? OrderServiceName { get; set; } = null;
}