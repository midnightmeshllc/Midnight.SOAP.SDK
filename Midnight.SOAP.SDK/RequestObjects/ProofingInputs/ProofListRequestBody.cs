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
    [XmlElement(IsNullable = true)]
    public string? RequestStatusCode { get; set; }
    /// <summary>Gets or sets the request ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? RequestID { get; set; }
    /// <summary>Gets or sets the request date from.</summary>
    public required string RequestDateFrom { get; set; }
    /// <summary>Gets or sets the request date to.</summary>
    public required string RequestDateTo { get; set; }
    /// <summary>Gets or sets the user name.</summary>
    [XmlElement(IsNullable = true)]
    public string? UserName { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the estimate ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? EstimateID { get; set; }
    /// <summary>Gets or sets the estimate detail ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? EstimateDetailID { get; set; }
    /// <summary>Gets or sets the estimate service name.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateServiceName { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the order version detail ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the order service name.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderServiceName { get; set; }
}