using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

[XmlRoot("OrderQuickAdd")]
public class OrderQuickAddRequestBody
{
    [Required]
    public required OrderQuickAddInputParameter Order { get; set; }
}


public class OrderQuickAddInputParameter
{
    [Required]
    public int CustomerID { get; set; }
    public string? OrderDate { get; set; }
    public int ExpectedQuantity { get; set; }
    public string? OrderComments { get; set; }
    public string? TemplateID { get; set; }
    public string CopyVersions { get; set; } = "Y";
    public string UpdatePricing { get; set; } = "N";
}

