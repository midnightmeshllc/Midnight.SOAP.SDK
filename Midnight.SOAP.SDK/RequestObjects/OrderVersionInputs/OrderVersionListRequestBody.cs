using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionList")]
public class OrderVersionListRequestBody
{
    public required OrderVersionListInputParameter InputParameter { get; set; }
}

public class OrderVersionListInputParameter
{
    [Required]
    public int OrderID { get; set; }
    public string? OrderDropDateFrom { get; set; } = string.Empty;
    public string? OrderDropDateTo { get; set; } = string.Empty;
}