
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

[XmlRoot("DJBStatusUpdate")]
public class DJBStatusUpdateRequestBody
{
    public required DJBStatusUpdateInputParameter InputParameter { get; set; }
}

public class DJBStatusUpdateInputParameter
{
    public required int DJBDetailID { get; set; }
    public required int DJBStatusID { get; set; }
}