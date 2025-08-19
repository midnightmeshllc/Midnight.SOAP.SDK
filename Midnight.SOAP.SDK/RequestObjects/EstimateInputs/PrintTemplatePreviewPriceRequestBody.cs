
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("PrintTemplatePreviewPrice")]
public class PrintTemplatePreviewPriceRequestBody
{
    public required int ProjectTypeID { get; set; }
    public required int CustomerID { get; set; }
    public required int Quantity { get; set; }
}
