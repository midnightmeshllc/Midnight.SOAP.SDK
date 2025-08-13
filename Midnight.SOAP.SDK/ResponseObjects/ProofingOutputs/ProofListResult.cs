
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofListResult : CommonResult
{
    [XmlArray("Requests")]
    [XmlArrayItem("Request")]
    public List<Request> Requests { get; set; } = new List<Request>();
}

public class Request
{
    public int? RequestTypeID { get; set; }
    public int? RequestID { get; set; }
    public string? Description { get; set; }
    public string? RequestStatusCode { get; set; }
    public string? RequestDate { get; set; }
    public string? UserName { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public int? EstimateID { get; set; }
    public int? EstimateDetailID { get; set; }
    public string? EstimateServiceName { get; set; }
    public int? OrderID { get; set; }
    public int? OrderVersionDetailID { get; set; }
    public string? OrderServiceName { get; set; }
    public string? Notes { get; set; }

    [XmlArray("RequestApprovers")]
    [XmlArrayItem("RequestApprover")]
    public List<RequestApprover> RequestApprovers { get; set; } = new List<RequestApprover>();
}

public class RequestApprover
{
    public int? RequestApproverID { get; set; }
    public string? ApproverName { get; set; }
    public string? ApproverEmailAddress { get; set; }
    public string? ApproverStatus { get; set; }
}