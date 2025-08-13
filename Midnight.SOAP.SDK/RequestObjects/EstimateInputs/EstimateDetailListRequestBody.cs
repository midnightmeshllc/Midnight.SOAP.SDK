using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("EstimateDetailList")]
public class EstimateDetailListRequestBody
{
    public required EstimateDetailListInputParameter InputParameter { get; set; }
}

public class EstimateDetailListInputParameter
{
    public required int EstimateID { get; set; }
}