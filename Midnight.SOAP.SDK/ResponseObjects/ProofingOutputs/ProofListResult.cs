using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of a proof list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of proof requests returned by the request.
    /// </summary>
    [XmlArray("Requests")]
    [XmlArrayItem("Request")]
    public List<Request> Requests { get; set; } = new List<Request>();
}

/// <summary>
/// Represents a proof request in the Midnight SOAP API.
/// </summary>
public class Request
{
    /// <summary>Gets or sets the request type ID.</summary>
    public int? RequestTypeID { get; set; }
    /// <summary>Gets or sets the request ID.</summary>
    public int? RequestID { get; set; }
    /// <summary>Gets or sets the description of the request.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the request status code.</summary>
    public string? RequestStatusCode { get; set; }
    /// <summary>Gets or sets the request date.</summary>
    public string? RequestDate { get; set; }
    /// <summary>Gets or sets the user name associated with the request.</summary>
    public string? UserName { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; }
    /// <summary>Gets or sets the estimate detail ID.</summary>
    public int? EstimateDetailID { get; set; }
    /// <summary>Gets or sets the estimate service name.</summary>
    public string? EstimateServiceName { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int? OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the order service name.</summary>
    public string? OrderServiceName { get; set; }
    /// <summary>Gets or sets the notes for the request.</summary>
    public string? Notes { get; set; }

    /// <summary>Gets or sets the list of request approvers for the request.</summary>
    [XmlArray("RequestApprovers")]
    [XmlArrayItem("RequestApprover")]
    public List<RequestApprover> RequestApprovers { get; set; } = new List<RequestApprover>();
}

/// <summary>
/// Represents an approver for a proof request in the Midnight SOAP API.
/// </summary>
public class RequestApprover
{
    /// <summary>Gets or sets the request approver ID.</summary>
    public int? RequestApproverID { get; set; }
    /// <summary>Gets or sets the name of the approver.</summary>
    public string? ApproverName { get; set; }
    /// <summary>Gets or sets the email address of the approver.</summary>
    public string? ApproverEmailAddress { get; set; }
    /// <summary>Gets or sets the status of the approver.</summary>
    public string? ApproverStatus { get; set; }
}