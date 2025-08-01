using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionQuickAdd")]
public class OrderVersionQuickAddRequestBody
{
    public required OrderVersionQuickAddInputParameter OrderVersion { get; set; }
}

public class OrderVersionQuickAddInputParameter
{
    [Required]
    public required string OrderNumber { get; set; }
    public string? VersionDropDate { get; set; }
    public int? VersionQuantity { get; set; }
    public string? VersionName { get; set; }
    public string? VersionComments { get; set; }
    public string? TemplateOrderNumber { get; set; }
    public int TemplateVersionSuffix { get; set; }
}