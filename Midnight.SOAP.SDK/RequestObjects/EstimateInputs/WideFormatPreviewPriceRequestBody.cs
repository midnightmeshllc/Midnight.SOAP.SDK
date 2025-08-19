
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("WFPreviewPrice")]
public class WideFormatPreviewPriceRequestBody
{
    public required int WideFormatProductTypeID { get; set; }
    public required int CustomerID { get; set; }
    public required int Quantity { get; set; }
}
