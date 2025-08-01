
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

[XmlRoot("OrderVersionInventoryInsert")]
public class OrderVersionInventoryInsertRequestBody
{
    public required OrderVersionInventoryInsertInputParameter InputParameter { get; set; }
}

public class OrderVersionInventoryInsertInputParameter
{
    [Required]
    public int VersionID { get; set; }
    [Required]
    public int ItemID { get; set; }
    public string? Description { get; set; }
    public int QuantityNeeded { get; set; }
    public int Priority { get; set; }
    public string? Notes { get; set; }
}