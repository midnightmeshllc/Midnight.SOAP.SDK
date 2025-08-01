using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailList")]
public class OrderVersionDetailListRequestBody
{
    [Required]
    public required OrderVersionDetailListInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailListInputParameter
{
    [Required]
    public int VersionID { get; set; }
}