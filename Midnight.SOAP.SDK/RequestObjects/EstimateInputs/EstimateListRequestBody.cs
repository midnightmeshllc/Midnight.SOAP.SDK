
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("EstimateList")]
public class EstimateListRequestBody
{
    public required EstimateListInputParameter InputParameter { get; set; }
}

public class EstimateListInputParameter : UserDefinedFields
{
    public string? EstimateNumber { get; set; }
    public string? CopyFromEstimateNumber { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerCode { get; set; }
    public string? EstimateDateFrom { get; set; }
    public string? EstimateDateTo { get; set; }
    public string? EstimateStatus { get; set; }
    public string? EstimateDueDateFrom { get; set; }
    public string? EstimateDueDateTo { get; set; }
}