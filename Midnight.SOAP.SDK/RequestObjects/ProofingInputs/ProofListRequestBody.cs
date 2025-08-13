
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestList")]
public class ProofListRequestBody
{
    public required ProofListInputParameter InputParameter { get; set; }
}

public class ProofListInputParameter
{
    public string? RequestStatusCode { get; set; }
    public int? RequestID { get; set; }
    public required string RequestDateFrom { get; set; }
    public required string RequestDateTo { get; set; }
    public string? UserName { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public int? EstimateID { get; set; }
    public int? EstimateDetailID { get; set; }
    public string? EstimateServiceName { get; set; }
    public int? OrderID { get; set; }
    public int? OrderVersionDetailID { get; set; }
    public string? OrderServiceName { get; set; }
}