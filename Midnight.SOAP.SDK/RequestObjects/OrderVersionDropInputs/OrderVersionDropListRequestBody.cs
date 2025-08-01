using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropList")]
public class OrderVersionDropListRequestBody
{
    public required OrderVersionDropListInputParameter InputParameter { get; set; }
}

public class OrderVersionDropListInputParameter
{
    [Required]
    public int VersionID { get; set; }
}